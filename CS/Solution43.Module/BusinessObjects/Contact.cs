using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
namespace Solution43.Module.BusinessObjects {
    [DefaultClassOptions]
    public class Contact : Person {
        public Contact(DevExpress.Xpo.Session session)
            : base(session) {
            
        }
    }
}
