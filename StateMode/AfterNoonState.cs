using System;
using System.Collections.Generic;
using System.Text;

namespace StateMode
{

    //下午
    public class AfterNoonState : WorkStateBase
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 17)
            {
                Console.WriteLine($"当前时间{work.Hour}点，下午状态还行，继续努力！");
            }
            else
            {
                Console.WriteLine("下班");
            }
        }
    }
}
