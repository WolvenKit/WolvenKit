// This is a Demo of the Irrlicht Engine (c) 2005-2009 by N.Gebhardt.
// This file is not documented.

#include "CMainMenu.h"
#include "CDemo.h"
#include "exampleHelper.h"



CMainMenu::CMainMenu()
: startButton(0), MenuDevice(0), selected(0), start(false),	fullscreen(false),
#if defined(USE_IRRKLANG) || defined(USE_SDL_MIXER)
	music(true),
#else
	music(false),
#endif
	shadows(true), additive(false), transparent(true), vsync(true), aa(true),
#ifndef _IRR_WINDOWS_
	driverType(video::EDT_OPENGL)
#else
	driverType(video::EDT_DIRECT3D9)
#endif
	//driverType(video::EDT_BURNINGSVIDEO)
{
}


bool CMainMenu::run()
{
	MenuDevice = createDevice(video::EDT_BURNINGSVIDEO,
		core::dimension2d<u32>(512, 384), 16, false, false, false, this);

	const io::path mediaPath = getExampleMediaPath();

	if (MenuDevice->getFileSystem()->existFile("irrlicht.dat"))
		MenuDevice->getFileSystem()->addFileArchive("irrlicht.dat");
	else
		MenuDevice->getFileSystem()->addFileArchive(mediaPath + "irrlicht.dat");

	video::IVideoDriver* driver = MenuDevice->getVideoDriver();
	scene::ISceneManager* smgr = MenuDevice->getSceneManager();
	gui::IGUIEnvironment* guienv = MenuDevice->getGUIEnvironment();

	core::stringw str = "Irrlicht Engine Demo v";
	str += MenuDevice->getVersion();
	MenuDevice->setWindowCaption(str.c_str());

	// set new Skin
	gui::IGUISkin* newskin = guienv->createSkin(gui::EGST_BURNING_SKIN);
	guienv->setSkin(newskin);
	newskin->drop();

	// load font
	gui::IGUIFont* font = guienv->getFont(mediaPath + "fonthaettenschweiler.bmp");
	if (font)
		guienv->getSkin()->setFont(font);

	// add images

	const s32 leftX = 260;

	// add tab control
	gui::IGUITabControl* tabctrl = guienv->addTabControl(core::rect<int>(leftX,10,512-10,384-10),
		0, true, true);
	gui::IGUITab* optTab = tabctrl->addTab(L"Demo");
	gui::IGUITab* aboutTab = tabctrl->addTab(L"About");

	// add list box

	gui::IGUIListBox* box = guienv->addListBox(core::rect<int>(10,10,220,120), optTab, 1);
	box->addItem(L"OpenGL 1.5");
	box->addItem(L"Direct3D 9.0c");
	box->addItem(L"Burning's Video 0.47");
	box->addItem(L"Irrlicht Software Renderer 1.0");
	switch (driverType )
	{
		case video::EDT_OPENGL:        selected = 0; break;
		case video::EDT_DIRECT3D9:     selected = 1; break;
		case video::EDT_BURNINGSVIDEO: selected = 2; break;
		case video::EDT_SOFTWARE:      selected = 3; break;
		default: break;
	}
	box->setSelected(selected);

	// add button

	startButton = guienv->addButton(core::rect<int>(30,295,200,324), optTab, 2, L"Start Demo");

	// add checkbox

	const s32 d = 50;

	guienv->addCheckBox(fullscreen, core::rect<int>(20,85+d,130,110+d),
		optTab, 3, L"Fullscreen");
	guienv->addCheckBox(music, core::rect<int>(135,85+d,245,110+d),
		optTab, 4, L"Music & Sfx");
	guienv->addCheckBox(shadows, core::rect<int>(20,110+d,135,135+d),
		optTab, 5, L"Realtime shadows");
	guienv->addCheckBox(additive, core::rect<int>(20,135+d,230,160+d),
		optTab, 6, L"Old HW compatible blending");
	guienv->addCheckBox(vsync, core::rect<int>(20,160+d,230,185+d),
		optTab, 7, L"Vertical synchronisation");
	guienv->addCheckBox(aa, core::rect<int>(20,185+d,230,210+d),
		optTab, 8, L"Antialiasing");

	// add about text

	const wchar_t* text2 = L"This is the tech demo of the Irrlicht engine. To start, "\
		L"select a video driver which works best with your hardware and press 'Start Demo'.\n"\
		L"What you currently see is displayed using the Burning Software Renderer (Thomas Alten).\n"\
		L"The Irrlicht Engine was written by me, Nikolaus Gebhardt. The models, "\
		L"maps and textures were placed at my disposal by B.Collins, M.Cook and J.Marton. The music was created by "\
		L"M.Rohde and is played back by irrKlang.\n"\
		L"For more information, please visit the homepage of the Irrlicht engine:\nhttp://irrlicht.sourceforge.net";

	guienv->addStaticText(text2, core::rect<int>(10, 10, 230, 320),
		true, true, aboutTab);

	// add md2 model

	scene::IAnimatedMesh* mesh = smgr->getMesh(mediaPath + "faerie.md2");
	scene::IAnimatedMeshSceneNode* modelNode = smgr->addAnimatedMeshSceneNode(mesh);
	if (modelNode)
	{
		modelNode->setPosition( core::vector3df(0.f, 0.f, -5.f) );
		modelNode->setMaterialTexture(0, driver->getTexture(mediaPath + "faerie2.bmp"));
		modelNode->setMaterialFlag(video::EMF_LIGHTING, true);
		modelNode->getMaterial(0).Shininess = 50.f;
		modelNode->getMaterial(0).NormalizeNormals = true;
		modelNode->setMD2Animation(scene::EMAT_STAND);
	}

	// set ambient light (no sun light in the catacombs)
	smgr->setAmbientLight( video::SColorf(0.2f, 0.2f, 0.2f) );

	scene::ILightSceneNode *light;
	scene::ISceneNodeAnimator* anim;
	scene::ISceneNode* bill;

	enum eLightParticle
	{
		LIGHT_NONE,
		LIGHT_GLOBAL,
		LIGHT_RED,
		LIGHT_BLUE
	};
	core::vector3df lightDir[2] = {
		core::vector3df(0.f, 0.1f, 0.4f),
		core::vector3df(0.f, 0.1f, -0.4f),
	};

	struct SLightParticle
	{
		eLightParticle type;
		u32 dir;
	};
	const SLightParticle lightParticle[] =
	{
		//LIGHT_GLOBAL,0,
		{LIGHT_RED,0},
		{LIGHT_BLUE,0},
		{LIGHT_RED,1},
		{LIGHT_BLUE,1},
		{LIGHT_NONE,0}
	};

	const SLightParticle *l = lightParticle;
	while ( l->type != LIGHT_NONE )
	{
		switch ( l->type )
		{
			case LIGHT_GLOBAL:
				// add illumination from the background
				light = smgr->addLightSceneNode(0, core::vector3df(10.f,40.f,-5.f),
					video::SColorf(0.2f, 0.2f, 0.2f), 90.f);
				break;
			case LIGHT_RED:
				// add light nearly red
				light = smgr->addLightSceneNode(0, core::vector3df(0,1,0),
					video::SColorf(0.8f, 0.f, 0.f, 0.0f), 30.0f);
				// attach red billboard to the light
				bill = smgr->addBillboardSceneNode(light, core::dimension2d<f32>(10, 10));
				if ( bill )
				{
					bill->setMaterialFlag(video::EMF_LIGHTING, false);
					bill->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR);
					bill->setMaterialTexture(0, driver->getTexture(mediaPath + "particlered.bmp"));
				}
				// add fly circle animator to the light
				anim = smgr->createFlyCircleAnimator(core::vector3df(0.f,0.f,-5.f),20.f,
					0.002f, lightDir [l->dir] );
				light->addAnimator(anim);
				anim->drop();
				break;
			case LIGHT_BLUE:
				// add light nearly blue
				light = smgr->addLightSceneNode(0, core::vector3df(0,1,0),
					video::SColorf(0.f, 0.0f, 0.8f, 0.0f), 30.0f);
				// attach blue billboard to the light
				bill = smgr->addBillboardSceneNode(light, core::dimension2d<f32>(10, 10));
				if (bill)
				{
					bill->setMaterialFlag(video::EMF_LIGHTING, false);
					bill->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR);
					bill->setMaterialTexture(0, driver->getTexture(mediaPath + "portal1.bmp"));
				}
				// add fly circle animator to the light
				anim = smgr->createFlyCircleAnimator(core::vector3df(0.f,0.f,-5.f),20.f,
					-0.002f, lightDir [l->dir], 0.5f);
				light->addAnimator(anim);
				anim->drop();
				break;
			case LIGHT_NONE:
				break;
		}
		l += 1;
	}

	// create a fixed camera
	smgr->addCameraSceneNode(0, core::vector3df(45,0,0), core::vector3df(0,0,10));


	// irrlicht logo and background
	// add irrlicht logo
	bool oldMipMapState = driver->getTextureCreationFlag(video::ETCF_CREATE_MIP_MAPS);
	driver->setTextureCreationFlag(video::ETCF_CREATE_MIP_MAPS, false);

	guienv->addImage(driver->getTexture(mediaPath + "irrlichtlogo3.png"),
		core::position2d<s32>(5,5));

	video::ITexture* irrlichtBack = driver->getTexture(mediaPath + "demoback.jpg");

	driver->setTextureCreationFlag(video::ETCF_CREATE_MIP_MAPS, oldMipMapState);

	// query original skin color
	getOriginalSkinColor();

	// set transparency
	setTransparency();

	// draw all

	while(MenuDevice->run())
	{
		if (MenuDevice->isWindowActive())
		{
			driver->beginScene(video::ECBF_DEPTH, video::SColor(0,0,0,0));

			if (irrlichtBack)
				driver->draw2DImage(irrlichtBack,
						core::position2d<int>(0,0));

			smgr->drawAll();
			guienv->drawAll();
			driver->endScene();
		}
	}

	MenuDevice->drop();

	switch(selected)
	{
	case 0:	driverType = video::EDT_OPENGL; break;
	case 1:	driverType = video::EDT_DIRECT3D9; break;
	case 2:	driverType = video::EDT_BURNINGSVIDEO; break;
	case 3:	driverType = video::EDT_SOFTWARE; break;
	}

	return start;
}


