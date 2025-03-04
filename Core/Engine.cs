
using System.Diagnostics;
using static FrostPunkCopy.Core.Types;

namespace FrostPunkCopy.Core
{
    /// <summary>
    /// 엔진 본체
    /// </summary>
    class Engine
    {
        private static Engine instance;

        private static Status status;
        private static readonly object statusChangeLock = new object();

        private Engine() { }        
        ~Engine() 
        {
            ShutDown();
        }

        public static Engine GetInstance()
        {
            if (instance == null)
            {
                instance = new Engine();
            }
            return instance;
        }

        public Status GetEngineStatus()
        {
            return status;
        }

        public bool SetEngineStatus(Status inStatus)
        {
            // 못부르게 한정해야됨 특수케이스만 부를 수 있도록
            // -> 이벤트 매니저를 통한 예외 처리시에만 호출 할 수 있도록 하는것이 바람직
            var stackTrace = new StackTrace();
            var callingMethod = stackTrace.GetFrame(2)?.GetMethod()?.DeclaringType?.Name;
            if (callingMethod == "Event")
            {
                // 상태 변경이 성공했음
                lock (statusChangeLock)
                {
                    status = inStatus;
                    return true;
                }
            }
            Console.WriteLine("상태변경 허가안됨");
            return false;
        }
        
        public bool Init()
        {
            status = Status.Run;
            return true;
        }
        
        public void Run()
        {
            // 일시 정지 처리
            if (status == Status.Pause)
            {
                
            }
        }

        private static void ShutDown()
        {
            status = Status.Stop;
            instance = null;
        }
    }
}
