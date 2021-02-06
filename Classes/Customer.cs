using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer//müşterinin özellikleri
    {
        //field
        // public string FirstName;
        //property :  eğer bir class ın içinde class ı anlatan bir özellik tanımlayacaksak  prop. olarak tanımlarız
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        //mesela biz özelliğe bir kural koymak istiyoruz . Örn : isimlerin başına Mrs. gelicek bunu yapmak için de bizim get ve set i genişletmemiz gerekiyor.
        //private string _firstName;field üzerinde get ve set ederken olaya başka bir şey eklemek istersek böyle kullanıyoruz
        //public string FirstName { --- implatasyon gizlenmesi
        //    get
        //    {
        //        return "Mrs." + _firstName;

        //    }
        //    set {
        //        _firstName = value;
        //    }
        //}



    }
}
