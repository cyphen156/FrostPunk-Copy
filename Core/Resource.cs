
namespace FrostPunkCopy.Core
{
    /// <summary>
    /// 모든 리소스 CRUD 관리
    /// 로딩 관리
    /// </summary>
    class Resource
    {
        private static Resource instance;
        private Resource() { }

        ~Resource() { }

        public Resource GetInstance()
        {
            if (instance == null)
            {
                instance = new Resource();
            }
            return instance;
        }
    }
}
