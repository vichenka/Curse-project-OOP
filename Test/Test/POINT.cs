//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test
{
    using System;
    using System.Collections.Generic;
    
    public partial class POINT
    {
        public int ID_ANSWER { get; set; }
        public Nullable<int> ID_Quest { get; set; }
        public string ANSWER { get; set; }
        public Nullable<int> POINT1 { get; set; }
    
        public virtual QUESTION QUESTION { get; set; }
    }
}
