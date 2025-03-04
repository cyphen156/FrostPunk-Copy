
using FrostPunkCopy.Core;
using SDL2;
using static SDL2.SDL;

namespace FrostPunkCopy.Core
{
    class Renderer
    {
        /// <summary>
        /// 렌더러는 화면에 그리는 주체
        /// 붓의 역할만 담당
        /// </summary>
        private static Renderer instance;
        private Renderer() { }

        ~Renderer() { }

        public Renderer GetInstance()
        {
            if (instance == null)
            {
                instance = new Renderer();
            }
            return instance;
        }

        IntPtr renderer;    //  렌더러

        public bool Init()
        {
            // SDL 라이브러리 초기화 실패시
            if (SDL.SDL_Init(SDL.SDL_INIT_EVERYTHING) < 0)
            {
                Console.WriteLine("Fail Init.");               
                return false;
            }
            return true;
        }

        public bool Quit()
        {
            // 메모리 해제
            SDL.SDL_DestroyRenderer(renderer);
            SDL.SDL_DestroyWindow();
            SDL.SDL_Quit();

            return true;
        }

    }
}
