using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CertixWS.Models
{
    [DataContract]
    public class UploadCodeResponse
    {
        [DataMember(Name = "Status")]
        public string Status { get; set; }
        [DataMember(Name = "Error")]
        public string Error { get; set; }
        [DataMember(Name = "IdMeasure")]
        public string IdMeasure { get; set; }

        [DataMember(Name = "Materials")]
        public List<string> Materials { get; set; }
    }
}
