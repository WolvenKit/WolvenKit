// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h
// Copyright by Michael Zeilfelder

/** Example 030 Profiling

Profiling is used to get runtime information about code code.

There exist several independent profiling tools.
Examples for free profilers are "gprof" for the GNU toolchain and "very sleepy"
from codersnotes for Windows. Proprietary tools are for example "VTune" from
Intel or "AMD APP Profiler". Those tools work by sampling the running
application regularly to get statistic information about the called functions.
The way to use them is to compile your application with special flags
to include profiling information (some also work with debug information). They
also might allow to profile only certain parts of the code, although
most can't do that. The sampling is usually rather time-consuming which means
the application will be very slow when collecting the profiling data. It's often
useful to start with one of those tools to get an overview over the bottlenecks
in your application. Those tools have the advantage that they don't need any
modifications inside the code.

Once you need to dig deeper the Irrlicht profiler can help you. It works nearly
like a stopwatch. You add start/stop blocks into the parts of your code which
you need to check and the Irrlicht profiler will give you then the exact times
of execution for those parts. And unlike general profiler tools you don't just
get average information about the run-time but also worst-cases. Which tends
to be information you really for a stable framerate. Also the Irrlicht profiler
has a low overhead and affects only the areas which you want to time. So you
can profile applications with nearly original speed.

Irrlicht itself has such profiling information, which is useful to figure out
where the runtime inside the engine is spend. To get that profiling data you
need to recompile Irrlicht with _IRR_COMPILE_WITH_PROFILING_ enabled as
collecting profiling information is disabled by default for speed reasons.
*/

/*
	It's usually a good idea to wrap all your profile code with a define.
	That way you don't have to worry too much about the runtime profiling
	itself takes. You can remove the profiling code completely when you release
	the software by removing a single define.Or sometimes you might want to
	have several such defines for different areas of your application code.
*/
#define ENABLE_MY_PROFILE	// comment out to remove the profiling code
#ifdef ENABLE_MY_PROFILE
	// calls code X
	#define MY_PROFILE(X) X
#else
	// removes the code for X in the pre-processor
	#define MY_PROFILE(X)
#endif // IRR_PROFILE

#include <irrlicht.h>
#include "driverChoice.h"
#include "exampleHelper.h"

#ifdef _MSC_VER
#pragma comment(lib, "Irrlicht.lib")
#endif


using namespace irr;
using namespace core;
using namespace scene;
using namespace video;
using namespace io;
using namespace gui;

/*
	We have the choice between working with fixed and with automatic profiling id's.
	Here are some fixed ID's we will be using.
*/
enum EProfiles
{
	EP_APP_TIME_ONCE,
	EP_APP_TIME_UPDATED,
	EP_SCOPE1,
	EP_SCOPE2,
	EP_DRAW_SCENE
};

// For our example scenes
enum EScenes
{
	ES_NONE,	// no scene set
    ES_CUBE,
    ES_QUAKE_MAP,
    ES_DWARVES,

    ES_COUNT	// counting how many scenes we have
};

/*
    Controlling the profiling display is application specific behavior.
	We use function keys in our case and play around with all the parameters.
	In real applications you will likely only need something to make the
	profiling-display visible/invisible and switch pages while the parameters
	can be set to fixed values.
*/
class MyEventReceiver : public IEventReceiver
{
public:
	// constructor
	MyEventReceiver(ISceneManager * smgr) : GuiProfiler(0), IncludeOverview(true), IgnoreUncalled(false), ActiveScene(ES_NONE), SceneManager(smgr) {}

