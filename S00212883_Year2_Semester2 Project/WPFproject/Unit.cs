//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Unit
    {
        public int UnitUD { get; set; }
        public int UnitTypeID { get; set; }
        public int SubFactionID { get; set; }
        public string Name { get; set; }
        public string UnitValue { get; set; }
        public string UnitImage { get; set; }
    
        public virtual SubFaction SubFaction { get; set; }
        public virtual UnitType UnitType { get; set; }
    }
}
