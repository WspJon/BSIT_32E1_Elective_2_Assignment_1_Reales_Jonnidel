using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT_32E1_Elective_2_Assignment_1.Models;

namespace BSIT_32E1_Elective_2_Assignment_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    Number = 1,
                    Question = "What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",
                    Options = new()
                    {
                        "A) SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server.",
                        "B) SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON.",
                        "C) SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers.",
                        "D) SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly on the server."
                    },
                    CorrectAnswer = "B) SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON."
                },
                new QuizQuestion
                {
                    Number = 2,
                    Question = "Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller?",
                    Options = new()
                    {
                        "A) ControllerBase supports Razor View rendering using View() and ViewData.",
                        "B) ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead.",
                        "C) Controller is obsolete in .NET 8 and cannot handle HTTP POST requests.",
                        "D) ControllerBase automatically creates SQLite database files on application startup."
                    },
                    CorrectAnswer = "B) ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead."
                },
                new QuizQuestion
                {
                    Number = 3,
                    Question = "Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?",
                    Options = new()
                    {
                        "A) [Route]",
                        "B) [HttpGet]",
                        "C) [ApiController]",
                        "D) [FromQuery]"
                    },
                    CorrectAnswer = "C) [ApiController]"
                },
                new QuizQuestion
                {
                    Number = 4,
                    Question = "Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?",
                    Options = new()
                    {
                        "A) 200 OK",
                        "B) 201 Created",
                        "C) 204 No Content",
                        "D) 404 Not Found"
                    },
                    CorrectAnswer = "B) 201 Created"
                },
                new QuizQuestion
                {
                    Number = 5,
                    Question = "When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?",
                    Options = new()
                    {
                        "A) 200 OK",
                        "B) 201 Created",
                        "C) 204 No Content",
                        "D) 400 Bad Request"
                    },
                    CorrectAnswer = "C) 204 No Content"
                },
                new QuizQuestion
                {
                    Number = 6,
                    Question = "Which of the following endpoint URIs follows RESTful resource-oriented naming best practices?",
                    Options = new()
                    {
                        "A) GET /api/getAllCourses",
                        "B) GET /api/courses",
                        "C) POST /api/createNewCourseRecord",
                        "D) POST /api/deleteCourseById?id=5"
                    },
                    CorrectAnswer = "B) GET /api/courses"
                },
                new QuizQuestion
                {
                    Number = 7,
                    Question = "What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?",
                    Options = new()
                    {
                        "A) It connects the controller directly to an Entity Framework database context.",
                        "B) It maps incoming URI request paths to the controller class using the class name token.",
                        "C) It encrypts all incoming JSON payloads.",
                        "D) It enables Cross-Origin Resource Sharing (CORS) for external React apps."
                    },
                    CorrectAnswer = "B) It maps incoming URI request paths to the controller class using the class name token."
                },
                new QuizQuestion
                {
                    Number = 8,
                    Question = "Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?",
                    Options = new()
                    {
                        "A) POST",
                        "B) PUT",
                        "C) GET",
                        "D) DELETE"
                    },
                    CorrectAnswer = "C) GET"
                },
                new QuizQuestion
                {
                    Number = 9,
                    Question = "In ASP.NET Core Web API, what wrapper type allows action methods to return either a strongly typed domain object or standard HTTP status result helpers (such as Ok(), NotFound())?",
                    Options = new()
                    {
                        "A) Task<IActionResult>",
                        "B) ActionResult<T>",
                        "C) ViewResult",
                        "D) JsonResult"
                    },
                    CorrectAnswer = "B) ActionResult<T>"
                }
            };

            return View(questions);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}