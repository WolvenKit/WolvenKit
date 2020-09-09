/** Example 026 OcclusionQuery

This tutorial shows how to speed up rendering by use of the
OcclusionQuery feature. The usual rendering tries to avoid rendering of
scene nodes by culling those nodes which are outside the visible area, the
view frustum. However, this technique does not cope with occluded objects
which are still in the line of sight, but occluded by some larger object
between the object and the eye (camera). Occlusion queries check exactly that.
The queries basically measure the number of pixels that a previous render
left on the screen.
Since those pixels cannot be recognized at the end of a rendering anymore,
the pixel count is measured directly when rendering. Thus, one needs to render
the occluder (the object in front) first. This object needs to write to the
z-buffer in order to become a real occluder. Then the node is rendered and in
case a z-pass happens, i.e. the pixel is written to the framebuffer, the pixel
is counted in the query.
The result of a query is the number of pixels which got through. One can, based
on this number, judge if the scene node is visible enough to be rendered, or if
the node should be removed in the next round. Also note that the number of
pixels is a safe over approximation in general. The pixels might be overdrawn
later on, and the GPU tries to avoid inaccuracies which could lead to false
negatives in the queries.

As you might have recognized already, we had to render the node to get the
numbers. So where's the benefit, you might say. There are several ways where
occlusion queries can help. It is often a good idea to just render the bbox
of the node instead of the actual mesh. This is really fast and is a safe over
approximation. If you need a more exact render with the actual geometry, it's
a good idea to render with just basic solid material. Avoid complex shaders
and state changes through textures. There's no need while just doing the
occlusion query. At least if the render is not used for the actual scene. This
is the third way to optimize occlusion queries. Just check the queries every
5th or 10th frame, or even less frequent. This depends on the movement speed
of the objects and camera.
*/

#ifdef _MSC_VER
// We'll also define this to stop MSVC complaining about sprintf().
#define _CRT_SECURE_NO_WARNINGS
#pragma comment(lib, "Irrlicht.lib")
#endif

#include <irrlicht.h>
#include "driverChoice.h"
#include "exampleHelper.h"

using namespace irr;

/*
We need keyboard input events to switch some parameters
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
We create an irr::IrrlichtDevice and the scene nodes. One occluder, one
occluded. The latter is a complex sphere, which has many triangles.
*/
int main()
{
	// ask user for driver
	video::E_DRIVER_TYPE driverType=driverChoiceConsole();
	if (driverType==video::EDT_COUNT)
		return 1;

	// create device
	MyEventReceiver receiver;

	IrrlichtDevice* device = createDevice(driverType,
			core::dimension2d<u32>(640, 480), 16, false, false, false, &receiver);

	if (device == 0)
		return 1; // could not create selected driver.

	video::IVideoDriver* driver = device->getVideoDriver();
	scene::ISceneManager* smgr = device->getSceneManager();

	const io::path mediaPath = getExampleMediaPath();

	smgr->getGUIEnvironment()->addStaticText(L"Press Space to hide occluder.", core::recti(10,10, 200,50));

	/*
	Create the node to be occluded. We create a sphere node with high poly count.
	*/
	scene::ISceneNode * node = smgr->addSphereSceneNode(10, 64);
	if (node)
	{
		node->setPosition(core::vector3df(0,0,60));
		node->setMaterialTexture(0, driver->getTexture(mediaPath + "wall.bmp"));
		node->setMaterialFlag(video::EMF_LIGHTING, false);
	}

	/*
	Now we create another node, the occluder. It's a simple plane.
	*/
	scene::ISceneNode* plane = smgr->addMeshSceneNode(smgr->addHillPlaneMesh(
		"plane", core::dimension2df(10,10), core::dimension2du(2,2)), 0, -1,
		core::vector3df(0,0,20), core::vector3df(270,0,0));

	if (plane)
	{
		plane->setMaterialTexture(0, driver->getTexture(mediaPath + "t351sml.jpg"));
		plane->setMaterialFlag(video::EMF_LIGHTING, false);
		plane->setMaterialFlag(video::EMF_BACK_FACE_CULLING, true);
	}

	/*
	Here we create the occlusion query. Because we don't have a plain mesh scene node
	(ESNT_MESH or ESNT_ANIMATED_MESH), we pass the base geometry as well. Instead,
	we could also pass a simpler mesh or the bounding box. But we will use a time
	based method, where the occlusion query renders to the frame buffer and in case
	of success (occlusion), the mesh is not drawn for several frames.
	*/
	driver->addOcclusionQuery(node, ((scene::IMeshSceneNode*)node)->getMesh());

	/*
	We have done everything, just a camera and draw it. We also write the
	current frames per second and the name of the driver to the caption of the
	window to examine the render speedup.
	We also store the time for measuring the time since the last occlusion query ran
	and store whether the node should be visible in the next frames.
	*/
	smgr->addCameraSceneNode();
	int lastFPS = -1;
	u32 timeNow = device->getTimer()->getTime();
	bool nodeVisible=true;

	while(device->run())
	{
		plane->setVisible(!receiver.IsKeyDown(irr::KEY_SPACE));

		driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, video::SColor(255,113,113,133));
		/*
		First, we draw the scene, possibly without the occluded element. This is necessary
		because we need the occluder to be drawn first. You can also use several scene
		managers to collect a number of possible occluders in a separately rendered
		scene.
		*/
		node->setVisible(nodeVisible);
		smgr->drawAll();
		smgr->getGUIEnvironment()->drawAll();

		/*
		Once in a while, here every 100 ms, we check the visibility. We run the queries,
		update the pixel value, and query the result. Since we already rendered the node
		we render the query invisible. The update is made blocking, as we need the result
		immediately. If you don't need the result immediately, e.g. because you have other
		things to render, you can call the update non-blocking. This gives the GPU more
		time to pass back the results without flushing the render pipeline.
		If the update was called non-blocking, the result from getOcclusionQueryResult is
		either the previous value, or 0xffffffff if no value has been generated at all, yet.
		The result is taken immediately as visibility flag for the node.
		*/
		if (device->getTimer()->getTime()-timeNow>100)
		{
			driver->runAllOcclusionQueries(false);
			driver->updateAllOcclusionQueries();
			nodeVisible=driver->getOcclusionQueryResult(node)>0;
			timeNow=device->getTimer()->getTime();
		}

		driver->endScene();

		int fps = driver->getFPS();

		if (lastFPS != fps)
		{
			core::stringw tmp(L"OcclusionQuery Example [");
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
