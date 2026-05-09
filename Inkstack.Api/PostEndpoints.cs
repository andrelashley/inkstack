using Microsoft.EntityFrameworkCore;
using Inkstack.Api.Data;
using Inkstack.Core.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace Inkstack.Api;

public static class PostEndpoints
{
    public static void MapPostEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Post").WithTags(nameof(Post));

        group.MapGet("/", async (InkstackApiContext db) =>
        {
            return await db.Post.ToListAsync();
        })
        .WithName("GetAllPosts");

        group.MapGet("/{id}", async Task<Results<Ok<Post>, NotFound>> (int id, InkstackApiContext db) =>
        {
            return await db.Post.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is Post model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetPostById");

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Post post, InkstackApiContext db) =>
        {
            var affected = await db.Post
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.Id, post.Id)
                    .SetProperty(m => m.Title, post.Title)
                    .SetProperty(m => m.ShortDescription, post.ShortDescription)
                    );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdatePost");

        group.MapPost("/", async (Post post, InkstackApiContext db) =>
        {
            db.Post.Add(post);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Post/{post.Id}",post);
        })
        .WithName("CreatePost");

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, InkstackApiContext db) =>
        {
            var affected = await db.Post
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeletePost");
    }
}
