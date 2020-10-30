using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studies2020.BusinessLayer
{
    public abstract class Operation
    {
        public abstract OperationResult execute();
    }

    public class OperationResult
    {
        public string Message { get; set; }
        public bool Success { get; set; } = true;
        public DtoBase[] Items { get; set; }
    }
}
