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
    
    public partial class StorageSet
    {
        public int id { get; set; }
        public int idNameMaterial { get; set; }
        public string Location { get; set; }
    
        public virtual MaterialsSet MaterialsSet { get; set; }
    }
}
