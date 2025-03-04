
namespace FrostPunkCopy.Core
{
    /// <summary>
    /// OS와 상호작용하며 파일을 참조할 경로를 관리
    /// </summary>
    class PathMgr
    {
        private static PathMgr instance;
        private PathMgr() { }

        ~PathMgr() { }

        public PathMgr GetInstance()
        {
            if (instance == null)
            {
                instance = new PathMgr();
            }
            return instance;
        }
    }
}
