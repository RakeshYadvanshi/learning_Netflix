using System;

namespace Netflix.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public override string ToString()
        {
            return RequestId +" "+ ShowRequestId;
        }
    }
}
