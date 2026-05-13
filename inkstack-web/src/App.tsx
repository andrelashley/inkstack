import Header from "./components/Header";
import Posts from "./components/Posts";

export default function App() {
  const posts = [
    {
      id: 1,
      text: 'Hello, world!',
      timestamp: 'a minute ago',
      author: {
        username: 'susan',
      }
    },
    {
      id: 2,
      text: 'Second post',
      timestamp: 'an hour ago',
      author: {
        username: 'john',
      }
  },
  ];

  return (
    <div style={{margin: '10px'}}>
      <Header />      
      <Posts />
    </div>
  )
}

