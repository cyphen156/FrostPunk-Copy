using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrostPunkCopy.Core
{
    /// <summary>
    /// 사용자 입력처리를 담당하는 클래스
    /// 입력을 이벤트로 발생시킨다.
    /// </summary>
    class Input
    {
        private static Input instance;
        private Input() { }

        ~Input() { }

        public Input GetInstance()
        {
            if (instance == null)
            {
                instance = new Input();
            }
            return instance;
        }
    }
}
