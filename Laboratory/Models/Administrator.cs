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
    
    public partial class Administrator
    {
        public int AdministratorID { get; set; }
        public Nullable<int> AccountID { get; set; }
    
        public virtual AccountData AccountData { get; set; }
    }
}