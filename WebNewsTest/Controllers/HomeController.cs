using Microsoft.AspNetCore.Mvc;
using System; 
using System.Collections.Generic; 
using WebNewsTest.Models;

namespace WebNewsTest.Controllers
{
    public class NewsController : Controller
    {
        private List<NewsItem> _news = new List<NewsItem>();
        public NewsController()
        {
            // Заглушка для списка новостей
            _news.Add(new NewsItem { Id = 1, Title = "Первая новость", Content = "Содержание первой новости", CreatedAt = DateTime.Now });
            _news.Add(new NewsItem { Id = 2, Title = "Вторая новость", Content = "Содержание второй новости", CreatedAt = DateTime.Now });
        }

        public IActionResult Index()
        {
            return View(_news);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(NewsItem newsItem)
        {
            // Здесь должен быть код для сохранения новости
            _news.Add(newsItem);
            return RedirectToAction("Index");
        }
    }
}
