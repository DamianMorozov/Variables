using System.Collections.ObjectModel;

namespace Variables
{
    public class ClassObjectA
    {
        public Collection<string> Log { get; set; } = new Collection<string>();

        public ClassObjectA()
        {
            Log.Add(@"ClassObjectA - Constructor()");
        }

        public void Make()
        {
            Log.Add(@"ClassObjectA - Make()");
        }
    }

    public class ClassObjectB
    {
        public Collection<string> Log { get; set; } = new Collection<string>();

        public ClassObjectB()
        {
            Log.Add(@"ClassObjectB - Constructor()");
        }
    }

    public class ClassObjectA1 : ClassObjectA
    {
        public Collection<string> LogA1 { get; set; } = new Collection<string>();

        public ClassObjectA1()
        {
            LogA1 = Log;
            Log.Add(@"ClassObjectA1 - Constructor()");
        }

        public void Make()
        {
            Log.Add(@"ClassObjectA1 - Make()");
        }
    }
}
