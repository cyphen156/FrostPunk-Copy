using SDL2;
using static SDL2.SDL;

namespace FrostPunkCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SDL 라이브러리 초기화
            if (SDL.SDL_Init(SDL.SDL_INIT_EVERYTHING) < 0)
            {
                Console.WriteLine("Fail Init.");
                goto Exit;
            }

            // 메인 윈도우 생성
            IntPtr myWindow = SDL.SDL_CreateWindow(
                "FrostPunkCopy",
                0, 0,
                640, 480,
                SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);

            // 윈도우 이벤트 처리용 SDL 이벤트 구조체 선언
            SDL.SDL_Event myEvent;

            // 메인 렌더러 설정
            IntPtr renderer = SDL.SDL_CreateRenderer(
                myWindow
                , -1
                , SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED
                | SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC
                | SDL.SDL_RendererFlags.SDL_RENDERER_TARGETTEXTURE);
            while (true)
            {
                SDL.SDL_PollEvent(out myEvent);
                if (myEvent.type == SDL.SDL_EventType.SDL_QUIT)
                {
                    break;
                }
                SDL.SDL_SetRenderDrawColor(renderer, 0, 0, 255, 0);       // 펜 색상 세팅
                SDL.SDL_RenderClear(renderer);                          // 화면 초기화
                SDL.SDL_RenderPresent(renderer);                        // 버퍼를 화면에 출력 (프레임을 렌더링)
            }

            // 메모리 해제
            SDL.SDL_DestroyWindow(myWindow);
        Exit:
            SDL.SDL_Quit();
        }
    }
}
