//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vashdom_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaterialsSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaterialsSet()
        {
            this.ComebackSet = new HashSet<ComebackSet>();
            this.OrdersSet = new HashSet<OrdersSet>();
            this.StorageSet = new HashSet<StorageSet>();
        }
    
        public int id { get; set; }
        public string NameMaterial { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<int> Weight { get; set; }
        public string Supplier { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComebackSet> ComebackSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersSet> OrdersSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StorageSet> StorageSet { get; set; }
    }
}
