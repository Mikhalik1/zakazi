//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zakazclass.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zakazi
    {
        public int id_zakaz { get; set; }
        public string seriya { get; set; }
        public int cost { get; set; }
        public Nullable<int> id_servise { get; set; }
    
        public virtual Service Service { get; set; }
    }
}
