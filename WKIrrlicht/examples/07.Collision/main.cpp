/** Example 007 Collision

We will describe 2 methods: Automatic collision detection for moving through
3d worlds with stair climbing and sliding, and manual scene node and triangle
picking using a ray.  In this case, we will use a ray coming out from the
camera, but you can use any ray.

To start, we take the program from tutorial 2, which loads and displays a
quake 3 level. We will use the level to walk in it and to pick triangles from.
In addition we'll place 3 animated models into it for triangle picking. The
following code starts up the engine and loads the level, as per tutorial 2.
*/
#include <irrlicht.h>
#include "driverChoice.h"
#include "exampleHelper.h"

using namespace irr;

#ifdef _MSC_VER
#pragma comment(lib, "Irrlicht.lib")
#endif

enum
{
	// I use this ISceneNode ID to indicate a scene node that is
	// not pickable by getSceneNodeAndCollisionPointFromRay()
	ID_IsNotPickable = 0,

	// I use this flag in ISceneNode IDs to indicate that the
	// scene node can be picked by ray selection.
	IDFlag_IsPickable = 1 << 0,

	// I use this flag in ISceneNode IDs to indicate that the
	// scene node can be highlighted.  In this example, the
	// homonids can be highlighted, but the level mesh can't.
	IDFlag_IsHighlightable = 1 << 1
};

