//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alpenstern_BackEnd_Neu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class spt_monitor
    {
        public System.DateTime lastrun { get; set; }
        public int cpu_busy { get; set; }
        public int io_busy { get; set; }
        public int idle { get; set; }
        public int pack_received { get; set; }
        public int pack_sent { get; set; }
        public int connections { get; set; }
        public int pack_errors { get; set; }
        public int total_read { get; set; }
        public int total_write { get; set; }
        public int total_errors { get; set; }
    }
}
