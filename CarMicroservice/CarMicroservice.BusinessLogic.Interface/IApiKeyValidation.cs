using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMicroservice.BusinessLogic.Interface
{
    public  interface IApiKeyValidation
    {
        bool IsValidApiKey(string userApiKey);
    }
}
