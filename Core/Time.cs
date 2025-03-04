

namespace FrostPunkCopy.Core
{
    /// <summary>
    /// 프레임 및 시간 동기화 관리
    /// </summary>
    class Time
    {
        private static Time instance;
        private Time() { }

        ~Time() { }

        public Time GetInstance()
        {
            if (instance == null)
            {
                instance = new Time();
            }
            return instance;
        }
    }
}
