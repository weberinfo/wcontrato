using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcontrato.Model
{

    public class ApiResponse
    {

        public int status { get; set; }
        public string msg { get; set; }
        public object data { get; set; }

    }

}
