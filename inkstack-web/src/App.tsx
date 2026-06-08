import { BrowserRouter, Navigate, Route, Routes } from "react-router-dom";
import Header from "./components/Header";
import ApiProvider from './contexts/ApiProvider';
import FeedPage from "./pages/FeedPage";
import ExplorePage from "./pages/ExplorePage";
import LoginPage from "./pages/LoginPage";

export default function App() {
  return (
    <div style={{margin: '10px'}}>
      <BrowserRouter>
        <ApiProvider>
        <Header />
        <Routes>
          <Route path="/" element={<FeedPage />} />
          <Route path="/explore" element={<ExplorePage />} />
          <Route path="/login" element={<LoginPage />} />
          <Route path="*" element={<Navigate to="/" />} />
        </Routes>
        </ApiProvider>
      </BrowserRouter>
    </div>
  )
}

