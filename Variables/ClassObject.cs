using System.Collections.ObjectModel;

namespace Variables
{
    public class ClassObjectA
    {
        public Collection<string> Log { get; set; } = new Collection<string>();

        public ClassObjectA()
        {
            Log.Add(@"ClassObjectA - Constructor()");
            Make();
        }

        public void Make()
        {
            Log.Add(@"ClassObjectA - Make()");
        }
    }

    public class ClassObjectA1 : ClassObjectA
    {
        public ClassObjectA1()
        {
            Log.Add(@"- ClassObjectA1 - Constructor()");
            Make();
        }

        public void Make()
        {
            Log.Add(@"- ClassObjectA1 - Make()");
        }
    }

    public class ClassObjectB
    {
        public Collection<string> Log { get; set; } = new Collection<string>();

        public ClassObjectB()
        {
            Log.Add(@"ClassObjectB - Constructor()");
            Make();
        }

        public virtual void Make()
        {
            Log.Add(@"ClassObjectB - virtual Make()");
        }
    }

    public class ClassObjectB1 : ClassObjectB
    {
        public ClassObjectB1()
        {
            Log.Add(@"- ClassObjectB1 - Constructor()");
            Make();
        }
    }

    public class ClassObjectB2 : ClassObjectB
    {
        public ClassObjectB2()
        {
            Log.Add(@"- ClassObjectB1 - Constructor()");
            Make();
        }

        public override void Make()
        {
            Log.Add(@"- ClassObjectB1 - override Make()");
        }
    }

}
