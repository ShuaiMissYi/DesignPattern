using System;
using System.Collections.Generic;
using System.Text;

namespace StateMode
{
    public class Work
    {

        private float m_Hour;

        private WorkStateBase WorkState;

        public float Hour
        {
            get { return m_Hour; }
            set { m_Hour = value; }
        }

        public Work()
        {
            WorkState = new ForenoonState();
        }

        //设置当前状态
        public void SetState(WorkStateBase workState)
        {
            WorkState = workState;
        }


        //打印当前状态
        public void WriteState()
        {
            WorkState.WriteProgram(this);
        }




    }
}
