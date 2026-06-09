import { useState, useEffect } from "react";
import { useApi } from "../contexts/ApiProvider";

export default function Posts() {
  const [posts, setPosts] = useState<any[]>([]);
  const api = useApi();

  useEffect(() => {
    (async () => {
      const response = await api.get('/posts');
      if (response) {
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