bool CMainMenu::OnEvent(const SEvent& event)
{
	if (event.EventType == EET_KEY_INPUT_EVENT &&
		event.KeyInput.Key == KEY_F9 &&
		event.KeyInput.PressedDown == false)
	{
		video::IImage* image = MenuDevice->getVideoDriver()->createScreenShot();
		if (image)
		{
			MenuDevice->getVideoDriver()->writeImageToFile(image, "screenshot_main.jpg");
			image->drop();
		}
	}
	else
	if (event.EventType == irr::EET_MOUSE_INPUT_EVENT &&
		event.MouseInput.Event == EMIE_RMOUSE_LEFT_UP )
	{
		core::rect<s32> r(event.MouseInput.X, event.MouseInput.Y, 0, 0);
		gui::IGUIContextMenu* menu = MenuDevice->getGUIEnvironment()->addContextMenu(r, 0, 45);
		menu->addItem(L"transparent menus", 666, transparent == false);
		menu->addItem(L"solid menus", 666, transparent == true);
		menu->addSeparator();
		menu->addItem(L"Cancel");
	}
	else
	if (event.EventType == EET_GUI_EVENT)
	{
		s32 id = event.GUIEvent.Caller->getID();
		switch(id)
		{
		case 45: // context menu
			if (event.GUIEvent.EventType == gui::EGET_MENU_ITEM_SELECTED)
			{
				s32 s = ((gui::IGUIContextMenu*)event.GUIEvent.Caller)->getSelectedItem();
				if (s == 0 || s == 1)
				{
					transparent = !transparent;
					setTransparency();
				}
			}
			break;
		case 1:
			if (event.GUIEvent.EventType == gui::EGET_LISTBOX_CHANGED ||
				event.GUIEvent.EventType == gui::EGET_LISTBOX_SELECTED_AGAIN)
			{
				selected = ((gui::IGUIListBox*)event.GUIEvent.Caller)->getSelected();
				//startButton->setEnabled(selected != 4);
				startButton->setEnabled(true);
			}
			break;
		case 2:
			if (event.GUIEvent.EventType == gui::EGET_BUTTON_CLICKED )
			{
				MenuDevice->closeDevice();
				start = true;
			}
		case 3:
			if (event.GUIEvent.EventType == gui::EGET_CHECKBOX_CHANGED )
				fullscreen = ((gui::IGUICheckBox*)event.GUIEvent.Caller)->isChecked();
			break;
		case 4:
			if (event.GUIEvent.EventType == gui::EGET_CHECKBOX_CHANGED )
				music = ((gui::IGUICheckBox*)event.GUIEvent.Caller)->isChecked();
			break;
		case 5:
			if (event.GUIEvent.EventType == gui::EGET_CHECKBOX_CHANGED )
				shadows = ((gui::IGUICheckBox*)event.GUIEvent.Caller)->isChecked();
			break;
		case 6:
			if (event.GUIEvent.EventType == gui::EGET_CHECKBOX_CHANGED )
				additive = ((gui::IGUICheckBox*)event.GUIEvent.Caller)->isChecked();
			break;
		case 7:
			if (event.GUIEvent.EventType == gui::EGET_CHECKBOX_CHANGED )
				vsync = ((gui::IGUICheckBox*)event.GUIEvent.Caller)->isChecked();
			break;
		case 8:
			if (event.GUIEvent.EventType == gui::EGET_CHECKBOX_CHANGED )
				aa = ((gui::IGUICheckBox*)event.GUIEvent.Caller)->isChecked();
			break;
		}
	}

	return false;
}


void CMainMenu::getOriginalSkinColor()
{
	irr::gui::IGUISkin * skin = MenuDevice->getGUIEnvironment()->getSkin();
	for (s32 i=0; i<gui::EGDC_COUNT ; ++i)
	{
		SkinColor[i] = skin->getColor( (gui::EGUI_DEFAULT_COLOR)i );
	}

}


void CMainMenu::setTransparency()
{
	irr::gui::IGUISkin * skin = MenuDevice->getGUIEnvironment()->getSkin();

	for (u32 i=0; i<gui::EGDC_COUNT ; ++i)
	{
		video::SColor col = SkinColor[i];

		if (false == transparent)
			col.setAlpha(255);

		skin->setColor((gui::EGUI_DEFAULT_COLOR)i, col);
	}
}

