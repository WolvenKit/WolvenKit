/** Example 004 Movement

This tutorial shows how to move and animate SceneNodes. The
basic concept of SceneNodeAnimators is shown as well as manual
movement of nodes using the keyboard.  We'll demonstrate framerate
independent movement, which means moving by an amount dependent
on the duration of the last run of the Irrlicht loop.

Example 19.MouseAndJoystick shows how to handle other input than keyboard.

As always, include the header files, use the irr namespace,
and tell the linker to link with the .lib file.
*/
#ifdef _MSC_VER
#pragma comment(lib, "Irrlicht.lib")
#endif

#include <irrlicht.h>
#include "driverChoice.h"
#include "exampleHelper.h"

using namespace irr;

/*
To receive events like mouse and keyboard input, or GUI events like
"button has been clicked", we need an object which is derived from the
irr::IEventReceiver object. There is only one method to override:
irr::IEventReceiver::OnEvent(). This method will be called by the engine once
when an event happens. What we really want to know is whether a key is being
held down, and so we will remember the current state of each key.
*/
class MyEventReceiver : public IEventReceiver
{
public:
	// This is the one method that we have to implement
	virtual bool OnEvent(const SEvent& event)
	{
		// Remember whether each key is down or up
		if (event.EventType == irr::EET_KEY_INPUT_EVENT)
			KeyIsDown[event.KeyInput.Key] = event.KeyInput.PressedDown;

		/*
		Always return false by default. If you return true you tell the engine
		that you handled this event completely and the Irrlicht should not
		process it any further. So for example if you return true for all 
		EET_KEY_INPUT_EVENT events then Irrlicht would not pass on key-events
		to it's GUI system.
		*/
		return false;
	}

	// This is used to check whether a key is being held down
	virtual bool IsKeyDown(EKEY_CODE keyCode) const
	{
		return KeyIsDown[keyCode];
	}
	
	MyEventReceiver()
	{
		for (u32 i=0; i<KEY_KEY_CODES_COUNT; ++i)
			KeyIsDown[i] = false;
	}

private:
	// We use this array to store the current state of each key
	bool KeyIsDown[KEY_KEY_CODES_COUNT];
};


