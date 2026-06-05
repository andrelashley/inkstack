import { useState, useEffect } from "react";

// const BASE_API_URL = process.env.REACT_APP_BASE_API_URL;

export default function Posts() {
  const [posts, setPosts] = useState<any[]>([]);
  const baseUrl = import.meta.env.VITE_REACT_APP_BASE_API_URL;

  useEffect(() => {
    (async () => {
      const response = await fetch(baseUrl + '/api/posts');
      if (response.ok) {
        const results = await response.json();
        setPosts(results);
      }
      else {
        setPosts([]);
      }
    })();
  }, []);

  return (  
      <div>
        {posts === undefined ?
        <p>Loading...</p>
        :
        posts.map(post => {
          return (
            <p key={post.id}>
              <br />
              {post.title}
            </p>
          );
      })}
      </div>
  )
}