int main()
{
	// ask user for driver
	video::E_DRIVER_TYPE driverType=driverChoiceConsole();
	if (driverType==video::EDT_COUNT)
		return 1;

	// create device

	IrrlichtDevice *device =
		createDevice(driverType, core::dimension2d<u32>(640, 480), 16, false);

	if (device == 0)
		return 1; // could not create selected driver.

	/*
	If we want to receive information about the material of a hit triangle we have to get 
	collisions per meshbuffer. The only disadvantage of this is that getting them per 
	meshbuffer can be a little bit slower than per mesh, but usually that's not noticeable.
	If you set this to false you will no longer get material names in the title bar.
	*/
	const bool separateMeshBuffers = true;

	video::IVideoDriver* driver = device->getVideoDriver();
	scene::ISceneManager* smgr = device->getSceneManager();

	const io::path mediaPath = getExampleMediaPath();

	device->getFileSystem()->addFileArchive(mediaPath + "map-20kdm2.pk3");

	scene::IAnimatedMesh* q3levelmesh = smgr->getMesh("20kdm2.bsp");
	scene::IMeshSceneNode* q3node = 0;

	// The Quake mesh is pickable, but doesn't get highlighted.
	if (q3levelmesh)
		q3node = smgr->addOctreeSceneNode(q3levelmesh->getMesh(0), 0, IDFlag_IsPickable);

	/*
	So far so good, we've loaded the quake 3 level like in tutorial 2. Now,
	here comes something different: We create a triangle selector. A
	triangle selector is a class which can fetch the triangles from scene
	nodes for doing different things with them, for example collision
	detection. There are different triangle selectors, and all can be
	created with the ISceneManager. In this example, we create an
	OctreeTriangleSelector, which optimizes the triangle output a little
	bit by reducing it like an octree. This is very useful for huge meshes
	like quake 3 levels. After we created the triangle selector, we attach
	it to the q3node. This is not necessary, but in this way, we do not
	need to care for the selector, for example dropping it after we do not
	need it anymore.
	*/

	scene::ITriangleSelector* selector = 0;

	if (q3node)
	{
		q3node->setPosition(core::vector3df(-1350,-130,-1400));

		/*
			There is currently no way to split an octree by material.
			So if we need material infos we have to create one octree per 
			meshbuffer and put them together in a MetaTriangleSelector.
		*/
		if ( separateMeshBuffers && q3node->getMesh()->getMeshBufferCount() > 1)
		{
			scene::IMetaTriangleSelector * metaSelector = smgr->createMetaTriangleSelector();
			for ( irr::u32 m=0; m < q3node->getMesh()->getMeshBufferCount(); ++m )
			{
				scene::ITriangleSelector*
					bufferSelector = smgr->createOctreeTriangleSelector(
					q3node->getMesh()->getMeshBuffer(m), m, q3node);
				if ( bufferSelector )
				{
					metaSelector->addTriangleSelector( bufferSelector );
					bufferSelector->drop();
				}
			}
			selector = metaSelector;
		}
		else
		{
			// If you don't need material infos just create one octree for the 
			// whole mesh.
			selector = smgr->createOctreeTriangleSelector(
					q3node->getMesh(), q3node, 128);
		}
		q3node->setTriangleSelector(selector);
		// We're not done with this selector yet, so don't drop it.
	}


	/*
	We add a first person shooter camera to the scene so that we can see and
	move in the quake 3 level like in tutorial 2. But this, time, we add a
	special animator to the camera: A collision response animator. This
	animator modifies the scene node to which it is attached in order to
	prevent it from moving through walls and to add gravity to the node. The
	only things we have to tell the animator is how the world looks like,
	how big the scene node is, how much gravity to apply and so on. After the
	collision response animator is attached to the camera, we do not have to do
	anything else for collision detection, it's all done automatically.
	The rest of the collision detection code below is for picking. And please
	note another cool feature: The collision response animator can be
	attached also to all other scene nodes, not only to cameras. And it can
	be mixed with other scene node animators. In this way, collision
	detection and response in the Irrlicht engine is really easy.

	Now we'll take a closer look on the parameters of
	createCollisionResponseAnimator(). The first parameter is the
	TriangleSelector, which specifies how the world, against which collision
	detection is done, looks like. The second parameter is the scene node,
	which is the object which is affected by collision detection - in our
	case it is the camera. The third defines how big the object is, it is
	the radius of an ellipsoid. Try it out and change the radius to smaller
	values, the camera will be able to move closer to walls after this. The
	next parameter is the direction and speed of gravity.  We'll set it to
	(0, -1000, 0), which approximates realistic gravity (depends on the units 
	which are used in the scene model). You could set it to (0,0,0) to disable 
	gravity. And the last value is just an offset: Without it the ellipsoid with 
	which collision detection is done would be around the camera and the camera 
	would be in the middle of the ellipsoid. But as human beings, we are used to 
	have our eyes on top of the body, not in the middle of it. So we place the 
	scene node 50 units over the center of the ellipsoid with this parameter. 
	And that's it, collision detection works now.
	*/

	// Set a jump speed of 300 units per second, which gives a fairly realistic jump
	// when used with the gravity of (0, -1000, 0) in the collision response animator.
	scene::ICameraSceneNode* camera =
		smgr->addCameraSceneNodeFPS(0, 100.0f, .3f, ID_IsNotPickable, 0, 0, true, 300.f);
	camera->setPosition(core::vector3df(50,50,-60));
	camera->setTarget(core::vector3df(-70,30,-60));

	if (selector)
	{
		scene::ISceneNodeAnimatorCollisionResponse * anim = smgr->createCollisionResponseAnimator(
			selector, camera, core::vector3df(30,50,30),
			core::vector3df(0,-1000,0), core::vector3df(0,30,0));
		selector->drop(); // As soon as we're done with the selector, drop it.
		camera->addAnimator(anim);
		anim->drop();  // And likewise, drop the animator when we're done referring to it.
	}

	// Now I create three animated characters which we can pick, a dynamic light for
	// lighting them, and a billboard for drawing where we found an intersection.

	// First, let's get rid of the mouse cursor.  We'll use a billboard to show
	// what we're looking at.
	device->getCursorControl()->setVisible(false);

	// Add the billboard.
	scene::IBillboardSceneNode * bill = smgr->addBillboardSceneNode();
	bill->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR );
	bill->setMaterialTexture(0, driver->getTexture(mediaPath + "particle.bmp"));
	bill->setMaterialFlag(video::EMF_LIGHTING, false);
	bill->setMaterialFlag(video::EMF_ZBUFFER, false);
	bill->setSize(core::dimension2d<f32>(20.0f, 20.0f));
	bill->setID(ID_IsNotPickable); // This ensures that we don't accidentally ray-pick it

	/* Add 3 animated hominids, which we can pick using a ray-triangle intersection.
	They all animate quite slowly, to make it easier to see that accurate triangle
	selection is being performed. */
	scene::IAnimatedMeshSceneNode* node = 0;

	video::SMaterial material;

	// Add an MD2 node, which uses vertex-based animation.
	node = smgr->addAnimatedMeshSceneNode(smgr->getMesh(mediaPath + "faerie.md2"),
						0, IDFlag_IsPickable | IDFlag_IsHighlightable);
	node->setPosition(core::vector3df(-90,-15,-140)); // Put its feet on the floor.
	node->setScale(core::vector3df(1.6f)); // Make it appear realistically scaled
	node->setMD2Animation(scene::EMAT_POINT);
	node->setAnimationSpeed(20.f);
	material.setTexture(0, driver->getTexture(mediaPath + "faerie2.bmp"));
	material.Lighting = true;
	material.NormalizeNormals = true;
	node->getMaterial(0) = material;

	// Now create a triangle selector for it.  The selector will know that it
	// is associated with an animated node, and will update itself as necessary.
	selector = smgr->createTriangleSelector(node, separateMeshBuffers);
	node->setTriangleSelector(selector);
	selector->drop(); // We're done with this selector, so drop it now.

	// And this B3D file uses skinned skeletal animation.
	node = smgr->addAnimatedMeshSceneNode(smgr->getMesh(mediaPath + "ninja.b3d"),
						0, IDFlag_IsPickable | IDFlag_IsHighlightable);
	node->setScale(core::vector3df(10));
	node->setPosition(core::vector3df(-75,-66,-80));
	node->setRotation(core::vector3df(0,90,0));
	node->setAnimationSpeed(8.f);
	node->getMaterial(0).NormalizeNormals = true;
	node->getMaterial(0).Lighting = true;
	// Just do the same as we did above.
	selector = smgr->createTriangleSelector(node, separateMeshBuffers);
	node->setTriangleSelector(selector);
	selector->drop();

	// This X files uses skeletal animation, but without skinning.
	node = smgr->addAnimatedMeshSceneNode(smgr->getMesh(mediaPath + "dwarf.x"),
						0, IDFlag_IsPickable | IDFlag_IsHighlightable);
	node->setPosition(core::vector3df(-70,-66,-30)); // Put its feet on the floor.
	node->setRotation(core::vector3df(0,-90,0)); // And turn it towards the camera.
	node->setAnimationSpeed(20.f);
	node->getMaterial(0).Lighting = true;
	selector = smgr->createTriangleSelector(node, separateMeshBuffers);
	node->setTriangleSelector(selector);
	selector->drop();

	// And this mdl file uses skinned skeletal animation.
	node = smgr->addAnimatedMeshSceneNode(smgr->getMesh(mediaPath + "yodan.mdl"),
						0, IDFlag_IsPickable | IDFlag_IsHighlightable);
	node->setPosition(core::vector3df(-90,-25,20));
	node->setScale(core::vector3df(0.8f));
	node->getMaterial(0).Lighting = true;
	node->setAnimationSpeed(20.f);

	// Just do the same as we did above.
	selector = smgr->createTriangleSelector(node, separateMeshBuffers);
	node->setTriangleSelector(selector);
	selector->drop();

	material.setTexture(0, 0);
	material.Lighting = false;

	// Add a light, so that the unselected nodes aren't completely dark.
	scene::ILightSceneNode * light = smgr->addLightSceneNode(0, core::vector3df(-60,100,400),
		video::SColorf(1.0f,1.0f,1.0f,1.0f), 600.0f);
	light->setID(ID_IsNotPickable); // Make it an invalid target for selection.

	// Remember which scene node is highlighted
	scene::ISceneNode* highlightedSceneNode = 0;
	scene::ISceneCollisionManager* collMan = smgr->getSceneCollisionManager();

	// draw the selection triangle only as wireframe
	material.Wireframe=true;

	while(device->run())
	if (device->isWindowActive())
	{
		driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, video::SColor(0));
		smgr->drawAll();

		// Unlight any currently highlighted scene node
		if (highlightedSceneNode)
		{
			highlightedSceneNode->setMaterialFlag(video::EMF_LIGHTING, true);
			highlightedSceneNode = 0;
		}

		// All intersections in this example are done with a ray cast out from the camera to
		// a distance of 1000.  You can easily modify this to check (e.g.) a bullet
		// trajectory or a sword's position, or create a ray from a mouse click position using
		// ISceneCollisionManager::getRayFromScreenCoordinates()
		core::line3d<f32> ray;
		ray.start = camera->getPosition();
		ray.end = ray.start + (camera->getTarget() - ray.start).normalize() * 1000.0f;


		// This call is all you need to perform ray/triangle collision on every scene node
		// that has a triangle selector, including the Quake level mesh.  It finds the nearest
		// collision point/triangle, and returns the scene node containing that point.
		// Irrlicht provides other types of selection, including ray/triangle selector,
		// ray/box and ellipse/triangle selector, plus associated helpers.
		// You might also want to check the other methods of ISceneCollisionManager.

		irr::io::SNamedPath hitTextureName;
		scene::SCollisionHit hitResult;
		scene::ISceneNode * selectedSceneNode =collMan->getSceneNodeAndCollisionPointFromRay(
					hitResult,	// Returns all kind of info about the collision
					ray,
					IDFlag_IsPickable, // This ensures that only nodes that we have
							// set up to be pickable are considered
					0); // Check the entire scene (this is actually the implicit default)


		// If the ray hit anything, move the billboard to the collision position
		// and draw the triangle that was hit.
		if(selectedSceneNode)
		{
			bill->setPosition(hitResult.Intersection);	// Show the current intersection point with the level or a mesh

			// We need to reset the transform before doing our own rendering.
			driver->setTransform(video::ETS_WORLD, core::matrix4());
			driver->setMaterial(material);
			driver->draw3DTriangle(hitResult.Triangle, video::SColor(0,255,0,0));	// Show which triangle has been hit

			// We can check the flags for the scene node that was hit to see if it should be
			// highlighted. The animated nodes can be highlighted, but not the Quake level mesh
			if((selectedSceneNode->getID() & IDFlag_IsHighlightable) == IDFlag_IsHighlightable)
			{
				highlightedSceneNode = selectedSceneNode;

				// Highlighting in this case means turning lighting OFF for this node,
				// which means that it will be drawn with full brightness.
				highlightedSceneNode->setMaterialFlag(video::EMF_LIGHTING, false);
			}

			// When separateMeshBuffers is set to true we can now find out which material was hit
			if ( hitResult.MeshBuffer && hitResult.Node && hitResult.Node->getMaterial(hitResult.MaterialIndex).TextureLayer[0].Texture )
			{
				// Note we are interested in the node material and not in the meshbuffer material.
				// Otherwise we wouldn't get the fairy2 texture which is only set on the node.
				hitTextureName = hitResult.Node->getMaterial(hitResult.MaterialIndex).TextureLayer[0].Texture->getName();
			}
		}

		// We're all done drawing, so end the scene.
		driver->endScene();

		// Show some info in title-bar
		int fps = driver->getFPS();
		static core::stringw lastString;
		core::stringw str = L"Collision detection example - Irrlicht Engine [";
		str += driver->getName();
		str += "] FPS:";
		str += fps;
		if ( !hitTextureName.getInternalName().empty() )
		{
			str += " ";
			irr::io::path texName(hitTextureName.getInternalName());
			str += core::deletePathFromFilename(texName);
		}
		if ( str != lastString )	// changing caption is somewhat expensive, so don't when nothing changed
		{
			device->setWindowCaption(str.c_str());
			lastString = str;
		}
	}

	device->drop();

	return 0;
}

/*
**/
