//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Krymkovni
{
    using System;
    using System.Collections.Generic;
    
    public partial class Список_вакансий
    {
        public decimal Код_сферы { get; set; }
        public string Должность { get; set; }
        public string Оклад { get; set; }
        public string Требовния_к_соискателю { get; set; }
        public string Работодатель { get; set; }
        public string Контактный_номер { get; set; }
        public decimal Код_вакансии { get; set; }
    
        public virtual Сфера_деятельности Сфера_деятельности { get; set; }
    }
}
