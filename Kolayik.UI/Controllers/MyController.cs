using Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolayik.UI.Controllers
{
    public class MyController : Controller
    {
        public void AddErrorsToModelState(List<ErrorItem> errors)
        {
            foreach (ErrorItem item in errors)
            {
                ModelState.AddModelError(item.Key, item.Value);
            }
        }
    }
}
