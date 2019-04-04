using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace SampleWebApp.Pages
{
    public class SampleModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public string Value { get; set; }

        public SampleModel(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                 throw new ArgumentNullException(nameof(name));
            }

            this.Value = _configuration[name];
        }
    }
}