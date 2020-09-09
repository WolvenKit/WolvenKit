/** Example 020 Managed Lights

Written by Colin MacDonald. This tutorial explains the use of the Light Manager
of Irrlicht. It enables the use of more dynamic light sources than the actual
hardware supports. Further applications of the Light Manager, such as per scene
node callbacks, are left out for simplicity of the example.
*/

#include <irrlicht.h>
#include "driverChoice.h"
#include "exampleHelper.h"

using namespace irr;
using namespace core;

#if defined(_MSC_VER)
#pragma comment(lib, "Irrlicht.lib")
#endif // MSC_VER

/*
    Normally, you are limited to 8 dynamic lights per scene: this is a hardware limit.  If you
    want to use more dynamic lights in your scene, then you can register an optional light
    manager that allows you to to turn lights on and off at specific point during rendering.
    You are still limited to 8 lights, but the limit is per scene node.

    This is completely optional: if you do not register a light manager, then a default
    distance-based scheme will be used to prioritise hardware lights based on their distance
    from the active camera.

	NO_MANAGEMENT disables the light manager and shows Irrlicht's default light behaviour.
    The 8 lights nearest to the camera will be turned on, and other lights will be turned off.
    In this example, this produces a funky looking but incoherent light display.

	LIGHTS_NEAREST_NODE shows an implementation that turns on a limited number of lights
    per mesh scene node.  If finds the 3 lights that are nearest to the node being rendered,
    and turns them on, turning all other lights off.  This works, but as it operates on every
    light for every node, it does not scale well with many lights.  The flickering you can see
    in this demo is due to the lights swapping their relative positions from the cubes
    (a deliberate demonstration of the limitations of this technique).

	LIGHTS_IN_ZONE shows a technique for turning on lights based on a 'zone'. Each empty scene
    node is considered to be the parent of a zone.  When nodes are rendered, they turn off all
    lights, then find their parent 'zone' and turn on all lights that are inside that zone, i.e.
	are  descendents of it in the scene graph.  This produces true 'local' lighting for each cube
    in this example.  You could use a similar technique to locally light all meshes in (e.g.)
    a room, without the lights spilling out to other rooms.

	This light manager is also an event receiver; this is purely for simplicity in this example,
    it's neither necessary nor recommended for a real application.
*/
class CMyLightManager : public scene::ILightManager, public IEventReceiver
{
	typedef enum
	{
		NO_MANAGEMENT,
		LIGHTS_NEAREST_NODE,
		LIGHTS_IN_ZONE
	}
	LightManagementMode;

	LightManagementMode Mode;
	LightManagementMode RequestedMode;

	// These data represent the state information that this light manager
	// is interested in.
	scene::ISceneManager * SceneManager;
	core::array<scene::ISceneNode*> * SceneLightList;
	scene::E_SCENE_NODE_RENDER_PASS CurrentRenderPass;
	scene::ISceneNode * CurrentSceneNode;

public:
	CMyLightManager(scene::ISceneManager* sceneManager)
		: Mode(NO_MANAGEMENT), RequestedMode(NO_MANAGEMENT),
		SceneManager(sceneManager), SceneLightList(0),
		CurrentRenderPass(scene::ESNRP_NONE), CurrentSceneNode(0)
	{ }

	// The input receiver interface, which just switches light management strategy
	bool OnEvent(const SEvent & event)
	{
		bool handled = false;

		if (event.EventType == irr::EET_KEY_INPUT_EVENT && event.KeyInput.PressedDown)
		{
			handled = true;
			switch(event.KeyInput.Key)
			{
			case irr::KEY_KEY_1:
				RequestedMode = NO_MANAGEMENT;
				break;
			case irr::KEY_KEY_2:
				RequestedMode = LIGHTS_NEAREST_NODE;
				break;
			case irr::KEY_KEY_3:
				RequestedMode = LIGHTS_IN_ZONE;
				break;
			default:
				handled = false;
				break;
			}

			if(NO_MANAGEMENT == RequestedMode)
				SceneManager->setLightManager(0); // Show that it's safe to register the light manager
			else
				SceneManager->setLightManager(this);
		}

		return handled;
	}


	// This is called before the first scene node is rendered.
	virtual void OnPreRender(core::array<scene::ISceneNode*> & lightList)
	{
		// Update the mode; changing it here ensures that it's consistent throughout a render
		Mode = RequestedMode;

		// Store the light list. I am free to alter this list until the end of OnPostRender().
		SceneLightList = &lightList;
	}

	// Called after the last scene node is rendered.
	virtual void OnPostRender()
	{
		// Since light management might be switched off in the event handler, we'll turn all
		// lights on to ensure that they are in a consistent state. You wouldn't normally have
		// to do this when using a light manager, since you'd continue to do light management
		// yourself.
		for (u32 i = 0; i < SceneLightList->size(); i++)
			(*SceneLightList)[i]->setVisible(true);
	}

