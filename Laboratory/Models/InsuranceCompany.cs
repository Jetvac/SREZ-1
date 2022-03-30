//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratory.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InsuranceCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsuranceCompany()
        {
            this.Insurances = new HashSet<Insurance>();
        }
    
        public int CompanyID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string EIN { get; set; }
        public string ipAddress { get; set; }
        public string CheckingOut { get; set; }
        public string BIK { get; set; }
        public string UA { get; set; }
    
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Insurance> Insurances { get; set; }
    }
}
