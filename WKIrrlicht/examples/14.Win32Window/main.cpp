/** Example 014 Win32 Window

This example only runs under MS Windows and demonstrates that Irrlicht can
render inside a win32 window. MFC and .NET Windows.Forms windows are possible,
too.

In the beginning, we create a windows window using the windows API. I'm not
going to explain this code, because it is windows specific. See the MSDN or a
windows book for details.
*/

#include <irrlicht.h>
#ifndef _IRR_WINDOWS_
#error Windows only example
#else
#include <windows.h> // this example only runs with windows
#include <iostream>
#include "driverChoice.h"
#include "exampleHelper.h"

using namespace irr;

#ifdef _MSC_VER
#pragma comment(lib, "irrlicht.lib")
#endif

HWND hOKButton;
HWND hWnd;

static LRESULT CALLBACK CustomWndProc(HWND hWnd, UINT message,
		WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
	case WM_COMMAND:
		{
			HWND hwndCtl = (HWND)lParam;
			int code = HIWORD(wParam);

			if (hwndCtl == hOKButton)
			{
				DestroyWindow(hWnd);
				PostQuitMessage(0);
				return 0;
			}
		}
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		return 0;

	}

	return DefWindowProc(hWnd, message, wParam, lParam);
}


/*
   Now ask for the driver and create the Windows specific window.
*/
int main()
{
	// ask user for driver
	video::E_DRIVER_TYPE driverType=driverChoiceConsole();
	if (driverType==video::EDT_COUNT)
		return 1;

	printf("Select the render window (some dead window may exist too):\n"\
		" (a) Window with button (via CreationParam)\n"\
		" (b) Window with button (via beginScene)\n"\
		" (c) Own Irrlicht window (default behavior)\n"\
		" (otherKey) exit\n\n");

	char key;
	std::cin >> key;
	if (key != 'a' && key != 'b' && key != 'c')
		return 1;

	HINSTANCE hInstance = 0;
	// create dialog

	const fschar_t* Win32ClassName = __TEXT("CIrrlichtWindowsTestDialog");

	WNDCLASSEX wcex;
	wcex.cbSize			= sizeof(WNDCLASSEX);
	wcex.style			= CS_HREDRAW | CS_VREDRAW;
	wcex.lpfnWndProc	= (WNDPROC)CustomWndProc;
	wcex.cbClsExtra		= 0;
	wcex.cbWndExtra		= DLGWINDOWEXTRA;
	wcex.hInstance		= hInstance;
	wcex.hIcon			= NULL;
	wcex.hCursor		= LoadCursor(NULL, IDC_ARROW);
	wcex.hbrBackground	= (HBRUSH)(COLOR_WINDOW);
	wcex.lpszMenuName	= 0;
	wcex.lpszClassName	= Win32ClassName;
	wcex.hIconSm		= 0;

	RegisterClassEx(&wcex);

	DWORD style = WS_SYSMENU | WS_BORDER | WS_CAPTION |
		WS_CLIPCHILDREN | WS_CLIPSIBLINGS | WS_MAXIMIZEBOX | WS_MINIMIZEBOX | WS_SIZEBOX;

	int windowWidth = 440;
	int windowHeight = 380;

	hWnd = CreateWindow( Win32ClassName, __TEXT("Irrlicht Win32 window example"),
		style, 100, 100, windowWidth, windowHeight,
		NULL, NULL, hInstance, NULL);

	RECT clientRect;
	GetClientRect(hWnd, &clientRect);
	windowWidth = clientRect.right;
	windowHeight = clientRect.bottom;

	// create ok button

	hOKButton = CreateWindow(__TEXT("BUTTON"), __TEXT("OK - Close"), WS_CHILD | WS_VISIBLE | BS_TEXT,
		windowWidth - 160, windowHeight - 40, 150, 30, hWnd, NULL, hInstance, NULL);

	// create some text

	CreateWindow(__TEXT("STATIC"), __TEXT("This is Irrlicht running inside a standard Win32 window.\n")\
		__TEXT("Also mixing with MFC and .NET Windows.Forms is possible."),
		WS_CHILD | WS_VISIBLE, 20, 20, 400, 40, hWnd, NULL, hInstance, NULL);

	// create window to put irrlicht in

	HWND hIrrlichtWindow = CreateWindow(__TEXT("BUTTON"), __TEXT(""),
			WS_CHILD | WS_VISIBLE | BS_OWNERDRAW,
			50, 80, 320, 220, hWnd, NULL, hInstance, NULL);
	video::SExposedVideoData videodata((key=='b')?hIrrlichtWindow:0);

	/*
	So now that we have some window, we can create an Irrlicht device
	inside of it. We use Irrlicht createEx() function for this. We only
	need the handle (HWND) to that window, set it as windowsID parameter
	and start up the engine as usual. That's it.
	*/
	// create irrlicht device in the button window

	irr::SIrrlichtCreationParameters param;
	param.DriverType = driverType;
	if (key=='a')
		param.WindowId = reinterpret_cast<void*>(hIrrlichtWindow);

	irr::IrrlichtDevice* device = irr::createDeviceEx(param);

	// setup a simple 3d scene

	irr::scene::ISceneManager* smgr = device->getSceneManager();
	video::IVideoDriver* driver = device->getVideoDriver();

	if (driverType==video::EDT_OPENGL)
	{
		HDC HDc=GetDC(hIrrlichtWindow);
		PIXELFORMATDESCRIPTOR pfd={0};
		pfd.nSize=sizeof(PIXELFORMATDESCRIPTOR);
		int pf = GetPixelFormat(HDc);
		DescribePixelFormat(HDc, pf, sizeof(PIXELFORMATDESCRIPTOR), &pfd);
		pfd.dwFlags |= PFD_DOUBLEBUFFER | PFD_SUPPORT_OPENGL | PFD_DRAW_TO_WINDOW;
		pfd.cDepthBits=16;
		pf = ChoosePixelFormat(HDc, &pfd);
		SetPixelFormat(HDc, pf, &pfd);
		videodata.OpenGLWin32.HDc = HDc;
		videodata.OpenGLWin32.HRc=wglCreateContext(HDc);
		wglShareLists((HGLRC)driver->getExposedVideoData().OpenGLWin32.HRc, (HGLRC)videodata.OpenGLWin32.HRc);
	}
	scene::ICameraSceneNode* cam = smgr->addCameraSceneNode();
	cam->setTarget(core::vector3df(0,0,0));

	scene::ISceneNodeAnimator* anim =
		smgr->createFlyCircleAnimator(core::vector3df(0,15,0), 30.0f);
	cam->addAnimator(anim);
	anim->drop();

	scene::ISceneNode* cube = smgr->addCubeSceneNode(20);

	const io::path mediaPath = getExampleMediaPath();

	cube->setMaterialTexture(0, driver->getTexture(mediaPath + "wall.bmp"));
	cube->setMaterialTexture(1, driver->getTexture(mediaPath + "water.jpg"));
	cube->setMaterialFlag( video::EMF_LIGHTING, false );
	cube->setMaterialType( video::EMT_REFLECTION_2_LAYER );

	smgr->addSkyBoxSceneNode(
	driver->getTexture(mediaPath + "irrlicht2_up.jpg"),
	driver->getTexture(mediaPath + "irrlicht2_dn.jpg"),
	driver->getTexture(mediaPath + "irrlicht2_lf.jpg"),
	driver->getTexture(mediaPath + "irrlicht2_rt.jpg"),
	driver->getTexture(mediaPath + "irrlicht2_ft.jpg"),
	driver->getTexture(mediaPath + "irrlicht2_bk.jpg"));

	// This shows that we can render to multiple windows within one application
	device->getGUIEnvironment()->addStaticText(core::stringw("Second screen render").c_str(),core::recti(0,0,200,200));

	// show and execute dialog

	ShowWindow(hWnd , SW_SHOW);
	UpdateWindow(hWnd);

	// do message queue

	/*
	Now the only thing missing is the drawing loop using
	IrrlichtDevice::run(). We do this as usual. But instead of this, there
	is another possibility: You can also simply use your own message loop
	using GetMessage, DispatchMessage and whatever. Calling
	Device->run() will cause Irrlicht to dispatch messages internally too.
	You need not call Device->run() if you want to do your own message
	dispatching loop, but Irrlicht will not be able to fetch user input
	then and you have to do it on your own using the window messages,
	DirectInput, or whatever.
	*/

	while (device->run())
	{
		driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, video::SColor(0), 1.f, 0, videodata);
		smgr->drawAll();
		driver->endScene();
		if (key=='b')
		{
			driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, video::SColor(0xbbbbbbbb));
			device->getGUIEnvironment()->drawAll();
			driver->endScene();
		}
	}

	/*
	The alternative, own message dispatching loop without Device->run()
	would look like this:
	*/

	/*MSG msg;
	while (true)
	{
		if (PeekMessage(&msg, NULL, 0, 0, PM_REMOVE))
		{
			TranslateMessage(&msg);
			DispatchMessage(&msg);

			if (msg.message == WM_QUIT)
				break;
		}

		// advance virtual time
		device->getTimer()->tick();

		// draw engine picture
		driver->beginScene(true, true, 0, (key=='c')?hIrrlichtWindow:0);
		smgr->drawAll();
		driver->endScene();
	}*/

	device->closeDevice();
	device->drop();

	return 0;
}
#endif // if windows

/*
That's it, Irrlicht now runs in your own windows window.
**/
