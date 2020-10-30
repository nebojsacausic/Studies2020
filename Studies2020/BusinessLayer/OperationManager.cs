using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studies2020.BusinessLayer
{
    class OperationManager
    {
        private OperationManager() { }
        private static OperationManager singleton;

        public static OperationManager Singleton
        {
            get
            {
                if (OperationManager.singleton == null)
                {
                    OperationManager.singleton = new OperationManager();
                }
                return OperationManager.singleton;
            }
        }
        public OperationResult executeOperation(Operation op)
        {
            try
            {
                OperationResult obj = op.execute();
                return obj;
            }
            catch (Exception ex)
            {
                OperationResult obj = new OperationResult();
                obj.Success = false;
                return obj;
            }
        }
    }
}
