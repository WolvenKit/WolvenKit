#include "stdafx.h"
#include "CursorControl.h"
#include "Event.h"
#include "FileSystem.h"
#include "GUIEnvironment.h"
#include "IrrlichtCreationParameters.h"
#include "IrrlichtDevice.h"
#include "JoystickInfo.h"
#include "Logger.h"
#include "OSOperator.h"
#include "Randomizer.h"
#include "ReferenceCounted.h"
#include "SceneManager.h"
#include "Timer.h"
#include "VideoDriver.h"
#include "VideoModeList.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {

IrrlichtDevice^ IrrlichtDevice::Wrap(irr::IrrlichtDevice* ref)
{
	if (ref == nullptr)
		return nullptr;

	IrrlichtDevice^ device = gcnew IrrlichtDevice(ref);
	
	if (device == nullptr)
		return nullptr;

	core::stringw s = L"Irrlicht Lime version ";
	s += Lime::StringToStringW(Lime::Version);
	device->m_IrrlichtDevice->getLogger()->log(s.c_str());

	device->m_EventReceiverInheritor = new EventReceiverInheritor();
	device->m_EventReceiverInheritor->m_EventHandler = gcnew EventHandler(device, &IrrlichtDevice::Event);
	device->m_IrrlichtDevice->setEventReceiver(device->m_EventReceiverInheritor);

	return device;
}

IrrlichtDevice::IrrlichtDevice(irr::IrrlichtDevice* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_IrrlichtDevice = ref;
}

IrrlichtDevice::~IrrlichtDevice()
{
	this->!IrrlichtDevice();
}

IrrlichtDevice::!IrrlichtDevice()
{
	if (m_EventReceiverInheritor != nullptr)
	{
		delete m_EventReceiverInheritor;
		m_EventReceiverInheritor = nullptr;
	}
}

IrrlichtDevice^ IrrlichtDevice::CreateDevice(IrrlichtCreationParameters^ parameters)
{
	LIME_ASSERT(parameters != nullptr);

	irr::IrrlichtDevice* d = createDeviceEx(*parameters->m_NativeValue);
	return Wrap(d);
}

IrrlichtDevice^ IrrlichtDevice::CreateDevice(Video::DriverType driverType, Dimension2Di^ windowSize, int bits, bool fullscreen,
	bool stencilbuffer, bool vsync)
{
	LIME_ASSERT(windowSize != nullptr);
	LIME_ASSERT(windowSize->Width > 0);
	LIME_ASSERT(windowSize->Height > 0);
	LIME_ASSERT(bits > 0);

	irr::IrrlichtDevice* d = createDevice(
		(video::E_DRIVER_TYPE)driverType,
		(core::dimension2du&)*windowSize->m_NativeValue,
		bits, fullscreen, stencilbuffer, vsync);

	return Wrap(d);
}

IrrlichtDevice^ IrrlichtDevice::CreateDevice(Video::DriverType driverType, Dimension2Di^ windowSize, int bits, bool fullscreen,
	bool stencilbuffer)
{
	LIME_ASSERT(windowSize != nullptr);
	LIME_ASSERT(windowSize->Width > 0);
	LIME_ASSERT(windowSize->Height > 0);
	LIME_ASSERT(bits > 0);

	irr::IrrlichtDevice* d = createDevice(
		(video::E_DRIVER_TYPE)driverType,
		(core::dimension2du&)*windowSize->m_NativeValue,
		bits, fullscreen, stencilbuffer);

	return Wrap(d);
}

IrrlichtDevice^ IrrlichtDevice::CreateDevice(Video::DriverType driverType, Dimension2Di^ windowSize, int bits, bool fullscreen)
{
	LIME_ASSERT(windowSize != nullptr);
	LIME_ASSERT(windowSize->Width > 0);
	LIME_ASSERT(windowSize->Height > 0);
	LIME_ASSERT(bits > 0);

	irr::IrrlichtDevice* d = createDevice(
		(video::E_DRIVER_TYPE)driverType,
		(core::dimension2du&)*windowSize->m_NativeValue,
		bits, fullscreen);

	return Wrap(d);
}

