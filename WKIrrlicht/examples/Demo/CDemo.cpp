// This is a Demo of the Irrlicht Engine (c) 2005-2009 by N.Gebhardt.
// This file is not documented.

#include "CDemo.h"
#include "exampleHelper.h"

CDemo::CDemo(bool f, bool m, bool s, bool a, bool v, bool fsaa, video::E_DRIVER_TYPE d)
: fullscreen(f), music(m), shadows(s), additive(a), vsync(v), aa(fsaa),
 driverType(d), device(0),
#ifdef USE_IRRKLANG
	irrKlang(0), ballSound(0), impactSound(0),
#endif
#ifdef USE_SDL_MIXER
	stream(0), ballSound(0), impactSound(0),
#endif
 currentScene(-2), backColor(0), statusText(0), inOutFader(0),
 quakeLevelMesh(0), quakeLevelNode(0), skyboxNode(0), model1(0), model2(0),
 campFire(0), metaSelector(0), mapSelector(0), sceneStartTime(0),
 timeForThisScene(0)
{
}


CDemo::~CDemo()
{
	if (mapSelector)
		mapSelector->drop();

	if (metaSelector)
		metaSelector->drop();

#ifdef USE_IRRKLANG
	if (irrKlang)
		irrKlang->drop();
#endif
}


void CDemo::run()
{
	core::dimension2d<u32> resolution (800, 600);

	if ( driverType == video::EDT_BURNINGSVIDEO || driverType == video::EDT_SOFTWARE )
	{
		resolution.Width = 640;
		resolution.Height = 480;
	}

	irr::SIrrlichtCreationParameters params;
	params.DriverType=driverType;
	params.WindowSize=resolution;
	params.Bits=32;
	params.Fullscreen=fullscreen;
	params.Stencilbuffer=shadows;
	params.Vsync=vsync;
	params.AntiAlias=aa?8:0;
	params.EventReceiver=this;

	device = createDeviceEx(params);
	if (!device)
		return;

	const io::path mediaPath = getExampleMediaPath();

	if (device->getFileSystem()->existFile("irrlicht.dat"))
		device->getFileSystem()->addFileArchive("irrlicht.dat");
	else
		device->getFileSystem()->addFileArchive(mediaPath + "irrlicht.dat");
	if (device->getFileSystem()->existFile("map-20kdm2.pk3"))
		device->getFileSystem()->addFileArchive("map-20kdm2.pk3");
	else
		device->getFileSystem()->addFileArchive(mediaPath + "map-20kdm2.pk3");

	video::IVideoDriver* driver = device->getVideoDriver();
	scene::ISceneManager* smgr = device->getSceneManager();
	gui::IGUIEnvironment* guienv = device->getGUIEnvironment();

	device->setWindowCaption(L"Irrlicht Engine Demo");

	// set ambient light
	smgr->setAmbientLight ( video::SColorf ( 0x00c0c0c0 ) );

	wchar_t tmp[255];

	// draw everything

	s32 now = 0;
	s32 lastfps = 0;
	sceneStartTime = device->getTimer()->getTime();
	while(device->run() && driver)
	{
		if (device->isWindowActive())
		{
			#ifdef USE_IRRKLANG
			// update 3D position for sound engine
			scene::ICameraSceneNode* cam = smgr->getActiveCamera();
			if (cam && irrKlang)
				irrKlang->setListenerPosition(cam->getAbsolutePosition(), cam->getTarget());
			#endif

			// load next scene if necessary
			now = device->getTimer()->getTime();
			if (now - sceneStartTime > timeForThisScene && timeForThisScene!=-1)
				switchToNextScene();

			createParticleImpacts();

			u16 clearFlag = video::ECBF_DEPTH;

			if (timeForThisScene != -1)
				clearFlag |= video::ECBF_COLOR;

			driver->beginScene(clearFlag, backColor);

			smgr->drawAll();
			guienv->drawAll();
			driver->endScene();

			// write statistics
			const s32 nowfps = driver->getFPS();

			swprintf_irr(tmp, 255, L"%ls fps:%3d triangles:%0.3f mio/s",
						driver->getName(), driver->getFPS(),
						driver->getPrimitiveCountDrawn(1) * (1.f / 1000000.f));

			statusText->setText(tmp);
			if ( nowfps != lastfps )
			{
				device->setWindowCaption(tmp);
				lastfps = nowfps;
			}
		}
	}

	device->drop();
}


