#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {

namespace GUI { ref class CursorControl; ref class GUIEnvironment; }
namespace IO { ref class FileSystem; }
namespace Scene { ref class SceneManager; }
namespace Video { ref class VideoDriver; ref class VideoModeList; }

ref class Event;
class EventReceiverInheritor;
ref class IrrlichtCreationParameters;
ref class JoystickInfo;
ref class Logger;
ref class OSOperator;
ref class Randomizer;
ref class Timer;

/// <summary>
/// The Irrlicht device. You can create it with <c>IrrlichtDevice.CreateDevice()</c>.
/// This is the most important class of the Irrlicht Engine.
/// You can access everything in the engine if you have a pointer to an instance of this class.
/// There should be only one instance of this class at any time.
/// </summary>
public ref class IrrlichtDevice : ReferenceCounted
{
public:

	static IrrlichtDevice^ CreateDevice(IrrlichtCreationParameters^ parameters);

	static IrrlichtDevice^ CreateDevice(Video::DriverType driverType, Dimension2Di^ windowSize, int bits, bool fullscreen, bool stencilbuffer, bool vsync);
	static IrrlichtDevice^ CreateDevice(Video::DriverType driverType, Dimension2Di^ windowSize, int bits, bool fullscreen, bool stencilbuffer);
	static IrrlichtDevice^ CreateDevice(Video::DriverType driverType, Dimension2Di^ windowSize, int bits, bool fullscreen);
	static IrrlichtDevice^ CreateDevice(Video::DriverType driverType, Dimension2Di^ windowSize, int bits);
	static IrrlichtDevice^ CreateDevice(Video::DriverType driverType, Dimension2Di^ windowSize);
	static IrrlichtDevice^ CreateDevice(Video::DriverType driverType);
	static IrrlichtDevice^ CreateDevice();

	static bool IsDriverSupported(Video::DriverType driver);

	~IrrlichtDevice();
	!IrrlichtDevice();

	List<JoystickInfo^>^ ActivateJoysticks();

	IrrlichtLime::Randomizer^ CreateRandomizer();

	void ClearSystemMessages();
	void Close();
	bool GetGammaRamp([Out] float% red, [Out] float% green, [Out] float% blue, [Out] float% relativebrightness, [Out] float% relativecontrast);

	void MaximizeWindow();
	void MinimizeWindow();

	bool PostEvent(IrrlichtLime::Event^ e);

	void RestoreWindow();
	
	/// <summary>
	/// Runs the device.
	/// Also increments the virtual timer by calling <c>Timer.Tick()</c>.
	/// You can prevent this by calling <c>Timer.Stop()</c>; before and <c>Timer.Start()</c> after calling this method.
	/// </summary>
	/// <returns>False if device wants to be deleted.</returns>
	bool Run();

	bool SetGammaRamp(float red, float green, float blue, float relativebrightness, float relativecontrast);
	void SetInputReceivingSceneManager(Scene::SceneManager^ sceneManager);
	void SetWindowCaption(String^ text);
	void SetWindowResizable(bool resize);

	void Sleep(int timeMs, bool pauseTimer);
	void Sleep(int timeMs);

	/// <summary>
	/// Cause the device to temporarily pause execution and let other processes run.
	/// This should bring down processor usage without major performance loss for Irrlicht.
	/// </summary>
	void Yield();

	property Video::ColorFormat ColorFormat { Video::ColorFormat get(); }
	property GUI::CursorControl^ CursorControl { GUI::CursorControl^ get(); }
	property IO::FileSystem^ FileSystem { IO::FileSystem^ get(); }
	property bool Fullscreen { bool get(); }
	property GUI::GUIEnvironment^ GUIEnvironment { GUI::GUIEnvironment^ get(); }
	property IrrlichtLime::Logger^ Logger { IrrlichtLime::Logger^ get(); }
	property IrrlichtLime::OSOperator^ OSOperator { IrrlichtLime::OSOperator^ get(); }
	property IrrlichtLime::Randomizer^ Randomizer { IrrlichtLime::Randomizer^ get(); void set(IrrlichtLime::Randomizer^ value); }
	property Scene::SceneManager^ SceneManager { Scene::SceneManager^ get(); }
	property IrrlichtLime::Timer^ Timer { IrrlichtLime::Timer^ get(); }
	property DeviceType Type { DeviceType get(); }
	property String^ Version { String^ get(); }
	property Video::VideoDriver^ VideoDriver { Video::VideoDriver^ get(); }
	property Video::VideoModeList^ VideoModeList { Video::VideoModeList^ get(); }
	property bool WindowActive { bool get(); }
	property bool WindowFocused { bool get(); }
	property bool WindowMinimized { bool get(); }
	property Vector2Di^ WindowPosition { Vector2Di^ get(); }

	virtual String^ ToString() override;

	delegate bool EventHandler(IrrlichtLime::Event^ evnt);
	event EventHandler^ OnEvent;

internal:

	static IrrlichtDevice^ Wrap(irr::IrrlichtDevice* ref);
	IrrlichtDevice(irr::IrrlichtDevice* ref);

	bool Event(IrrlichtLime::Event^ e);

	irr::IrrlichtDevice* m_IrrlichtDevice;
	EventReceiverInheritor* m_EventReceiverInheritor;
};

} // end namespace IrrlichtLime