IrrlichtDevice^ IrrlichtDevice::CreateDevice(Video::DriverType driverType, Dimension2Di^ windowSize, int bits)
{
	LIME_ASSERT(windowSize != nullptr);
	LIME_ASSERT(windowSize->Width > 0);
	LIME_ASSERT(windowSize->Height > 0);
	LIME_ASSERT(bits > 0);

	irr::IrrlichtDevice* d = createDevice(
		(video::E_DRIVER_TYPE)driverType,
		(core::dimension2du&)*windowSize->m_NativeValue,
		bits);

	return Wrap(d);
}

IrrlichtDevice^ IrrlichtDevice::CreateDevice(Video::DriverType driverType, Dimension2Di^ windowSize)
{
	LIME_ASSERT(windowSize != nullptr);
	LIME_ASSERT(windowSize->Width > 0);
	LIME_ASSERT(windowSize->Height > 0);

	irr::IrrlichtDevice* d = createDevice(
		(video::E_DRIVER_TYPE)driverType,
		(core::dimension2du&)*windowSize->m_NativeValue);

	return Wrap(d);
}

IrrlichtDevice^ IrrlichtDevice::CreateDevice(Video::DriverType driverType)
{
	irr::IrrlichtDevice* d = createDevice(
		(video::E_DRIVER_TYPE)driverType);

	return Wrap(d);
}

IrrlichtDevice^ IrrlichtDevice::CreateDevice()
{
	irr::IrrlichtDevice* d = createDevice();
	return Wrap(d);
}

bool IrrlichtDevice::IsDriverSupported(Video::DriverType driver)
{
	return irr::IrrlichtDevice::isDriverSupported((video::E_DRIVER_TYPE)driver);
}

List<JoystickInfo^>^ IrrlichtDevice::ActivateJoysticks()
{
	core::array<SJoystickInfo> ji;
	if (m_IrrlichtDevice->activateJoysticks(ji))
	{
		List<JoystickInfo^>^ l = gcnew List<JoystickInfo^>();

		for(int i = 0; i < (int)ji.size(); i++)
			l->Add(gcnew JoystickInfo(ji[i]));

		return l;
	}

	return nullptr;
}

IrrlichtLime::Randomizer^ IrrlichtDevice::CreateRandomizer()
{
	irr::IRandomizer* r = m_IrrlichtDevice->createDefaultRandomizer();
	return IrrlichtLime::Randomizer::Wrap(r);
}

void IrrlichtDevice::ClearSystemMessages()
{
	m_IrrlichtDevice->clearSystemMessages();
}

void IrrlichtDevice::Close()
{
	m_IrrlichtDevice->closeDevice();
}

bool IrrlichtDevice::GetGammaRamp([Out] float% red, [Out] float% green, [Out] float% blue, [Out] float% relativebrightness, [Out] float% relativecontrast)
{
	float r, g, b, rb, rv;
	bool o = m_IrrlichtDevice->getGammaRamp(r, g, b, rb, rv);

	red = r;
	green = g;
	blue = b;
	relativebrightness = rb;
	relativecontrast = rv;

	return o;
}

void IrrlichtDevice::MaximizeWindow()
{
	m_IrrlichtDevice->maximizeWindow();
}

void IrrlichtDevice::MinimizeWindow()
{
	m_IrrlichtDevice->minimizeWindow();
}

bool IrrlichtDevice::PostEvent(IrrlichtLime::Event^ e)
{
	LIME_ASSERT(e != nullptr);
	return m_IrrlichtDevice->postEventFromUser(*e->m_NativeValue);
}

void IrrlichtDevice::RestoreWindow()
{
	m_IrrlichtDevice->restoreWindow();
}

bool IrrlichtDevice::Run()
{
	return m_IrrlichtDevice->run();
}

bool IrrlichtDevice::SetGammaRamp(float red, float green, float blue, float relativebrightness, float relativecontrast)
{
	return m_IrrlichtDevice->setGammaRamp(red, green, blue, relativebrightness, relativecontrast);
}

void IrrlichtDevice::SetInputReceivingSceneManager(Scene::SceneManager^ sceneManager)
{
	m_IrrlichtDevice->setInputReceivingSceneManager(LIME_SAFEREF(sceneManager, m_SceneManager));
}

void IrrlichtDevice::SetWindowCaption(String^ text)
{
	m_IrrlichtDevice->setWindowCaption(LIME_SAFESTRINGTOSTRINGW_C_STR(text));
}

void IrrlichtDevice::SetWindowResizable(bool resize)
{
	m_IrrlichtDevice->setResizable(resize);
}

