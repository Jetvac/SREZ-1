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
    
    public partial class Accountant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accountant()
        {
            this.OrdersServices = new HashSet<OrdersService>();
        }
    
        public int AccountantID { get; set; }
        public Nullable<int> AccountID { get; set; }
        public Nullable<System.DateTime> LastAuth { get; set; }
    
        public virtual AccountData AccountData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersService> OrdersServices { get; set; }
    }
}
