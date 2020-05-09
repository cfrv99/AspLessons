using System;

namespace Asp.NetCore.ModelBinding.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        /*
         1.QueryBinding
         2.Body/Form Binding
         3.Route Binding
         */
    }
}