bool CDemo::OnEvent(const SEvent& event)
{
	if (!device)
		return false;

	if (event.EventType == EET_KEY_INPUT_EVENT &&
		event.KeyInput.Key == KEY_ESCAPE &&
		event.KeyInput.PressedDown == false)
	{
		// user wants to quit.
		if (currentScene < 3)
			timeForThisScene = 0;
		else
			device->closeDevice();
	}
	else
	if (((event.EventType == EET_KEY_INPUT_EVENT &&
		event.KeyInput.Key == KEY_SPACE &&
		event.KeyInput.PressedDown == false) ||
		(event.EventType == EET_MOUSE_INPUT_EVENT &&
		 event.MouseInput.Event == EMIE_LMOUSE_LEFT_UP)) &&
		currentScene == 3)
	{
		// shoot
		shoot();
	}
	else
	if (event.EventType == EET_KEY_INPUT_EVENT &&
		event.KeyInput.Key == KEY_F9 &&
		event.KeyInput.PressedDown == false)
	{
		video::IImage* image = device->getVideoDriver()->createScreenShot();
		if (image)
		{
			device->getVideoDriver()->writeImageToFile(image, "screenshot.bmp");
			device->getVideoDriver()->writeImageToFile(image, "screenshot.png");
			device->getVideoDriver()->writeImageToFile(image, "screenshot.tga");
			device->getVideoDriver()->writeImageToFile(image, "screenshot.ppm");
			device->getVideoDriver()->writeImageToFile(image, "screenshot.jpg");
			device->getVideoDriver()->writeImageToFile(image, "screenshot.pcx");
			image->drop();
		}
	}
	else
	if (device->getSceneManager()->getActiveCamera())
	{
		device->getSceneManager()->getActiveCamera()->OnEvent(event);
		return true;
	}

	return false;
}