	virtual bool OnEvent(const SEvent& event)
	{
		if (event.EventType == EET_KEY_INPUT_EVENT)
		{
			if ( event.KeyInput.PressedDown )
			{
				/*
					Catching keys to control the profiling display and the profiler itself
				*/
				switch ( event.KeyInput.Key )
				{
					case KEY_F1:
						GuiProfiler->setVisible( !GuiProfiler->isVisible() );
					break;
					case KEY_F2:
						GuiProfiler->nextPage(IncludeOverview);
					break;
					case KEY_F3:
						GuiProfiler->previousPage(IncludeOverview);
					break;
					case KEY_F4:
						GuiProfiler->firstPage(IncludeOverview);
					break;
					case KEY_F5:
						IncludeOverview = !IncludeOverview;
						GuiProfiler->firstPage(IncludeOverview);	// not strictly needed, but otherwise the update won't update
					break;
					case KEY_F6:
						/*
							You can set more filters. This one filters out profile data which was never called.
						*/
						IgnoreUncalled = !IgnoreUncalled;
						GuiProfiler->setFilters(IgnoreUncalled ? 1 : 0, 0, 0.f, 0);
					break;
					case KEY_F7:
						GuiProfiler->setShowGroupsTogether( !GuiProfiler->getShowGroupsTogether() );
					break;
					case KEY_F8:
						NextScene();
					break;
					case KEY_F9:
					{
						u32 index = 0;
						if ( getProfiler().findGroupIndex(index, L"grp runtime") )
						{
							getProfiler().resetGroup(index);
						}
					}
					break;
					case KEY_F10:
					{
						u32 index = 0;
						if ( getProfiler().findDataIndex(index, L"scope 3") )
						{
							getProfiler().resetDataByIndex(index);
						}
					}
					break;
					case KEY_F11:
						getProfiler().resetAll();
					break;
					case KEY_KEY_F:
						GuiProfiler->setFrozen(!GuiProfiler->getFrozen());
					break;
					default:
					break;
				}
			}
		}

		return false;
	}

	/*
		Some example scenes so we have something to profile
	*/
	void NextScene()
	{
		SceneManager->clear();
		ActiveScene = (ActiveScene+1) % ES_COUNT;
		if ( ActiveScene == 0 )
			ActiveScene = ActiveScene+1;

		switch ( ActiveScene )
		{
			case ES_CUBE:
			{
				/*
					Simple scene with cube and light.
				*/
				MY_PROFILE(CProfileScope p(L"cube", L"grp switch scene");)

				SceneManager->addCameraSceneNode (0, core::vector3df(0, 0, 0),
											core::vector3df(0, 0, 100),
											-1);

				SceneManager->addCubeSceneNode (30.0f, 0, -1,
										core::vector3df(0, 20, 100),
										core::vector3df(45, 45, 45),
										core::vector3df(1.0f, 1.0f, 1.0f));

				SceneManager->addLightSceneNode(0, core::vector3df(0, 0, 0),
										video::SColorf(1.0f, 1.0f, 1.0f),
										100.0f);
			}
			break;
			case ES_QUAKE_MAP:
			{
				/*
					Our typical Irrlicht example quake map.
				*/
				MY_PROFILE(CProfileScope p(L"quake map", L"grp switch scene");)

				scene::IAnimatedMesh* mesh = SceneManager->getMesh("20kdm2.bsp");
				scene::ISceneNode* node = 0;

				if (mesh)
					node = SceneManager->addOctreeSceneNode(mesh->getMesh(0), 0, -1, 1024);
				if (node)
					node->setPosition(core::vector3df(-1300,-144,-1249));
				SceneManager->addCameraSceneNodeFPS();
			}
			break;
			case ES_DWARVES:
			{
				/*
					Stress-test Irrlicht a little bit by creating many objects.
				*/
				MY_PROFILE(CProfileScope p(L"dwarfes", L"grp switch scene");)

				scene::IAnimatedMesh* aniMesh = SceneManager->getMesh( getExampleMediaPath() + "dwarf.x" );
				if (aniMesh)
				{
					scene::IMesh * mesh = aniMesh->getMesh (0);
					if ( !mesh )
						break;

					/*
						You can never have too many dwarves. So let's make some.
					*/
					const int nodesX = 30;
					const int nodesY = 5;
					const int nodesZ = 30;

					aabbox3df bbox = mesh->getBoundingBox();
					vector3df extent = bbox.getExtent();
					const f32 GAP = 10.f;
					f32 halfSizeX = 0.5f * (nodesX*extent.X + GAP*(nodesX-1));
					f32 halfSizeY = 0.5f * (nodesY*extent.Y + GAP*(nodesY-1));
					f32 halfSizeZ = 0.5f * (nodesZ*extent.Z + GAP*(nodesZ-1));

					for ( int x = 0; x < nodesX; ++x )
					{
						irr::f32 gapX = x > 0 ? (x-1)*GAP : 0.f;
						irr::f32 posX = -halfSizeX + x*extent.X + gapX;
						for ( int y = 0; y < nodesY; ++y )
						{
							irr::f32 gapY = y > 0 ? (y-1)*GAP : 0.f;
							irr::f32 posY = -halfSizeY + y*extent.Y + gapY;
							for ( int z=0; z < nodesZ; ++z )
							{
								irr::f32 gapZ = z > 0 ? (z-1)*GAP : 0.f;
								irr::f32 posZ = -halfSizeZ + z*extent.Z + gapZ;
								scene::IAnimatedMeshSceneNode * node = SceneManager->addAnimatedMeshSceneNode(aniMesh, NULL, -1, vector3df(posX, posY, posZ) );
								node->setMaterialFlag(video::EMF_LIGHTING, false);
							}
						}
					}

					irr::scene::ICameraSceneNode * camera = SceneManager->addCameraSceneNodeFPS(0, 20.f, 0.1f );
					camera->updateAbsolutePosition();
					camera->setTarget( vector3df(0,0,0) );
					camera->updateAbsolutePosition();
					camera->setPosition(irr::core::vector3df(halfSizeX+extent.X, halfSizeY+extent.Y, halfSizeZ+extent.Z));
					camera->updateAbsolutePosition();
				}
			}
			break;
		}
	}

