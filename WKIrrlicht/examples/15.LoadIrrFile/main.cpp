/** Example 015 Loading Scenes from .irr Files

Since version 1.1, Irrlicht is able to save and load
the full scene graph into an .irr file, an xml based
format. There is an editor available to edit
those files, named irrEdit (http://www.ambiera.com/irredit)
which can also be used as world and particle editor.
This tutorial shows how to use .irr files.

Lets start: Create an Irrlicht device and setup the window.
*/

#include <irrlicht.h>
#include "driverChoice.h"
#include "exampleHelper.h"

using namespace irr;

#ifdef _MSC_VER
#pragma comment(lib, "Irrlicht.lib")
#endif

int main(int argc, char** argv)
{
	// ask user for driver
	video::E_DRIVER_TYPE driverType=driverChoiceConsole();
	if (driverType==video::EDT_COUNT)
		return 1;

	// create device and exit if creation failed

	IrrlichtDevice* device =
		createDevice(driverType, core::dimension2d<u32>(640, 480));

	if (device == 0)
		return 1; // could not create selected driver.

	device->setWindowCaption(L"Load .irr file example");

	video::IVideoDriver* driver = device->getVideoDriver();
	scene::ISceneManager* smgr = device->getSceneManager();

	/*
	Now load our .irr file.
	.irr files can store the whole scene graph including animators,
	materials and particle systems. And there is also the possibility to
	store arbitrary user data for every scene node in that file. To keep
	this example simple, we are simply loading the scene here. See the
	documentation at ISceneManager::loadScene and ISceneManager::saveScene
	for more information. So to load and display a complicated huge scene,
	we only need a single call to loadScene().
	*/

	// load the scene
	/* You might have to work around some minor problems in current .irr loader:
	- It can't load meshes relative to the .irr file, but only relative to the working directory. 
	  So you might have to change your working directory to the path where the .irr file is in.
	- When passing a custom parent node to loadScene then irr_scene attributes will be passed to that.
	  Usually not a problem, but for example AmbientLight will not change that way unless you create a custom 
	  SceneNode type which can interpret those attributes.
	*/
	if (argc>1)
		smgr->loadScene(argv[1]);
	else
		smgr->loadScene(getExampleMediaPath() + "example.irr");

	/*
	Now we'll create a camera, and give it a collision response animator
	that's built from the mesh nodes in the scene we just loaded.
	*/
	scene::ICameraSceneNode * camera = smgr->addCameraSceneNodeFPS(0, 50.f, 0.1f);

	// Create a meta triangle selector to hold several triangle selectors.
	scene::IMetaTriangleSelector * meta = smgr->createMetaTriangleSelector();

	/*
	Now we will find all the nodes in the scene and create triangle
	selectors for all suitable nodes.  Typically, you would want to make a
	more informed decision about which nodes to performs collision checks
	on; you could capture that information in the node name or Id.
	*/
	core::array<scene::ISceneNode *> nodes;
	smgr->getSceneNodesFromType(scene::ESNT_ANY, nodes); // Find all nodes

	for (u32 i=0; i < nodes.size(); ++i)
	{
		scene::ISceneNode * node = nodes[i];
		scene::ITriangleSelector * selector = 0;

		switch(node->getType())
		{
		case scene::ESNT_CUBE:
		case scene::ESNT_ANIMATED_MESH:
			// Because the selector won't animate with the mesh,
			// and is only being used for camera collision, we'll just use an approximate
			// bounding box instead of ((scene::IAnimatedMeshSceneNode*)node)->getMesh(0)
			selector = smgr->createTriangleSelectorFromBoundingBox(node);
		break;

		case scene::ESNT_MESH:
		case scene::ESNT_SPHERE: // Derived from IMeshSceneNode
			selector = smgr->createTriangleSelector(((scene::IMeshSceneNode*)node)->getMesh(), node);
			break;

		case scene::ESNT_TERRAIN:
			selector = smgr->createTerrainTriangleSelector((scene::ITerrainSceneNode*)node);
			break;

		case scene::ESNT_OCTREE:
			selector = smgr->createOctreeTriangleSelector(((scene::IMeshSceneNode*)node)->getMesh(), node);
			break;

		default:
			// Don't create a selector for this node type
			break;
		}

		if(selector)
		{
			// Add it to the meta selector, which will take a reference to it
			meta->addTriangleSelector(selector);
			// And drop my reference to it, so that the meta selector owns it.
			selector->drop();
		}
	}

	/*
	Now that the mesh scene nodes have had triangle selectors created and added
	to the meta selector, create a collision response animator from that meta selector.
	*/
	scene::ISceneNodeAnimator* anim = smgr->createCollisionResponseAnimator(
		meta, camera, core::vector3df(5,5,5),
		core::vector3df(0,0,0));
	meta->drop(); // I'm done with the meta selector now

	camera->addAnimator(anim);
	anim->drop(); // I'm done with the animator now

	// And set the camera position so that it doesn't start off stuck in the geometry
	camera->setPosition(core::vector3df(0.f, 20.f, 0.f));

	// Point the camera at the cube node, by finding the first node of type ESNT_CUBE
	scene::ISceneNode * cube = smgr->getSceneNodeFromType(scene::ESNT_CUBE);
	if(cube)
		camera->setTarget(cube->getAbsolutePosition());

	/*
	That's it. Draw everything and finish as usual.
	*/

	int lastFPS = -1;

	while(device->run())
	if (device->isWindowActive())
	{
		driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, video::SColor(0,200,200,200));
		smgr->drawAll();
		driver->endScene();

		int fps = driver->getFPS();

		if (lastFPS != fps)
		{
			core::stringw str = L"Load Irrlicht File example - Irrlicht Engine [";
			str += driver->getName();
			str += "] FPS:";
			str += fps;

			device->setWindowCaption(str.c_str());
			lastFPS = fps;
		}

	}

	device->drop();

	return 0;
}

/*
**/
