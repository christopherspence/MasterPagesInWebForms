using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterPagesInWebForms.Extensions
{
    public static class ControllerExtensions
    {
        public static ViewResult RazorView(this Controller controller, string viewName = null, object model = null)
        {
            if (model != null)
                controller.ViewData.Model = model;

            controller.ViewBag._ViewName = GetViewName(controller, viewName);

            return new ViewResult
            {
                ViewName = "RazorView",
                ViewData = controller.ViewData,
                TempData = controller.TempData
            };
        }

        static string GetViewName(Controller controller, string viewName)
        {
            return !string.IsNullOrEmpty(viewName)
                ? viewName
                : controller.RouteData.GetRequiredString("action");
        }
    }
}