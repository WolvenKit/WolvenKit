
#ifdef _MSC_VER
#pragma comment(lib, "Irrlicht.lib")
#pragma comment(linker, "/subsystem:windows /ENTRY:mainCRTStartup")
#endif


#include <irrlicht.h>
#include <string>
#include <iostream>

#include "config.h"
#include "WKEventReceiver.h"

class CW3EntLoader;

using namespace irr;
using namespace WKRender;

io::path StartUpModelFile;
io::path RigModelFile;
io::path AnimationModelFile;
bool animsLoaded;





int main()
{
	SIrrlichtCreationParameters irrparam = {};
	irrparam.DriverType = video::EDT_DIRECT3D9;
	irrparam.Bits = 32;
	irrparam.WindowSize = core::dimension2d<u32>(1280, 960);

	/*
	IrrlichtDevice* device =
		createDevice(video::EDT_DIRECT3D9, dimension2d<u32>(1080, 960), 16,
			false, false, false, 0);

	*/
	IrrlichtDevice* device = createDeviceEx(irrparam);

	if (!device)
		return 1;

	WKEventReceiver receiver(device);
	animsLoaded = false;
	core::array<core::stringc> animsList;
	
	device->setWindowCaption(L"Witcher Renderer! - Irrlicht Engine");
	device->setEventReceiver(&receiver);

	
	video::IVideoDriver* driver = device->getVideoDriver();
	scene::ISceneManager* smgr = device->getSceneManager();
	gui::IGUIEnvironment* gui = device->getGUIEnvironment();
	io::IFileSystem* fileSystem = device->getFileSystem();

	smgr->getParameters()->addBool("TW_TW3_LOAD_SKEL", true);
	smgr->getParameters()->addBool("TW_TW3_LOAD_BEST_LOD_ONLY", true);

	// add some static text to gui
	core::stringw animText = L"Animation: ";

	gui::IGUIStaticText* mAnimText = gui->addStaticText(animText.c_str(),
		core::rect((s32)0,
			(s32)(driver->getScreenSize().Height - 80),
			(s32)100,
			(s32)(driver->getScreenSize().Width - 70)));
	gui::IGUIStaticText* mPositionText = gui->addStaticText(L"",
		core::rect((s32)0,
			(s32)(driver->getScreenSize().Height - 70),
			(s32)100,
			(s32)(driver->getScreenSize().Width - 60)));
	gui::IGUIStaticText* mRotationText = gui->addStaticText(L"",
		core::rect((s32)0,
			(s32)(driver->getScreenSize().Height - 60),
			(s32)100,
			(s32)(driver->getScreenSize().Width - 50)));
	gui::IGUIStaticText* fpsText = gui->addStaticText(L"",
		core::rect((s32)0,
			(s32)(driver->getScreenSize().Height - 50),
			(s32)100,
			(s32)(driver->getScreenSize().Width - 40)));
	gui::IGUIStaticText* infoText = gui->addStaticText(L"[Space] - Reset\n[LMouse] - Rotate\n[MMouse] - Move\n[Wheel] - Zoom",
		core::rect((s32)0,
			(s32)(driver->getScreenSize().Height - 40),
			(s32)100,
			(s32)(driver->getScreenSize().Height)));

	mAnimText->setOverrideColor(video::SColor(255, 255, 255, 255));
	mPositionText->setOverrideColor(video::SColor(255, 255, 255, 255));
	mRotationText->setOverrideColor(video::SColor(255, 255, 255, 255));
	fpsText->setOverrideColor(video::SColor(255, 255, 255, 255));
	infoText->setOverrideColor(video::SColor(255, 255, 255, 255));

	mAnimText->setBackgroundColor(video::SColor(255, 0, 0, 0));
	mPositionText->setBackgroundColor(video::SColor(255, 0, 0, 0));
	mRotationText->setBackgroundColor(video::SColor(255, 0, 0, 0));
	fpsText->setBackgroundColor(video::SColor(255, 0, 0, 0));
	infoText->setBackgroundColor(video::SColor(255, 0, 0, 0));


	io::IXMLReader* xml = device->getFileSystem()->createXMLReader(L"config.xml");

	while (xml && xml->read())
	{
		switch (xml->getNodeType())
		{
		case io::EXN_ELEMENT:
		{
			if (core::stringw("startUpModel") == xml->getNodeName())
				StartUpModelFile = xml->getAttributeValue(L"file");
			else if (core::stringw("rigModel") == xml->getNodeName())
				RigModelFile = xml->getAttributeValue(L"file");
			else if (core::stringw("animationModel") == xml->getNodeName())
				AnimationModelFile = xml->getAttributeValue(L"file");
		}
		break;
		default:
			break;
		}
	}
	//const io::path mediaPath = getExampleMediaPath();

	for (core::stringw path : w3paths)
	{
		device->getFileSystem()->addFileArchive(path);
	}

	
	if (xml)
		xml->drop(); // don't forget to delete the xml reader

	Mesh = smgr->getMesh(StartUpModelFile);
	if (!Mesh)
	{
		device->drop();
		return 1;
	}

	smgr->getMeshManipulator()->recalculateNormals(Mesh);
	//mesh->setDirty(scene::EBT_VERTEX_AND_INDEX);
	//scene::CSkinnedMesh() ms = mesh->getMesh(0);
	node = smgr->addAnimatedMeshSceneNode(Mesh);

	helper = smgr->getMeshLoader(smgr->getMeshLoaderCount() - 1)->getMeshLoaderHelper();
	if (node)
	{
		node->setScale(core::vector3df(3.0f));
		node->setMaterialFlag(video::EMF_LIGHTING, false);
		scaleMul = node->getBoundingBox().getRadius() / 4;

		bool rigSuccess = false;
		if (!RigModelFile.empty())
		{
			skinMesh = helper->loadRig(RigModelFile, Mesh);
			if (skinMesh)
			{
				rigSuccess = true;
				//mesh->drop();
				node->setMesh(skinMesh);
				setMaterialsSettings(node);
			}
		}

		if (!AnimationModelFile.empty() && rigSuccess)
		{
			animsList = helper->loadAnimation(AnimationModelFile, skinMesh);
			if (animsList.size() > 0)
				runAnimation("run");
			else
				std::cout << "Anims fail";
		}
	}

	
	//smgr->addLightSceneNode(0, core::vector3df(10, 10, -1), video::SColorf(1.0f, 1.0f, 1.0f), 100.0f, -1);
	//smgr->setAmbientLight(video::SColorf(255.0, 255.0, 255.0));

	auto camera = smgr->addCameraSceneNode(0,
		core::vector3df(node->getBoundingBox().getRadius() * 8, node->getBoundingBox().getRadius(), 0),
		core::vector3df(0, node->getBoundingBox().getRadius(), 0));

	//auto camera = smgr->addCameraSceneNodeFPS(0, 10.0f, 10.0f, -1, 0, 0, false, 0.0f);

	camera->setNearValue(0.001f);
	camera->setFOV(45.0f * 3.14f / 180.0f);
	
	auto viewPort = driver->getViewPort();
	auto lineMat = new video::SMaterial();
	lineMat->Lighting = false;

	node->setDebugDataVisible(scene::EDS_BBOX | scene::EDS_SKELETON);
	node->setPosition(modelPosition);
	node->setRotation(modelAngle);

	while (device->run())
	{
		
		driver->setViewPort(viewPort);
		driver->beginScene(video::ECBF_ALL, video::SColor(255, 100, 101, 140));

		node->setPosition(modelPosition);
		node->setRotation(modelAngle);

		fpsText->setText(std::to_wstring(driver->getFPS()).c_str());

		smgr->drawAll();
		gui->drawAll();


		driver->setViewPort(core::rect((s32)(driver->getScreenSize().Width - 100),
			(s32)(driver->getScreenSize().Height - 80),
			(s32)(driver->getScreenSize().Width),
			(s32)(driver->getScreenSize().Height)));

		driver->setMaterial(*lineMat);

		core::matrix4 matrix = core::matrix4();
		matrix.setTranslation(core::vector3df(0.0f));
		matrix.setRotationDegrees(modelAngle);
		driver->setTransform(video::ETS_WORLD, matrix);
		matrix = matrix.buildProjectionMatrixOrthoLH(100, 80, camera->getNearValue(), camera->getFarValue());
		driver->setTransform(video::ETS_PROJECTION, matrix);
		matrix = matrix.buildCameraLookAtMatrixLH(core::vector3df(50, 0, 0), core::vector3df(0), core::vector3df(0, 1.0f, 0));
		driver->setTransform(video::ETS_VIEW, matrix);

		driver->draw3DLine(core::vector3df(0, 0, 0), core::vector3df(30.0f, 0, 0), video::SColor(255, 0, 255, 0));
		driver->draw3DLine(core::vector3df(0, 0, 0), core::vector3df(0, 30.0f, 0), video::SColor(255, 0, 0, 255));
		driver->draw3DLine(core::vector3df(0, 0, 0), core::vector3df(0, 0, 30.0f), video::SColor(255, 255, 0, 0));

		driver->endScene();
	}

	
	device->drop();
	animsList.clear();

	return 0;
}

/*
That's it. Compile and run.
**/