	virtual void OnRenderPassPreRender(scene::E_SCENE_NODE_RENDER_PASS renderPass)
	{
		// I don't have to do anything here except remember which render pass I am in.
		CurrentRenderPass = renderPass;
	}

	virtual void OnRenderPassPostRender(scene::E_SCENE_NODE_RENDER_PASS renderPass)
	{
		// I only want solid nodes to be lit, so after the solid pass, turn all lights off.
		if (scene::ESNRP_SOLID == renderPass)
		{
			for (u32 i = 0; i < SceneLightList->size(); ++i)
				(*SceneLightList)[i]->setVisible(false);
		}
	}

	// This is called before the specified scene node is rendered
	virtual void OnNodePreRender(scene::ISceneNode* node)
	{
		CurrentSceneNode = node;

		// This light manager only considers solid objects, but you are free to manipulate
		// lights during any phase, depending on your requirements.
		if (scene::ESNRP_SOLID != CurrentRenderPass)
			return;

		// And in fact for this example, I only want to consider lighting for cube scene
		// nodes.  You will probably want to deal with lighting for (at least) mesh /
		// animated mesh scene nodes as well.
		if (node->getType() != scene::ESNT_CUBE)
			return;

		if (LIGHTS_NEAREST_NODE == Mode)
		{
			// This is a naive implementation that prioritises every light in the scene
			// by its proximity to the node being rendered.  This produces some flickering
			// when lights orbit closer to a cube than its 'zone' lights.
			const vector3df nodePosition = node->getAbsolutePosition();

			// Sort the light list by prioritising them based on their distance from the node
			// that's about to be rendered.
			array<LightDistanceElement> sortingArray;
			sortingArray.reallocate(SceneLightList->size());

			u32 i;
			for(i = 0; i < SceneLightList->size(); ++i)
			{
				scene::ISceneNode* lightNode = (*SceneLightList)[i];
				const f64 distance = lightNode->getAbsolutePosition().getDistanceFromSQ(nodePosition);
				sortingArray.push_back(LightDistanceElement(lightNode, distance));
			}

			sortingArray.sort();

			// The list is now sorted by proximity to the node.
			// Turn on the three nearest lights, and turn the others off.
			for(i = 0; i < sortingArray.size(); ++i)
				sortingArray[i].node->setVisible(i < 3);
		}
		else if(LIGHTS_IN_ZONE == Mode)
		{
			// Empty scene nodes are used to represent 'zones'.  For each solid mesh that
			// is being rendered, turn off all lights, then find its 'zone' parent, and turn
			// on all lights that are found under that node in the scene graph.
			// This is a general purpose algorithm that doesn't use any special
			// knowledge of how this particular scene graph is organised.
			for (u32 i = 0; i < SceneLightList->size(); ++i)
			{
				if ((*SceneLightList)[i]->getType() != scene::ESNT_LIGHT)
					continue;
				scene::ILightSceneNode* lightNode = static_cast<scene::ILightSceneNode*>((*SceneLightList)[i]);
				video::SLight & lightData = lightNode->getLightData();

				if (video::ELT_DIRECTIONAL != lightData.Type)
					lightNode->setVisible(false);
			}

			scene::ISceneNode * parentZone = findZone(node);
			if (parentZone)
				turnOnZoneLights(parentZone);
		}
	}

	// Called after the specified scene node is rendered
	virtual void OnNodePostRender(scene::ISceneNode* node)
	{
		// I don't need to do any light management after individual node rendering.
	}

private:

	// Find the empty scene node that is the parent of the specified node
	scene::ISceneNode * findZone(scene::ISceneNode * node)
	{
		if (!node)
			return 0;

		if (node->getType() == scene::ESNT_EMPTY)
			return node;

		return findZone(node->getParent());
	}

	// Turn on all lights that are children (directly or indirectly) of the
	// specified scene node.
	void turnOnZoneLights(scene::ISceneNode * node)
	{
		core::list<scene::ISceneNode*> const & children = node->getChildren();
		for (core::list<scene::ISceneNode*>::ConstIterator child = children.begin();
			child != children.end(); ++child)
		{
			if ((*child)->getType() == scene::ESNT_LIGHT)
				(*child)->setVisible(true);
			else // Assume that lights don't have any children that are also lights
				turnOnZoneLights(*child);
		}
	}


	// A utility class to aid in sorting scene nodes into a distance order
	class LightDistanceElement
	{
	public:
		LightDistanceElement() {};

		LightDistanceElement(scene::ISceneNode* n, f64 d)
			: node(n), distance(d) { }

		scene::ISceneNode* node;
		f64 distance;

		// Lower distance elements are sorted to the start of the array
		bool operator < (const LightDistanceElement& other) const
		{
			return (distance < other.distance);
		}
	};
};