void IrrlichtDevice::Sleep(int timeMs, bool pauseTimer)
{
	LIME_ASSERT(timeMs >= 0);
	m_IrrlichtDevice->sleep(timeMs, pauseTimer);
}

void IrrlichtDevice::Sleep(int timeMs)
{
	LIME_ASSERT(timeMs >= 0);
	m_IrrlichtDevice->sleep(timeMs);
}

void IrrlichtDevice::Yield()
{
	m_IrrlichtDevice->yield();
}

Video::ColorFormat IrrlichtDevice::ColorFormat::get()
{
	return (Video::ColorFormat)m_IrrlichtDevice->getColorFormat();
}

GUI::CursorControl^ IrrlichtDevice::CursorControl::get()
{
	gui::ICursorControl* c = m_IrrlichtDevice->getCursorControl();
	return GUI::CursorControl::Wrap(c);
}

IO::FileSystem^ IrrlichtDevice::FileSystem::get()
{
	io::IFileSystem* s = m_IrrlichtDevice->getFileSystem();
	return IO::FileSystem::Wrap(s);
}

bool IrrlichtDevice::Fullscreen::get()
{
	return m_IrrlichtDevice->isFullscreen();
}

GUI::GUIEnvironment^ IrrlichtDevice::GUIEnvironment::get()
{
	gui::IGUIEnvironment* g = m_IrrlichtDevice->getGUIEnvironment();
	return GUI::GUIEnvironment::Wrap(g);
}

IrrlichtLime::Logger^ IrrlichtDevice::Logger::get()
{
	irr::ILogger* l = m_IrrlichtDevice->getLogger();
	return IrrlichtLime::Logger::Wrap(l);
}

IrrlichtLime::OSOperator^ IrrlichtDevice::OSOperator::get()
{
	irr::IOSOperator* o = m_IrrlichtDevice->getOSOperator();
	return IrrlichtLime::OSOperator::Wrap(o);
}

IrrlichtLime::Randomizer^ IrrlichtDevice::Randomizer::get()
{
	irr::IRandomizer* r = m_IrrlichtDevice->getRandomizer();
	return IrrlichtLime::Randomizer::Wrap(r);
}

void IrrlichtDevice::Randomizer::set(IrrlichtLime::Randomizer^ value)
{
	m_IrrlichtDevice->setRandomizer(LIME_SAFEREF(value, m_Randomizer));
}

Scene::SceneManager^ IrrlichtDevice::SceneManager::get()
{
	scene::ISceneManager* m = m_IrrlichtDevice->getSceneManager();
	return Scene::SceneManager::Wrap(m);
}

IrrlichtLime::Timer^ IrrlichtDevice::Timer::get()
{
	irr::ITimer* t = m_IrrlichtDevice->getTimer();
	return IrrlichtLime::Timer::Wrap(t);
}

DeviceType IrrlichtDevice::Type::get()
{
	return (DeviceType)m_IrrlichtDevice->getType();
}

String^ IrrlichtDevice::Version::get()
{
	return gcnew String(m_IrrlichtDevice->getVersion());
}

Video::VideoDriver^ IrrlichtDevice::VideoDriver::get()
{
	video::IVideoDriver* d = m_IrrlichtDevice->getVideoDriver();
	return Video::VideoDriver::Wrap(d);
}

Video::VideoModeList^ IrrlichtDevice::VideoModeList::get()
{
	video::IVideoModeList* l = m_IrrlichtDevice->getVideoModeList();
	return Video::VideoModeList::Wrap(l);
}

bool IrrlichtDevice::WindowActive::get()
{
	return m_IrrlichtDevice->isWindowActive();
}

bool IrrlichtDevice::WindowFocused::get()
{
	return m_IrrlichtDevice->isWindowFocused();
}

bool IrrlichtDevice::WindowMinimized::get()
{
	return m_IrrlichtDevice->isWindowMinimized();
}

Vector2Di^ IrrlichtDevice::WindowPosition::get()
{
	return gcnew Vector2Di(m_IrrlichtDevice->getWindowPosition());
}

String^ IrrlichtDevice::ToString()
{
	return String::Format("Irrlicht {0}{1}", Version,
		m_IrrlichtDevice->getDebugName() == nullptr ? "" : " (DEBUG)");
}

bool IrrlichtDevice::Event(IrrlichtLime::Event^ e)
{
	return OnEvent(e);
}

} // end namespace IrrlichtLime
