
namespace FrostPunkCopy.Core
{
    /// <summary>
    /// 프로그램에서 엔진 시작과 관련된 것을 제외한
    /// 모든 상호작용은 이벤트를 통해 관리함
    /// </summary>
    class Event
    {
        private static Event instance;
        private Event() { }

        ~Event() { }

        public Event GetInstance()
        {
            if (instance == null)
            {
                instance = new Event();
            }
            return instance;
        }

        
    }
}
