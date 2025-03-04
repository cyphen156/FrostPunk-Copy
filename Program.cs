using FrostPunkCopy.Core;

namespace FrostPunkCopy
{
    /// <summary>
    /// 프로그램
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = Engine.GetInstance();
            engine.Init();
            while (engine.GetEngineStatus() != Types.Status.Stop)
            //  엔진 상태가 중지 상태가 아니면 항상 진행
            {
                engine.Run();
            }
        }
    }
}
