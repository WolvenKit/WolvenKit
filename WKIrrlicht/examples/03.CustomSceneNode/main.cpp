/** Example 003 Custom SceneNode

This tutorial is more advanced than the previous ones.
If you are currently just playing around with the Irrlicht
engine, you may want to look at other examples first.
This tutorials shows how to create a custom scene node and
how to use it in the engine. A custom scene node is needed
if you want to implement a render technique the Irrlicht
Engine currently does not support. For example, you can write
an indoor portal based renderer or an advanced terrain scene
node with it. By creating custom scene nodes, you can
easily extend the Irrlicht Engine and adapt it to your needs.

I will keep the tutorial simple: Keep everything very short 
and  everything in one .cpp file. This is the style which 
will also be used in most of the following tutorials.

To start, I include the header files, use the irr namespace,
and tell the linker to link with the .lib file.
*/
#include <irrlicht.h>
#include "driverChoice.h"

using namespace irr;

#ifdef _MSC_VER
#pragma comment(lib, "Irrlicht.lib")
#endif

/*
Here comes the more sophisticated part of this tutorial:
The class of our very own custom scene node. To keep it simple,
our scene node will not be an indoor portal renderer nor a terrain
scene node, but a simple tetrahedron, a 3D object consisting of 4
connected vertices, which only draws itself and does nothing more.
Note that this scenario does not require a custom scene node in Irrlicht.
Instead one would create a mesh from the geometry and pass it to a
irr::scene::IMeshSceneNode. This example just illustrates creation of a custom
scene node in a simple setting.

To allow our scene node to be inserted into the Irrlicht
Engine scene, the class we create needs to be derived from the
irr::scene::ISceneNode class and has to override some methods.
*/

class CSampleSceneNode : public scene::ISceneNode
{

	/*
	First, we declare some member variables:
	The bounding box, 4 vertices, and the material of the tetrahedron.
	*/
	core::aabbox3d<f32> Box;
	video::S3DVertex Vertices[4];
	video::SMaterial Material;

public:

	/*
	The parameters of the constructor specify the parent of the scene node,
	a pointer to the scene manager, and an id of the scene node.
	In the constructor we call the parent class' constructor,
	set some properties of the material, and create the 4 vertices of 
	the tetrahedron.
	*/

	CSampleSceneNode(scene::ISceneNode* parent, scene::ISceneManager* mgr, s32 id)
		: scene::ISceneNode(parent, mgr, id)
	{
		Material.Wireframe = false;
		Material.Lighting = false;

		Vertices[0] = video::S3DVertex(0,0,10, 1,1,0,
				video::SColor(255,0,255,255), 0, 1);
		Vertices[1] = video::S3DVertex(10,0,-10, 1,0,0,
				video::SColor(255,255,0,255), 1, 1);
		Vertices[2] = video::S3DVertex(0,20,0, 0,1,1,
				video::SColor(255,255,255,0), 1, 0);
		Vertices[3] = video::S3DVertex(-10,0,-10, 0,0,1,
				video::SColor(255,0,255,0), 0, 0);

	/*
	The Irrlicht Engine needs to know the bounding box of a scene node.
	It will use it for automatic culling and other things. Hence, we
	need to create a bounding box from the 4 vertices we use.
	If you do not want the engine to use the box for automatic culling,
	and/or don't want to create the box, you could also call
	irr::scene::ISceneNode::setAutomaticCulling() with irr::scene::EAC_OFF.
	*/
		Box.reset(Vertices[0].Pos);
		for (s32 i=1; i<4; ++i)
			Box.addInternalPoint(Vertices[i].Pos);
	}

	/*
	Before it is drawn, the irr::scene::ISceneNode::OnRegisterSceneNode()
	method of every scene node in the scene is called by the scene manager.
	If the scene node wishes to draw itself, it may register itself in the
	scene manager to be drawn. This is necessary to tell the scene manager
	when it should call irr::scene::ISceneNode::render(). For
	example, normal scene nodes render their content one after another,
	while stencil buffer shadows would like to be drawn after all other
	scene nodes. And camera or light scene nodes need to be rendered before
	all other scene nodes (if at all). So here we simply register the
	scene node to render normally. If we would like to let it be rendered
	like cameras or light, we would have to call
	SceneManager->registerNodeForRendering(this, SNRT_LIGHT_AND_CAMERA);
	After this, we call the actual irr::scene::ISceneNode::OnRegisterSceneNode() 
	method of the base class, which lets all the child scene nodes of this node 
	register themselves.
	*/
	virtual void OnRegisterSceneNode()
	{
		if (IsVisible)
			SceneManager->registerNodeForRendering(this);

		ISceneNode::OnRegisterSceneNode();
	}

