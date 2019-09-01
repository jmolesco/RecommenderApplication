using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Response;

namespace APP_ADMIN.Validator
{
    public class ValidateModelStateFilter : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var fluentErrors = new BadRequestObjectResult(context.ModelState).Value;
                context.Result = new BadRequestObjectResult(GetError(fluentErrors));
            }

            base.OnResultExecuting(context);
        }
        private static ReturnErrorModel GetError(object errResult)
        {
            var errorModel = new ReturnErrorModel
            {
                Errors = errResult
            };
            return errorModel;
        }

    }

}