using System;
using System.Collections.Generic;
using System.Text;

namespace StateMode
{
    //中午
    public class NoonState : WorkStateBase
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour<13)
            {
                Console.WriteLine($"当前时间{work.Hour}点,吃饭、午休");
            }
            else
            {
                work.SetState(new AfterNoonState());
                work.WriteState();
            }
        }
    }
}