void CDemo::switchToNextScene()
{
	currentScene++;
	if (currentScene > 3)
		currentScene = 1;

	scene::ISceneManager* sm = device->getSceneManager();
	scene::ISceneNodeAnimator* sa = 0;
	scene::ICameraSceneNode* camera = 0;

	camera = sm->getActiveCamera();
	if (camera)
	{
		sm->setActiveCamera(0);
		camera->remove();
		camera = 0;
	}

	switch(currentScene)
	{
	case -1: // loading screen
		timeForThisScene = 0;
		createLoadingScreen();
		break;

	case 0: // load scene
		timeForThisScene = 0;
		loadSceneData();
		break;

	case 1: // panorama camera
		{
			currentScene += 1;
			//camera = sm->addCameraSceneNode(0, core::vector3df(0,0,0), core::vector3df(-586,708,52));
			//camera->setTarget(core::vector3df(0,400,0));

			core::array<core::vector3df> points;

			points.push_back(core::vector3df(-931.473755f, 138.300003f, 987.279114f)); // -49873
			points.push_back(core::vector3df(-847.902222f, 136.757553f, 915.792725f)); // -50559
			points.push_back(core::vector3df(-748.680420f, 152.254501f, 826.418945f)); // -51964
			points.push_back(core::vector3df(-708.428406f, 213.569580f, 784.466675f)); // -53251
			points.push_back(core::vector3df(-686.217651f, 288.141174f, 762.965576f)); // -54015
			points.push_back(core::vector3df(-679.685059f, 365.095612f, 756.551453f)); // -54733
			points.push_back(core::vector3df(-671.317871f, 447.360107f, 749.394592f)); // -55588
			points.push_back(core::vector3df(-669.468445f, 583.335632f, 747.711853f)); // -56178
			points.push_back(core::vector3df(-667.611267f, 727.313232f, 746.018250f)); // -56757
			points.push_back(core::vector3df(-665.853210f, 862.791931f, 744.436096f)); // -57859
			points.push_back(core::vector3df(-642.649597f, 1026.047607f, 724.259827f)); // -59705
			points.push_back(core::vector3df(-517.793884f, 838.396790f, 490.326050f)); // -60983
			points.push_back(core::vector3df(-474.387299f, 715.691467f, 344.639984f)); // -61629
			points.push_back(core::vector3df(-444.600250f, 601.155701f, 180.938095f)); // -62319
			points.push_back(core::vector3df(-414.808899f, 479.691406f, 4.866660f)); // -63048
			points.push_back(core::vector3df(-410.418945f, 429.642242f, -134.332687f)); // -63757
			points.push_back(core::vector3df(-399.837585f, 411.498383f, -349.350983f)); // -64418
			points.push_back(core::vector3df(-390.756653f, 403.970093f, -524.454407f)); // -65005
			points.push_back(core::vector3df(-334.864227f, 350.065491f, -732.397400f)); // -65701
			points.push_back(core::vector3df(-195.253387f, 349.577209f, -812.475891f)); // -66335
			points.push_back(core::vector3df(16.255573f, 363.743134f, -833.800415f)); // -67170
			points.push_back(core::vector3df(234.940964f, 352.957825f, -820.150696f)); // -67939
			points.push_back(core::vector3df(436.797668f, 349.236450f, -816.914185f)); // -68596
			points.push_back(core::vector3df(575.236206f, 356.244812f, -719.788513f)); // -69166
			points.push_back(core::vector3df(594.131042f, 387.173828f, -609.675598f)); // -69744
			points.push_back(core::vector3df(617.615234f, 412.002899f, -326.174072f)); // -70640
			points.push_back(core::vector3df(606.456848f, 403.221954f, -104.179291f)); // -71390
			points.push_back(core::vector3df(610.958252f, 407.037750f, 117.209778f)); // -72085
			points.push_back(core::vector3df(597.956909f, 395.167877f, 345.942200f)); // -72817
			points.push_back(core::vector3df(587.383118f, 391.444519f, 566.098633f)); // -73477
			points.push_back(core::vector3df(559.572449f, 371.991333f, 777.689453f)); // -74124
			points.push_back(core::vector3df(423.753204f, 329.990051f, 925.859741f)); // -74941
			points.push_back(core::vector3df(247.520050f, 252.818954f, 935.311829f)); // -75651
			points.push_back(core::vector3df(114.756012f, 199.799759f, 805.014160f));
			points.push_back(core::vector3df(96.783348f, 181.639481f, 648.188110f));
			points.push_back(core::vector3df(97.865623f, 138.905975f, 484.812561f));
			points.push_back(core::vector3df(99.612457f, 102.463669f, 347.603210f));
			points.push_back(core::vector3df(99.612457f, 102.463669f, 347.603210f));
			points.push_back(core::vector3df(99.612457f, 102.463669f, 347.603210f));

			timeForThisScene = (points.size()-3)* 1000;

			camera = sm->addCameraSceneNode(0, points[0], core::vector3df(0 ,400,0));
			//camera->setTarget(core::vector3df(0,400,0));

			sa = sm->createFollowSplineAnimator(device->getTimer()->getTime(),
				points);
			camera->addAnimator(sa);
			sa->drop();

			model1->setVisible(false);
			model2->setVisible(false);
			campFire->setVisible(false);
			inOutFader->fadeIn(7000);
		}
		break;

	case 2:	// down fly anim camera
		camera = sm->addCameraSceneNode(0, core::vector3df(100,40,-80), core::vector3df(844,670,-885));
		sa = sm->createFlyStraightAnimator(core::vector3df(94, 1002, 127),
			core::vector3df(108, 15, -60), 10000, true);
		camera->addAnimator(sa);
		timeForThisScene = 9900;
		model1->setVisible(true);
		model2->setVisible(false);
		campFire->setVisible(false);
		sa->drop();
		break;

	case 3: // interactive, go around
		{
			model1->setVisible(true);
			model2->setVisible(true);
			campFire->setVisible(true);
			timeForThisScene = -1;

			core::array<SKeyMap> keyMap(11);

			keyMap.push_back( SKeyMap(EKA_MOVE_FORWARD, KEY_UP) );
			keyMap.push_back( SKeyMap(EKA_MOVE_FORWARD, KEY_KEY_W) );

			keyMap.push_back( SKeyMap(EKA_MOVE_BACKWARD, KEY_DOWN) );
			keyMap.push_back( SKeyMap(EKA_MOVE_BACKWARD, KEY_KEY_S) );

			keyMap.push_back( SKeyMap(EKA_STRAFE_LEFT, KEY_LEFT) );
			keyMap.push_back( SKeyMap(EKA_STRAFE_LEFT, KEY_KEY_A) );

			keyMap.push_back( SKeyMap(EKA_STRAFE_RIGHT, KEY_RIGHT) );
			keyMap.push_back( SKeyMap(EKA_STRAFE_RIGHT, KEY_KEY_D) );

			keyMap.push_back( SKeyMap(EKA_JUMP_UP, KEY_KEY_J) );

			keyMap.push_back( SKeyMap(EKA_ROTATE_LEFT, KEY_KEY_Q) );

			keyMap.push_back( SKeyMap(EKA_ROTATE_RIGHT, KEY_KEY_E) );

			camera = sm->addCameraSceneNodeFPS(0, 100.0f, .4f, -1, keyMap.pointer(), keyMap.size(), false, 300.f);
			camera->setPosition(core::vector3df(108,140,-140));
			camera->setFarValue(5000.0f);

			scene::ISceneNodeAnimatorCollisionResponse* collider =
				sm->createCollisionResponseAnimator(
				metaSelector, camera, core::vector3df(25,50,25),
				core::vector3df(0, quakeLevelMesh ? -1000.f : 0.0f,0),
					core::vector3df(0,45,0), 0.005f);

			camera->addAnimator(collider);
			collider->drop();
		}
		break;
	}

	sceneStartTime = device->getTimer()->getTime();
}


