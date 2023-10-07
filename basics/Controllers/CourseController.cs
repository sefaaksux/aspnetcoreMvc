using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{

    public IActionResult Index(){
        var kurs = new Course();
        kurs.id=1;
        kurs.title ="Asp.Net Core Kursu";
        kurs.description="Güzel ve eğlenceli bir kurstur !!";
        return View(kurs);
    }

    public IActionResult List(){

        var kurslar = new List<Course>(){
            new Course() {id=1, title="ASP net core Kursu",description="Güzel bir kurs",image="computer.jpeg"},
            new Course() {id=2, title="Javascript Kursu",description="Güzel bir kurs",image="sefa-logo.png"},
            new Course() {id=3, title="c# Kursu",description="Güzel bir kurs",image="sefaResim.jpeg"}
        };

        return View(kurslar);
    }




}
