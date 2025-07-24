using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace NetMVC.Controllers
{
    public class StudentController : Controller
    {
        public string? hoTen { get; set; }
        public int tuoi { get; set; }
        [Key]
        public int maSinhVien { get; set; }
        public IActionResult Index()
        {
            return View();
        }
    }
}