void CDemo::loadSceneData()
{
	// load quake level

	video::IVideoDriver* driver = device->getVideoDriver();
	scene::ISceneManager* sm = device->getSceneManager();

	// Quake3 Shader controls Z-Writing
	sm->getParameters()->setAttribute(scene::ALLOW_ZWRITE_ON_TRANSPARENT, true);

	quakeLevelMesh = (scene::IQ3LevelMesh*) sm->getMesh("maps/20kdm2.bsp");

	if (quakeLevelMesh)
	{
		u32 i;

		//move all quake level meshes (non-realtime)
		core::matrix4 m;
		m.setTranslation(core::vector3df(-1300,-70,-1249));

		for ( i = 0; i != scene::quake3::E_Q3_MESH_SIZE; ++i )
			sm->getMeshManipulator()->transform(quakeLevelMesh->getMesh(i), m);

		quakeLevelNode = sm->addOctreeSceneNode(
				quakeLevelMesh->getMesh( scene::quake3::E_Q3_MESH_GEOMETRY));
		if (quakeLevelNode)
		{
			//quakeLevelNode->setPosition(core::vector3df(-1300,-70,-1249));
			quakeLevelNode->setVisible(true);

			// create map triangle selector
			mapSelector = sm->createOctreeTriangleSelector(quakeLevelMesh->getMesh(0),
				quakeLevelNode, 128);

			// if not using shader and no gamma it's better to use more lighting, because
			// quake3 level are usually dark
			quakeLevelNode->setMaterialType ( video::EMT_LIGHTMAP_M4 );

			// set additive blending if wanted
			if (additive)
				quakeLevelNode->setMaterialType(video::EMT_LIGHTMAP_ADD);
		}

		// the additional mesh can be quite huge and is unoptimized
		scene::IMesh * additional_mesh = quakeLevelMesh->getMesh ( scene::quake3::E_Q3_MESH_ITEMS );

		for ( i = 0; i!= additional_mesh->getMeshBufferCount (); ++i )
		{
			scene::IMeshBuffer *meshBuffer = additional_mesh->getMeshBuffer ( i );
			const video::SMaterial &material = meshBuffer->getMaterial();

			//! The ShaderIndex is stored in the material parameter
			s32 shaderIndex = (s32) material.MaterialTypeParam2;

			// the meshbuffer can be rendered without additional support, or it has no shader
			const scene::quake3::IShader *shader = quakeLevelMesh->getShader ( shaderIndex );
			if ( 0 == shader )
			{
				continue;
			}
			// Now add the MeshBuffer(s) with the current Shader to the Manager
			sm->addQuake3SceneNode ( meshBuffer, shader );
		}
	}

	const io::path mediaPath = getExampleMediaPath();

	// load sydney model and create 2 instances

	scene::IAnimatedMesh* mesh = 0;
	mesh = sm->getMesh(mediaPath + "sydney.md2");
	if (mesh)
	{
		model1 = sm->addAnimatedMeshSceneNode(mesh);
		if (model1)
		{
			model1->setMaterialTexture(0, driver->getTexture(mediaPath + "spheremap.jpg"));
			model1->setPosition(core::vector3df(100,40,-80));
			model1->setScale(core::vector3df(2,2,2));
			model1->setMD2Animation(scene::EMAT_STAND);
			model1->setMaterialFlag(video::EMF_LIGHTING, false);
			model1->setMaterialFlag(video::EMF_NORMALIZE_NORMALS, true);
			model1->setMaterialType(video::EMT_SPHERE_MAP);
			model1->addShadowVolumeSceneNode();
		}

		model2 = sm->addAnimatedMeshSceneNode(mesh);
		if (model2)
		{
			model2->setPosition(core::vector3df(180,15,-60));
			model2->setScale(core::vector3df(2,2,2));
			model2->setMD2Animation(scene::EMAT_RUN);
			model2->setMaterialTexture(0, device->getVideoDriver()->getTexture(mediaPath + "sydney.bmp"));
			model2->setMaterialFlag(video::EMF_LIGHTING, true);
			model2->setMaterialFlag(video::EMF_NORMALIZE_NORMALS, true);
			model2->addShadowVolumeSceneNode();
		}
	}

	scene::ISceneNodeAnimator* anim = 0;

	// create sky box
	driver->setTextureCreationFlag(video::ETCF_CREATE_MIP_MAPS, false);
	skyboxNode = sm->addSkyBoxSceneNode(
		driver->getTexture(mediaPath + "irrlicht2_up.jpg"),
		driver->getTexture(mediaPath + "irrlicht2_dn.jpg"),
		driver->getTexture(mediaPath + "irrlicht2_lf.jpg"),
		driver->getTexture(mediaPath + "irrlicht2_rt.jpg"),
		driver->getTexture(mediaPath + "irrlicht2_ft.jpg"),
		driver->getTexture(mediaPath + "irrlicht2_bk.jpg"));
	driver->setTextureCreationFlag(video::ETCF_CREATE_MIP_MAPS, true);

	// create walk-between-portals animation

	core::vector3df waypoint[2];
	waypoint[0].set(-150,40,100);
	waypoint[1].set(350,40,100);

	if (model2)
	{
		anim = device->getSceneManager()->createFlyStraightAnimator(
			waypoint[0], waypoint[1], 2000, true);
		model2->addAnimator(anim);
		anim->drop();
	}

	// create animation for portals;

	core::array<video::ITexture*> textures;
	for (s32 g=1; g<8; ++g)
	{
		core::stringc tmp(mediaPath + "portal");
		tmp += g;
		tmp += ".bmp";
		video::ITexture* t = driver->getTexture( tmp );
		textures.push_back(t);
	}

	anim = sm->createTextureAnimator(textures, 100);

	// create portals

	scene::IBillboardSceneNode* bill = 0;

	for (int r=0; r<2; ++r)
	{
		bill = sm->addBillboardSceneNode(0, core::dimension2d<f32>(100,100),
			waypoint[r]+ core::vector3df(0,20,0));
		bill->setMaterialFlag(video::EMF_LIGHTING, false);
		bill->setMaterialTexture(0, driver->getTexture(mediaPath + "portal1.bmp"));
		bill->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR);
		bill->addAnimator(anim);
	}

	anim->drop();

	// create cirlce flying dynamic light with transparent billboard attached

	scene::ILightSceneNode* light = 0;

	light = sm->addLightSceneNode(0,
		core::vector3df(0,0,0),	video::SColorf(1.0f, 1.0f, 1.f, 1.0f), 500.f);

	anim = sm->createFlyCircleAnimator(
		core::vector3df(100,150,80), 80.0f, 0.0005f);

	light->addAnimator(anim);
	anim->drop();

	bill = device->getSceneManager()->addBillboardSceneNode(
		light, core::dimension2d<f32>(40,40));
	bill->setMaterialFlag(video::EMF_LIGHTING, false);
	bill->setMaterialTexture(0, driver->getTexture(mediaPath + "particlewhite.bmp"));
	bill->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR);

	// create meta triangle selector with all triangles selectors in it.
	metaSelector = sm->createMetaTriangleSelector();
	metaSelector->addTriangleSelector(mapSelector);

	// create camp fire

	campFire = sm->addParticleSystemSceneNode(false);
	campFire->setPosition(core::vector3df(100,120,600));
	campFire->setScale(core::vector3df(2,2,2));

	scene::IParticleEmitter* em = campFire->createBoxEmitter(
		core::aabbox3d<f32>(-7,0,-7,7,1,7),
		core::vector3df(0.0f,0.06f,0.0f),
		80,100, video::SColor(1,255,255,255),video::SColor(1,255,255,255), 800,2000);

	em->setMinStartSize(core::dimension2d<f32>(20.0f, 10.0f));
	em->setMaxStartSize(core::dimension2d<f32>(20.0f, 10.0f));
	campFire->setEmitter(em);
	em->drop();

	scene::IParticleAffector* paf = campFire->createFadeOutParticleAffector();
	campFire->addAffector(paf);
	paf->drop();

	campFire->setMaterialFlag(video::EMF_LIGHTING, false);
	campFire->setMaterialFlag(video::EMF_ZWRITE_ENABLE, false);
	campFire->setMaterialTexture(0, driver->getTexture(mediaPath + "fireball.bmp"));
	campFire->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR);

	// load music

	#ifdef USE_IRRKLANG
	if (music)
		startIrrKlang();
	#endif
	#ifdef USE_SDL_MIXER
	if (music)
		startSound();
	#endif
}


