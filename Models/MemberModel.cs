using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class MemberModel
    {  
        [DisplayName("Member Name")]
        public string Name { get; set; }

        public string PhoneNumber { get; set; }
        [DisplayName("select file")]
        public string ImagePath { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
    }
}