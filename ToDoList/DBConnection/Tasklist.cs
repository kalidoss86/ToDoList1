//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoList.DBConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tasklist
    {
        public int id { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> ReminderDate { get; set; }
        public string Priority { get; set; }
        public string Category { get; set; }
    }
}