void CDemo::createLoadingScreen()
{
	core::dimension2d<u32> size = device->getVideoDriver()->getScreenSize();

	device->getCursorControl()->setVisible(false);

	// setup loading screen

	backColor.set(255,90,90,156);

	// create in fader

	inOutFader = device->getGUIEnvironment()->addInOutFader();
	inOutFader->setColor(backColor,	video::SColor ( 0, 230, 230, 230 ));

	const io::path mediaPath = getExampleMediaPath();

	// irrlicht logo
	device->getGUIEnvironment()->addImage(device->getVideoDriver()->getTexture(mediaPath + "irrlichtlogo2.png"),
		core::position2d<s32>(5,5));

	// loading text

	const int lwidth = size.Width - 20;
	const int lheight = 16;

	core::rect<int> pos(10, size.Height-lheight-10, 10+lwidth, size.Height-10);

	device->getGUIEnvironment()->addImage(pos);
	statusText = device->getGUIEnvironment()->addStaticText(L"Loading...",	pos, true);
	statusText->setOverrideColor(video::SColor(255,205,200,200));

	// load bigger font

	device->getGUIEnvironment()->getSkin()->setFont(
		device->getGUIEnvironment()->getFont(mediaPath + "fonthaettenschweiler.bmp"));

	// set new font color

	device->getGUIEnvironment()->getSkin()->setColor(gui::EGDC_BUTTON_TEXT,
		video::SColor(255,100,100,100));
}