	IGUIProfiler * GuiProfiler;
	bool IncludeOverview;
	bool IgnoreUncalled;
	u32 ActiveScene;
	scene::ISceneManager* SceneManager;
};

void recursive(int recursion)
{
	/*
		As the profiler uses internally counters for start stop and only
		takes profile data when that counter is zero we count all recursions
		as a single call.
		If you want to profile each call on it's own you have to use explicit start/stop calls and
		stop the profile id right before the recursive call.
	*/
	MY_PROFILE(CProfileScope p3(L"recursive", L"grp runtime");)
	if (recursion > 0 )
		recursive(recursion-1);
}

int main()
{
	/*
		Setup, nothing special here.
	*/
	video::E_DRIVER_TYPE driverType=driverChoiceConsole();
	if (driverType==video::EDT_COUNT)
		return 1;

	/*
		Profiler is independent of the device - so we can time the device setup
	*/
	MY_PROFILE(s32 pDev = getProfiler().add(L"createDevice", L"grp runtime");)
	MY_PROFILE(getProfiler().start(pDev);)

	IrrlichtDevice * device = createDevice(driverType, core::dimension2d<u32>(640, 480));
	if (device == 0)
	{
		/*
			When working with start/stop you should add a stop to all exit paths.
			Although in this case it wouldn't matter as we don't do anything with it when we quit here.
		*/
		MY_PROFILE(getProfiler().stop(pDev);)
		return 1; // could not create selected driver.
	}
	MY_PROFILE(getProfiler().stop(pDev);)

	video::IVideoDriver* driver = device->getVideoDriver();
	IGUIEnvironment* env = device->getGUIEnvironment();
	scene::ISceneManager* smgr = device->getSceneManager();

	const io::path mediaPath = getExampleMediaPath();

	/*
		A map we use for one of our test-scenes.
	*/
	device->getFileSystem()->addFileArchive(mediaPath + "map-20kdm2.pk3");

	MyEventReceiver receiver(smgr);
	device->setEventReceiver(&receiver);
	receiver.NextScene();

	/*
		Show some info about the controls used in this example
	*/
	IGUIStaticText * staticText = env->addStaticText(
			L"<F1>  to show/hide the profiling display\n"
			L"<F2>  to show the next page\n"
			L"<F3>  to show the previous page\n"
			L"<F4>  to show the first page\n"
			L"<F5>  to flip between including the group overview\n"
			L"<F6>  to flip between ignoring and showing uncalled data\n"
			L"<F7>  to flip between showing 1 group per page or all together\n"
			L"<F8>  to change our scene\n"
			L"<F9>  to reset the \"grp runtime\" data\n"
			L"<F10> to reset the scope 3 data\n"
			L"<F11> to reset all data\n"
			L"<f>   to freeze/unfreeze the display\n"
			, recti(10,10, 250, 140), true, true, 0, -1, true);
	staticText->setWordWrap(false);

	/*
		IGUIProfiler is can be used to show active profiling data at runtime.
	*/
	receiver.GuiProfiler = env->addProfilerDisplay(core::recti(40, 140, 600, 470));
	receiver.GuiProfiler->setDrawBackground(true);

	/*
		Get a monospaced font - it's nicer when working with rows of numbers.
	 */
	IGUIFont* font = env->getFont(mediaPath + "fontcourier.bmp");
	if (font)
		receiver.GuiProfiler->setOverrideFont(font);


	/*
		Adding ID's has to be done before the start/stop calls.
		This allows start/stop to be really fast and we still have nice information like
		names and groups.
		Groups are created automatically each time an ID with a new group-name is added.
		Groups exist to sort the display data in a nicer way.
	*/
	MY_PROFILE(
		getProfiler().add(EP_APP_TIME_ONCE, L"full time", L"grp runtime");
		getProfiler().add(EP_APP_TIME_UPDATED, L"full time updated", L"grp runtime");
		getProfiler().add(EP_SCOPE1, L"scope 1", L"grp runtime");
		getProfiler().add(EP_DRAW_SCENE, L"draw scene", L"grp runtime");
	)

    /*
		Two timers which run the whole time. One will be continuously updated the other won't.
    */
	MY_PROFILE(getProfiler().start(EP_APP_TIME_ONCE);)
	MY_PROFILE(getProfiler().start(EP_APP_TIME_UPDATED);)

	s32 lastFPS = -1;
	while(device->run() && driver)
	{
		if (device->isWindowActive())
		{
			/*
				For comparison show the FPS in the title bar
			*/
			s32 fps = driver->getFPS();
			if (lastFPS != fps)
			{
				core::stringw str = L"FPS: ";
				str += fps;
				device->setWindowCaption(str.c_str());
				lastFPS = fps;
			}

			/*
				Times are only updated on stop() calls. So if we want a long-running timer
				to update we have to stop() and start() it in between.
				Note that this will also update the call-counter and is rarely needed.
			*/
			MY_PROFILE(getProfiler().stop(EP_APP_TIME_UPDATED);)
			MY_PROFILE(getProfiler().start(EP_APP_TIME_UPDATED);)

			/*
				The following CProfileScope's will all do the same thing:
				they measure the time this loop takes. They call start()
				when the object is created and call stop() when it
				is destroyed.

				The first one creates an ID on it's first call and will
				do constant string-comparisons for the name. It's
				the slowest, but most comfortable solution. Use it when you
				just need to run a quick check without the hassle of setting
				up id's.
			*/
			MY_PROFILE(CProfileScope p3(L"scope 3", L"grp runtime");)

			/*
				Second CProfileScope solution will create a data block on first
				call. So it's a little bit slower on the first run. But usually
				that's hardly noticeable.
			*/
			MY_PROFILE(CProfileScope p2(EP_SCOPE2, L"scope 2", L"grp runtime");)

			/*
				Last CProfileScope solution is the fastest one. But you must add
				the id before you can use it like that.
			*/
			MY_PROFILE(CProfileScope p1(EP_SCOPE1));

			/*
				Call a recursive function to show how profiler only counts it once.
			*/
			recursive(5);

			driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, SColor(0,200,200,200));

			/*
				If you want to profile only some lines and not a complete scope
				then you have to work with start() and stop() calls.
			*/
			MY_PROFILE(getProfiler().start(EP_DRAW_SCENE);)
			smgr->drawAll();
			MY_PROFILE(getProfiler().stop(EP_DRAW_SCENE);)

			/*
				If it doesn't matter if the profiler takes some time you can also
				be lazy and create id's automatically on the spot:
			*/
			MY_PROFILE(s32 pEnv = getProfiler().add(L"draw env", L"grp runtime");)
			MY_PROFILE(getProfiler().start(pEnv);)
			env->drawAll();
			MY_PROFILE(getProfiler().stop(pEnv);)

			driver->endScene();
		}
	}

	/*
		Shutdown.
	*/
	device->drop();

	/*
		The profiler is independent of an device - so we can still work with it.
	*/

	MY_PROFILE(getProfiler().stop(EP_APP_TIME_UPDATED));
	MY_PROFILE(getProfiler().stop(EP_APP_TIME_ONCE));

	/*
		Print a complete overview of the profiling data to the console.
	*/
	MY_PROFILE(core::stringw output);
	MY_PROFILE(getProfiler().printAll(output));
	MY_PROFILE(printf("%s", core::stringc(output).c_str() ));

	return 0;
}

/*
**/
