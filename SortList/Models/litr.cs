//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SortList.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class litr
    {
        public string discipline { get; set; }
        public string name { get; set; }
        public int date { get; set; }
        public string type { get; set; }
    
        public virtual disc disc { get; set; }
    }
}
