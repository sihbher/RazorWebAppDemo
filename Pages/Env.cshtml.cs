using System.Collections;
using DispatcherWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DispatcherWebApp.Pages;

 public class EnvModel : PageModel
    {
        private readonly IConfiguration _config;

        public EnvModel(IConfiguration config)
        {
            _config = config;
        }

        public IDictionary<string, string> EnvironmentVariables { get; set; }

        public void OnGet()
        {
            EnvironmentVariables = Environment.GetEnvironmentVariables()
                .OfType<DictionaryEntry>().OrderBy(de => de.Key)
                .ToDictionary(de => (string)de.Key, de => (string)de.Value);
                
        }
    }