void CDemo::shoot()
{
	scene::ISceneManager* sm = device->getSceneManager();
	scene::ICameraSceneNode* camera = sm->getActiveCamera();

	if (!camera || !mapSelector)
		return;

	SParticleImpact imp;
	imp.when = 0;

	// get line of camera

	core::vector3df start = camera->getPosition();
	core::vector3df end = (camera->getTarget() - start);
	end.normalize();
	start += end*8.0f;
	end = start + (end * camera->getFarValue());

	core::triangle3df triangle;

	core::line3d<f32> line(start, end);

	// get intersection point with map
	scene::ISceneNode* hitNode;
	if (sm->getSceneCollisionManager()->getCollisionPoint(
		line, mapSelector, end, triangle, hitNode))
	{
		// collides with wall
		core::vector3df out = triangle.getNormal();
		out.setLength(0.03f);

		imp.when = 1;
		imp.outVector = out;
		imp.pos = end;
	}
	else
	{
		// doesnt collide with wall
		core::vector3df start = camera->getPosition();
		core::vector3df end = (camera->getTarget() - start);
		end.normalize();
		start += end*8.0f;
		end = start + (end * camera->getFarValue());
	}

	// create fire ball
	scene::ISceneNode* node = 0;
	node = sm->addBillboardSceneNode(0,
		core::dimension2d<f32>(25,25), start);

	node->setMaterialFlag(video::EMF_LIGHTING, false);
	node->setMaterialTexture(0, device->getVideoDriver()->getTexture(getExampleMediaPath() + "fireball.bmp"));
	node->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR);

	f32 length = (f32)(end - start).getLength();
	const f32 speed = 0.6f;
	u32 time = (u32)(length / speed);

	scene::ISceneNodeAnimator* anim = 0;

	// set flight line

	anim = sm->createFlyStraightAnimator(start, end, time);
	node->addAnimator(anim);
	anim->drop();

	anim = sm->createDeleteAnimator(time);
	node->addAnimator(anim);
	anim->drop();

	if (imp.when)
	{
		// create impact note
		imp.when = device->getTimer()->getTime() + (time - 100);
		Impacts.push_back(imp);
	}

	// play sound
	#ifdef USE_IRRKLANG
	if (ballSound)
		irrKlang->play2D(ballSound);
	#endif
	#ifdef USE_SDL_MIXER
	if (ballSound)
		playSound(ballSound);
	#endif
}


