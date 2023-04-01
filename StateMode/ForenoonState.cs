using System;
using System.Collections.Generic;
using System.Text;

namespace StateMode
{
    //早上状态
    public class ForenoonState : WorkStateBase
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour<12)
            {
                Console.WriteLine($"当前时间{work.Hour}点,精神百倍");
            }
            else
            {
                work.SetState(new NoonState());
                work.WriteState();
            }
        }
    }
}