	/*
	In the render() method most of the interesting stuff happens: The
	Scene node renders itself. We override this method and draw the
	tetrahedron.
	*/
	virtual void render()
	{
		/* Indices into the 'Vertices' array. A triangle needs 3 vertices 
		so you have to pass the 3 corresponding indices for each triangle to 
		tell which of the vertices should be used for it.	*/
		u16 indices[] = {	0,2,3, 2,1,3, 1,0,3, 2,0,1	}; 
		video::IVideoDriver* driver = SceneManager->getVideoDriver();

		driver->setMaterial(Material);
		driver->setTransform(video::ETS_WORLD, AbsoluteTransformation);
		driver->drawVertexPrimitiveList(&Vertices[0], 4, &indices[0], 4, video::EVT_STANDARD, scene::EPT_TRIANGLES, video::EIT_16BIT);
	}

	/*
	And finally we create three small additional methods.
	irr::scene::ISceneNode::getBoundingBox() returns the bounding box of
	this scene node, irr::scene::ISceneNode::getMaterialCount() returns the
	amount of materials in this scene node (our tetrahedron only has one
	material), and irr::scene::ISceneNode::getMaterial() returns the
	material at an index. Because we have only one material, we can
	return that and assume that no one ever calls getMaterial() with an index 
	greater than 0.
	*/
	virtual const core::aabbox3d<f32>& getBoundingBox() const
	{
		return Box;
	}

	virtual u32 getMaterialCount() const
	{
		return 1;
	}

	virtual video::SMaterial& getMaterial(u32 i)
	{
		return Material;
	}	
};

/*
That's it. The Scene node is done. Now we start the engine, 
create the scene node and a camera, and look at the result.
*/
int main()
{
	// ask user for driver
	video::E_DRIVER_TYPE driverType=driverChoiceConsole();
	if (driverType==video::EDT_COUNT)
		return 1;

	// create device
	IrrlichtDevice *device = createDevice(driverType,
			core::dimension2d<u32>(640, 480), 16, false);
		
	if (device == 0)
		return 1; // could not create selected driver.

	// set window caption, get some pointers, create a camera

	device->setWindowCaption(L"Custom Scene Node - Irrlicht Engine Demo");

	video::IVideoDriver* driver = device->getVideoDriver();
	scene::ISceneManager* smgr = device->getSceneManager();

	smgr->addCameraSceneNode(0, core::vector3df(0,-40,0), core::vector3df(0,0,0));

	/*
	Create our scene node. I don't check the result of calling new, as it
	should throw an exception rather than returning 0 on failure. Because
	the new node will create itself with a reference count of 1, and then
	will have another reference added by its parent scene node when it is
	added to the scene, I need to drop my reference to it. Best practice is
	to drop it only *after* I have finished using it, regardless of what
	the reference count of the object is after creation.
	*/
	CSampleSceneNode *myNode =
		new CSampleSceneNode(smgr->getRootSceneNode(), smgr, 666);

	/*
	To animate something in this boring scene consisting only of one
	tetrahedron, and to show that you now can use your scene node like any
	other scene node in the engine, we add an animator to the scene node,
	which rotates the node a little bit.
	irr::scene::ISceneManager::createRotationAnimator() could return 0, so
	should be checked.
	*/
	scene::ISceneNodeAnimator* anim =
		smgr->createRotationAnimator(core::vector3df(0.8f, 0, 0.8f));

	if(anim)
	{
		myNode->addAnimator(anim);
		
		/*
		I'm done referring to anim, so must
		irr::IReferenceCounted::drop() this reference now because it
		was produced by a createFoo() function. As I shouldn't refer to
		it again, ensure that I can't by setting to 0.
		*/
		anim->drop();
		anim = 0;
	}

	/*
	I'm done with my CSampleSceneNode object, and so must drop my reference.
	This won't delete the object, yet, because it is still attached to the
	scene graph, which prevents the deletion until the graph is deleted or the
	custom scene node is removed from it.
	*/
	myNode->drop();
	myNode = 0; // As I shouldn't refer to it again, ensure that I can't

	/*
	Now draw everything and finish.
	*/
	u32 frames=0;
	while(device->run())
	{
		driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, video::SColor(0,100,100,100));

		smgr->drawAll();

		driver->endScene();
		if (++frames==100) // don't update more often, setWindowCaption can be expensive
		{
			core::stringw str = L"Irrlicht Engine [";
			str += driver->getName();
			str += L"] FPS: ";
			str += (s32)driver->getFPS();

			device->setWindowCaption(str.c_str());
			frames=0;
		}
	}

	device->drop();
	
	return 0;
}

/*
That's it. Compile and play around with the program.
**/
