using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CertixWS.Models
{
    [DataContract]
    public class UploadMeasuresElementRequest
    {
        [DataMember(Name = "Material")]
        public string Material { get; set; }
        [DataMember(Name = "Measure")]
        public decimal Measure { get; set; }
    }
}