/*
The event receiver for keeping the pressed keys is ready, the actual responses
will be made inside the render loop, right before drawing the scene. So lets
create an irr::IrrlichtDevice and the scene node we want to move. We also
create some additional scene nodes to show different possibilities to move and 
animate scene nodes.
*/
int main()
{
	// ask user for driver
	video::E_DRIVER_TYPE driverType=driverChoiceConsole();
	if (driverType==video::EDT_COUNT)
		return 1;

	/*
	Create the event receiver. Take care that the pointer to it has to 
	stay valid as long as the IrrlichtDevice uses it. Event receivers are not
	reference counted.
	*/
	MyEventReceiver receiver;

	// create device
	IrrlichtDevice* device = createDevice(driverType,
			core::dimension2d<u32>(640, 480), 16, false, false, false, &receiver);

	if (device == 0)
		return 1; // could not create selected driver.

	video::IVideoDriver* driver = device->getVideoDriver();
	scene::ISceneManager* smgr = device->getSceneManager();

	const io::path mediaPath = getExampleMediaPath();

	/*
	Create the node which will be moved with the WSAD keys. We create a
	sphere node, which is a built-in geometry primitive. We place the node
	at (0,0,30) and assign a texture to it to let it look a little bit more
	interesting. Because we have no dynamic lights in this scene we disable
	lighting for each model (otherwise the models would be black).
	*/
	scene::ISceneNode * sphereNode = smgr->addSphereSceneNode();
	if (sphereNode)
	{
		sphereNode->setPosition(core::vector3df(0,0,30));
		sphereNode->setMaterialTexture(0, driver->getTexture(mediaPath + "wall.bmp"));
		sphereNode->setMaterialFlag(video::EMF_LIGHTING, false);
	}

	/*
	Now we create another node, movable using a scene node animator. Scene
	node animators modify scene nodes and can be attached to any scene node
	like mesh scene nodes, billboards, lights and even camera scene nodes.
	Scene node animators are not only able to modify the position of a
	scene node, they can also animate the textures of an object for
	example. We create a cube scene node and attach a 'fly circle' scene
	node animator to it, letting this node fly around our sphere scene node.
	*/
	scene::ISceneNode* cubeNode = smgr->addCubeSceneNode();
	if (cubeNode)
	{
		cubeNode->setMaterialTexture(0, driver->getTexture(mediaPath + "t351sml.jpg"));
		cubeNode->setMaterialFlag(video::EMF_LIGHTING, false);
		scene::ISceneNodeAnimator* anim =
			smgr->createFlyCircleAnimator(core::vector3df(0,0,30), 20.0f);
		if (anim)
		{
			cubeNode->addAnimator(anim);
			anim->drop();
		}
	}

	/*
	The last scene node we add is a b3d model of a walking ninja. Is shows the 
	use of a 'fly straight' animator to move the node between two points.
	*/
	scene::IAnimatedMeshSceneNode* ninjaNode =
		smgr->addAnimatedMeshSceneNode(smgr->getMesh(mediaPath + "ninja.b3d"));

	if (ninjaNode)
	{
		scene::ISceneNodeAnimator* anim =
			smgr->createFlyStraightAnimator(core::vector3df(100,0,60),
			core::vector3df(-100,0,60), 3500, true);
		if (anim)
		{
			ninjaNode->addAnimator(anim);
			anim->drop();
		}

		/*
		To make the model look right we disable lighting, set the
		frames between which the animation should loop, rotate the
		model around 180 degrees, and adjust the animation speed and
		the texture. To set the correct animation (frames and speed), we
		would also be able to just call
		"ninjaNode->setMD2Animation(scene::EMAT_RUN)" for the 'run'
		animation instead of "setFrameLoop" and "setAnimationSpeed",
		But that only works with MD2 animations, while this can be used to
		start other animations. For MD2 it's usually good advice not to use
		hardcoded frame-numbers...
		*/
		ninjaNode->setMaterialFlag(video::EMF_LIGHTING, false);

		ninjaNode->setFrameLoop(0, 13);
		ninjaNode->setAnimationSpeed(15);
//		ninjaNode->setMD2Animation(scene::EMAT_RUN);

		ninjaNode->setScale(core::vector3df(2.f,2.f,2.f));
		ninjaNode->setRotation(core::vector3df(0,-90,0));
//		ninjaNode->setMaterialTexture(0, driver->getTexture(mediaPath + "sydney.bmp"));

	}


	/*
	To be able to look at and move around in this scene, we create a first
	person shooter style camera and make the mouse cursor invisible.
	*/
	smgr->addCameraSceneNodeFPS();
	device->getCursorControl()->setVisible(false);

	/*
	Add a colorful irrlicht logo
	*/
	device->getGUIEnvironment()->addImage(
		driver->getTexture(mediaPath + "irrlichtlogoalpha2.tga"),
		core::position2d<s32>(10,20));

	/*
	Lets draw the scene and also write the current frames per second and the 
	name of the driver to the caption of the window.
	*/
	int lastFPS = -1;

	// In order to do framerate independent movement, we have to know
	// how long it was since the last frame
	u32 then = device->getTimer()->getTime();

	// This is the movement speed in units per second.
	const f32 MOVEMENT_SPEED = 5.f;

	while(device->run())
	{
		// Work out a frame delta time.
		const u32 now = device->getTimer()->getTime();
		const f32 frameDeltaTime = (f32)(now - then) / 1000.f; // Time in seconds
		then = now;

		/* Check if keys W, S, A or D are being held down, and move the
		sphere node around respectively. */
		core::vector3df nodePosition = sphereNode->getPosition();

		if(receiver.IsKeyDown(irr::KEY_KEY_W))
			nodePosition.Y += MOVEMENT_SPEED * frameDeltaTime;
		else if(receiver.IsKeyDown(irr::KEY_KEY_S))
			nodePosition.Y -= MOVEMENT_SPEED * frameDeltaTime;

		if(receiver.IsKeyDown(irr::KEY_KEY_A))
			nodePosition.X -= MOVEMENT_SPEED * frameDeltaTime;
		else if(receiver.IsKeyDown(irr::KEY_KEY_D))
			nodePosition.X += MOVEMENT_SPEED * frameDeltaTime;

		sphereNode->setPosition(nodePosition);

		driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, video::SColor(255,113,113,133));

		smgr->drawAll(); // draw the 3d scene
		device->getGUIEnvironment()->drawAll(); // draw the gui environment (the logo)

		driver->endScene();

		int fps = driver->getFPS();

		if (lastFPS != fps)
		{
			core::stringw tmp(L"Movement Example - Irrlicht Engine [");
			tmp += driver->getName();
			tmp += L"] fps: ";
			tmp += fps;

			device->setWindowCaption(tmp.c_str());
			lastFPS = fps;
		}
	}

	/*
	In the end, delete the Irrlicht device.
	*/
	device->drop();
	
	return 0;
}

/*
That's it. Compile and play around with the program.
**/
