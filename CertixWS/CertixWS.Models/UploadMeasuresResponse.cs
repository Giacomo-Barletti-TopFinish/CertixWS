using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CertixWS.Models
{
    [DataContract]

    public class UploadMeasuresResponse
    {
        [DataMember(Name = "Status")]
        public string Status { get; set; }
        [DataMember(Name = "Error")]
        public string Error { get; set; }
    }
}
