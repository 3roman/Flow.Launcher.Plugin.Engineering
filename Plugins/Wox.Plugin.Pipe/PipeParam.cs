using System.Collections.Generic;


namespace Wox.Plugin.Pipe
{
    public class PipeParam
    {
        public int DN { get; set; }
        public double OD { get; set; }
        public List<SCHS> SCHS { get; set; }
    }

    public class SCHS
    {
        public string SCH { get; set; }
        public double Thk { get; set; }
    }
}
