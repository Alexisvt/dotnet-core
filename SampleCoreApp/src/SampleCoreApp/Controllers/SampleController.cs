using Microsoft.AspNetCore.Mvc;

namespace SampleCoreApp.Controller
{
    public class SampleController
    {
        #region Public Methods

        [HttpGet("/")]
        public string Index() => "Hello from MVC!";

        #endregion Public Methods
    }
}