/*
*/
int main(int argumentCount, char * argumentValues[])
{
	// ask user for driver
	video::E_DRIVER_TYPE driverType=driverChoiceConsole();
	if (driverType==video::EDT_COUNT)
		return 1;

	IrrlichtDevice *device = createDevice(driverType,
			dimension2d<u32>(640, 480), 32);

	if(!device)
		return -1;

	f32 const lightRadius = 60.f; // Enough to reach the far side of each 'zone'

	video::IVideoDriver* driver = device->getVideoDriver();
	scene::ISceneManager* smgr = device->getSceneManager();
	gui::IGUIEnvironment* guienv = device->getGUIEnvironment();

	const io::path mediaPath = getExampleMediaPath();

	gui::IGUISkin* skin = guienv->getSkin();
	if (skin)
	{
		skin->setColor(gui::EGDC_BUTTON_TEXT, video::SColor(255, 255, 255, 255));
		gui::IGUIFont* font = guienv->getFont(mediaPath + "fontlucida.png");
		if(font)
			skin->setFont(font);
	}

	guienv->addStaticText(L"1 - No light management", core::rect<s32>(10,10,200,30));
	guienv->addStaticText(L"2 - Closest 3 lights", core::rect<s32>(10,30,200,50));
	guienv->addStaticText(L"3 - Lights in zone", core::rect<s32>(10,50,200,70));

/*
Add several "zones".  You could use this technique to light individual rooms, for example.
*/
	for(f32 zoneX = -100.f; zoneX <= 100.f; zoneX += 50.f)
		for(f32 zoneY = -60.f; zoneY <= 60.f; zoneY += 60.f)
		{
			// Start with an empty scene node, which we will use to represent a zone.
			scene::ISceneNode * zoneRoot = smgr->addEmptySceneNode();
			zoneRoot->setPosition(vector3df(zoneX, zoneY, 0));

			// Each zone contains a rotating cube
			scene::IMeshSceneNode * node = smgr->addCubeSceneNode(15, zoneRoot);
			scene::ISceneNodeAnimator * rotation = smgr->createRotationAnimator(vector3df(0.25f, 0.5f, 0.75f));
			node->addAnimator(rotation);
			rotation->drop();

			// And each cube has three lights attached to it.  The lights are attached to billboards so
			// that we can see where they are.  The billboards are attached to the cube, so that the
			// lights are indirect descendents of the same empty scene node as the cube.
			scene::IBillboardSceneNode * billboard = smgr->addBillboardSceneNode(node);
			billboard->setPosition(vector3df(0, -14, 30));
			billboard->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR );
			billboard->setMaterialTexture(0, driver->getTexture(mediaPath + "particle.bmp"));
			billboard->setMaterialFlag(video::EMF_LIGHTING, false);
			smgr->addLightSceneNode(billboard, vector3df(0, 0, 0), video::SColorf(1, 0, 0), lightRadius);

			billboard = smgr->addBillboardSceneNode(node);
			billboard->setPosition(vector3df(-21, -14, -21));
			billboard->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR );
			billboard->setMaterialTexture(0, driver->getTexture(mediaPath + "particle.bmp"));
			billboard->setMaterialFlag(video::EMF_LIGHTING, false);
			smgr->addLightSceneNode(billboard, vector3df(0, 0, 0), video::SColorf(0, 1, 0), lightRadius);

			billboard = smgr->addBillboardSceneNode(node);
			billboard->setPosition(vector3df(21, -14, -21));
			billboard->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR );
			billboard->setMaterialTexture(0, driver->getTexture(mediaPath + "particle.bmp"));
			billboard->setMaterialFlag(video::EMF_LIGHTING, false);
			smgr->addLightSceneNode(billboard, vector3df(0, 0, 0), video::SColorf(0, 0, 1), lightRadius);

			// Each cube also has a smaller cube rotating around it, to show that the cubes are being
			// lit by the lights in their 'zone', not just lights that are their direct children.
			node = smgr->addCubeSceneNode(5, node);
			node->setPosition(vector3df(0, 21, 0));
		}

	smgr->addCameraSceneNode(0, vector3df(0,0,-130), vector3df(0,0,0));

	CMyLightManager * myLightManager = new CMyLightManager(smgr);
	smgr->setLightManager(0); // This is the default: we won't do light management until told to do it.
	device->setEventReceiver(myLightManager);

	int lastFps = -1;

	while(device->run())
	{
		driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, video::SColor(255,100,101,140));
		smgr->drawAll();
		guienv->drawAll();
		driver->endScene();

		int fps = driver->getFPS();
		if(fps != lastFps)
		{
			lastFps = fps;
			core::stringw str = L"Managed Lights [";
			str += driver->getName();
			str += "] FPS:";
			str += fps;
			device->setWindowCaption(str.c_str());
		}
	}

	myLightManager->drop(); // Drop my implicit reference
	device->drop();
	return 0;
}

/*
**/

