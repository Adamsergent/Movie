using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Movie.Models;



namespace Movie.Controllers
{
        public class MovieController : Controller
       {
                private MovieX _model;
                public MovieController() { }
                public MovieController(MovieX model)
                {
                _model = model;
                }


                public ViewResult Movie()
                {
                    if (_model == null)
                    {
                        _model = new MovieX();
                        _model.Name = "IPhone 6";
                        _model.Description = "Better than the IPhone 5 etc";
                        _model.Price = 399.99M;
                    }
                    if (_model.Price > 200)
                    {
                        ViewBag.SubTitle = "Bling!";
                    }
                    else
                    {
                        ViewBag.SubTitle = "Cheap and nasty movie!";
                    }
                    return View(_model);
                }


            //
            // GET: /Movie/
            public ViewResult Index()
            {
                ViewBag.Title = "The Movies";
                ViewBag.WelcomeMessage = "Welcome to the Reviews. Kindly review all the movies!";
                ViewData["CurrentTime"] = DateTime.Now;
                return View();
            }
        

            public string Review(string Type, string Colour)
            {
            return String.Format("Review Type = {0}, Colour={1}", Type, Colour);
            }

            public RedirectResult Blockbuster ()
            {
                return Redirect("~/Movie/Name"); //Perement
            }                   
	

        //Method
        public string Film(string Type, string Genre)
        {
            return String.Format ("Film Type = {0}, Genre={1}", Type, Genre);
        }


    }

}

//Movie
//Review / Blockbuster
//Film (Genre)
//Genre