void CDemo::createParticleImpacts()
{
	u32 now = device->getTimer()->getTime();
	scene::ISceneManager* sm = device->getSceneManager();

	for (s32 i=0; i<(s32)Impacts.size(); ++i)
		if (now > Impacts[i].when)
		{
			// create smoke particle system
			scene::IParticleSystemSceneNode* pas = 0;

			pas = sm->addParticleSystemSceneNode(false, 0, -1, Impacts[i].pos);

			pas->setParticleSize(core::dimension2d<f32>(10.0f, 10.0f));

			scene::IParticleEmitter* em = pas->createBoxEmitter(
				core::aabbox3d<f32>(-5,-5,-5,5,5,5),
				Impacts[i].outVector, 20,40, video::SColor(50,255,255,255),video::SColor(50,255,255,255),
				1200,1600, 20);

			pas->setEmitter(em);
			em->drop();

			scene::IParticleAffector* paf = campFire->createFadeOutParticleAffector();
			pas->addAffector(paf);
			paf->drop();

			pas->setMaterialFlag(video::EMF_LIGHTING, false);
			pas->setMaterialFlag(video::EMF_ZWRITE_ENABLE, false);
			pas->setMaterialTexture(0, device->getVideoDriver()->getTexture(getExampleMediaPath() + "smoke.bmp"));
			pas->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR);

			scene::ISceneNodeAnimator* anim = sm->createDeleteAnimator(2000);
			pas->addAnimator(anim);
			anim->drop();

			// play impact sound
			#ifdef USE_IRRKLANG
			if (irrKlang)
			{
				irrklang::ISound* sound =
					irrKlang->play3D(impactSound, Impacts[i].pos, false, false, true);

				if (sound)
				{
					// adjust max value a bit to make to sound of an impact louder
					sound->setMinDistance(400);
					sound->drop();
				}
			}
			#endif

			#ifdef USE_SDL_MIXER
			if (impactSound)
				playSound(impactSound);
			#endif

			// delete entry
			Impacts.erase(i);
			i--;
		}
}


#ifdef USE_IRRKLANG
void CDemo::startIrrKlang()
{
	irrKlang = irrklang::createIrrKlangDevice();

	if (!irrKlang)
		return;

	const io::path mediaPath = getExampleMediaPath();

	// play music

	irrklang::ISound* snd = irrKlang->play2D((mediaPath + "IrrlichtTheme.ogg").c_str(), true, false, true);
	if ( !snd )
		snd = irrKlang->play2D("IrrlichtTheme.ogg", true, false, true);

	if (snd)
	{
		snd->setVolume(0.5f); // 50% volume
		snd->drop();
	}

	// preload both sound effects

	ballSound = irrKlang->getSoundSource(mediaPath + "ball.wav");
	impactSound = irrKlang->getSoundSource(mediaPath + "impact.wav");
}
#endif


#ifdef USE_SDL_MIXER
void CDemo::startSound()
{
	stream = NULL;
	ballSound = NULL;
	impactSound = NULL;

	SDL_Init(SDL_INIT_AUDIO);

	if (Mix_OpenAudio(22050, AUDIO_S16, 2, 128))
		return;

	const io::path mediaPath = getExampleMediaPath();

	stream = Mix_LoadMUS((mediaPath + "IrrlichtTheme.ogg").c_str());
	if (stream)
		Mix_PlayMusic(stream, -1);

	ballSound = Mix_LoadWAV(mediaPath + "ball.wav");
	impactSound = Mix_LoadWAV(mediaPath + "impact.wav");
}

void CDemo::playSound(Mix_Chunk *sample)
{
	if (sample)
		Mix_PlayChannel(-1, sample, 0);
}

void CDemo::pollSound(void)
{
	SDL_Event event;

	while (SDL_PollEvent(&event))
		;
}
#endif
