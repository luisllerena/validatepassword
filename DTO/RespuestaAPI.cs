using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class RespuestaAPI
    {
        public int Code { get; set; }
        public bool IsError { get; set; }
        public string Message { get; set; }
    }
}
