/** Example 021 Quake3 Explorer

This tutorial shows how to load different Quake 3 maps.

Features:
	- Load BSP Archives at Runtime from the menu
	- Load a Map from the menu. Showing with Screenshot
	- Set the VideoDriver at runtime from menu
	- Adjust GammaLevel at runtime
	- Create SceneNodes for the Shaders
	- Load EntityList and create Entity SceneNodes
	- Create Players with Weapons and with Collision Response
	- Play music

You can download the Quake III Arena demo ( copyright id software )
at the following location:
ftp://ftp.idsoftware.com/idstuff/quake3/win32/q3ademo.exe

Copyright 2006-2011 Burningwater, Thomas Alten
*/

#include <irrlicht.h>
#include "driverChoice.h"
#include "exampleHelper.h"
#include "q3factory.h"
#include "sound.h"

/*
	Game Data is used to hold Data which is needed to drive the game
*/
struct GameData
{
	GameData ( const path &startupDir) :
		retVal(0), StartupDir(startupDir), createExDevice(0), Device(0)
	{
		setDefault ();
	}

	void setDefault ();
	s32 save ( const path &filename );
	s32 load ( const path &filename );

	s32 debugState;
	s32 gravityState;
	s32 flyTroughState;
	s32 wireFrame;
	s32 guiActive;
	s32 guiInputActive;
	f32 GammaValue;
	s32 retVal;
	s32 sound;

	path StartupDir;
	stringw CurrentMapName;
	array<path> CurrentArchiveList;

	vector3df PlayerPosition;
	vector3df PlayerRotation;

	tQ3EntityList Variable;

	Q3LevelLoadParameter loadParam;
	SIrrlichtCreationParameters deviceParam;
	funcptr_createDeviceEx createExDevice;
	IrrlichtDevice *Device;
};

/*
	set default settings
*/
void GameData::setDefault ()
{
	debugState = EDS_OFF;
	gravityState = 1;
	flyTroughState = 0;
	wireFrame = 0;
	guiActive = 1;
	guiInputActive = 0;
	GammaValue = 1.f;

	// default deviceParam;
#if defined ( _IRR_WINDOWS_ )
	deviceParam.DriverType = EDT_DIRECT3D9;
#else
	deviceParam.DriverType = EDT_OPENGL;
#endif
	deviceParam.WindowSize.Width = 800;
	deviceParam.WindowSize.Height = 600;
	deviceParam.Fullscreen = false;
	deviceParam.Bits = 24;
	deviceParam.ZBufferBits = 16;
	deviceParam.Vsync = false;
	deviceParam.AntiAlias = false;

	// default Quake3 loadParam
	loadParam.defaultLightMapMaterial = EMT_LIGHTMAP;
	loadParam.defaultModulate = EMFN_MODULATE_1X;
	loadParam.defaultFilter = EMF_ANISOTROPIC_FILTER;
	loadParam.verbose = 2;
	loadParam.mergeShaderBuffer = 1;		// merge meshbuffers with same material
	loadParam.cleanUnResolvedMeshes = 1;	// should unresolved meshes be cleaned. otherwise blue texture
	loadParam.loadAllShaders = 1;			// load all scripts in the script directory
	loadParam.loadSkyShader = 0;			// load sky Shader
	loadParam.alpharef = 1;

	sound = 0;

	CurrentMapName = "";
	CurrentArchiveList.clear ();

	const io::path mediaPath = getExampleMediaPath();

	// Explorer Media directory
	CurrentArchiveList.push_back ( StartupDir + mediaPath );

	// Add the original quake3 files before you load your custom map
	// Most mods are using the original shaders, models&items&weapons
	CurrentArchiveList.push_back("/q/baseq3/");

	CurrentArchiveList.push_back(StartupDir + mediaPath + "map-20kdm2.pk3");
}

/*
	Load the current game State from a typical quake3 cfg file
*/
s32 GameData::load ( const path &filename )
{
	if (!Device)
		return 0;

	// the quake3 mesh loader can also handle *.shader and *.cfg file
	IQ3LevelMesh* mesh = (IQ3LevelMesh*) Device->getSceneManager()->getMesh ( filename );
	if (!mesh)
		return 0;

	tQ3EntityList &entityList = mesh->getEntityList ();

	stringc s;
	u32 pos;

	for ( u32 e = 0; e != entityList.size (); ++e )
	{
		//dumpShader ( s, &entityList[e], false );
		//printf ( s.c_str () );

		for ( u32 g = 0; g != entityList[e].getGroupSize (); ++g )
		{
			const SVarGroup *group = entityList[e].getGroup ( g );

			for ( u32 index = 0; index < group->Variable.size (); ++index )
			{
				const SVariable &v = group->Variable[index];
				pos = 0;
				if ( v.name == "playerposition" )
				{
					PlayerPosition = getAsVector3df ( v.content, pos );
				}
				else
				if ( v.name == "playerrotation" )
				{
					PlayerRotation = getAsVector3df ( v.content, pos );
				}
			}
		}
	}

	return 1;
}

/*
	Store the current game State in a quake3 configuration file
*/
s32 GameData::save ( const path &filename )
{
	return 0;
	if (!Device)
		return 0;

	c8 buf[128];
	u32 i;

	// Store current Archive for restart
	CurrentArchiveList.clear();
	IFileSystem *fs = Device->getFileSystem();
	for ( i = 0; i != fs->getFileArchiveCount(); ++i )
	{
		CurrentArchiveList.push_back ( fs->getFileArchive(i)->getFileList()->getPath() );
	}

	// Store Player Position and Rotation
	ICameraSceneNode * camera = Device->getSceneManager()->getActiveCamera ();
	if ( camera )
	{
		PlayerPosition = camera->getPosition ();
		PlayerRotation = camera->getRotation ();
	}

	IWriteFile *file = fs->createAndWriteFile ( filename );
	if (!file)
		return 0;

	snprintf_irr ( buf, 128, "playerposition %.f %.f %.f\nplayerrotation %.f %.f %.f\n",
			PlayerPosition.X, PlayerPosition.Z, PlayerPosition.Y,
			PlayerRotation.X, PlayerRotation.Z, PlayerRotation.Y);
	file->write ( buf, (s32) strlen ( buf ) );
	for ( i = 0; i != fs->getFileArchiveCount(); ++i )
	{
		snprintf_irr ( buf, 128, "archive %s\n",stringc ( fs->getFileArchive(i)->getFileList()->getPath() ).c_str () );
		file->write ( buf, (s32) strlen ( buf ) );
	}

	file->drop ();
	return 1;
}

/*
	Representing a player
*/
struct Q3Player : public IAnimationEndCallBack
{
	Q3Player ()
	: Device(0), MapParent(0), Mesh(0), WeaponNode(0), StartPositionCurrent(0)
	{
		animation[0] = 0;
		memset(Anim, 0, sizeof(TimeFire)*4);
	}

	virtual void OnAnimationEnd(IAnimatedMeshSceneNode* node);

	void create (	IrrlichtDevice *device,
					IQ3LevelMesh* mesh,
					ISceneNode *mapNode,
					IMetaTriangleSelector *meta
				);
	void shutdown ();
	void setAnim ( const c8 *name );
	void respawn ();
	void setpos ( const vector3df &pos, const vector3df& rotation );

	ISceneNodeAnimatorCollisionResponse * cam() { return camCollisionResponse ( Device ); }

	IrrlichtDevice *Device;
	ISceneNode* MapParent;
	IQ3LevelMesh* Mesh;
	IAnimatedMeshSceneNode* WeaponNode;
	s32 StartPositionCurrent;
	TimeFire Anim[4];
	c8 animation[64];
	c8 buf[64];
};


/* End player
*/
void Q3Player::shutdown ()
{
	setAnim ( 0 );

	dropElement (WeaponNode);

	if ( Device )
	{
		ICameraSceneNode* camera = Device->getSceneManager()->getActiveCamera();
		dropElement ( camera );
		Device = 0;
	}

	MapParent = 0;
	Mesh = 0;
}


/* create a new player
*/
void Q3Player::create ( IrrlichtDevice *device, IQ3LevelMesh* mesh, ISceneNode *mapNode, IMetaTriangleSelector *meta )
{
	setTimeFire ( Anim + 0, 200, FIRED );
	setTimeFire ( Anim + 1, 5000 );

	if (!device)
		return;
	// load FPS weapon to Camera
	Device = device;
	Mesh = mesh;
	MapParent = mapNode;

	ISceneManager *smgr = device->getSceneManager ();
	IVideoDriver * driver = device->getVideoDriver();

	ICameraSceneNode* camera = 0;

	core::array<SKeyMap> keyMap;
	keyMap.set_used(12);
	keyMap[0].Action = EKA_MOVE_FORWARD;
	keyMap[0].KeyCode = KEY_UP;
	keyMap[1].Action = EKA_MOVE_FORWARD;
	keyMap[1].KeyCode = KEY_KEY_W;

	keyMap[2].Action = EKA_MOVE_BACKWARD;
	keyMap[2].KeyCode = KEY_DOWN;
	keyMap[3].Action = EKA_MOVE_BACKWARD;
	keyMap[3].KeyCode = KEY_KEY_S;

	keyMap[4].Action = EKA_STRAFE_LEFT;
	keyMap[4].KeyCode = KEY_LEFT;
	keyMap[5].Action = EKA_STRAFE_LEFT;
	keyMap[5].KeyCode = KEY_KEY_A;

	keyMap[6].Action = EKA_STRAFE_RIGHT;
	keyMap[6].KeyCode = KEY_RIGHT;
	keyMap[7].Action = EKA_STRAFE_RIGHT;
	keyMap[7].KeyCode = KEY_KEY_D;

	keyMap[8].Action = EKA_JUMP_UP;
	keyMap[8].KeyCode = KEY_KEY_J;

	keyMap[9].Action = EKA_CROUCH;
	keyMap[9].KeyCode = KEY_KEY_C;

	keyMap[10].Action = EKA_ROTATE_LEFT;
	keyMap[10].KeyCode = KEY_KEY_Q;

	keyMap[11].Action = EKA_ROTATE_RIGHT;
	keyMap[11].KeyCode = KEY_KEY_E;

	camera = smgr->addCameraSceneNodeFPS(0, 100.0f, 0.6f, -1, keyMap.pointer(), keyMap.size(), false, 600.f);
	camera->setName ( "First Person Camera" );
	//camera->setFOV ( 100.f * core::DEGTORAD );
	camera->setFarValue( 20000.f );

	IAnimatedMeshMD2* weaponMesh = (IAnimatedMeshMD2*) smgr->getMesh("gun.md2");
	if ( 0 == weaponMesh )
		return;

	if ( weaponMesh->getMeshType() == EAMT_MD2 )
	{
		s32 count = weaponMesh->getAnimationCount();
		for ( s32 i = 0; i != count; ++i )
		{
			snprintf_irr ( buf, 64, "Animation: %s", weaponMesh->getAnimationName(i) );
			device->getLogger()->log(buf, ELL_INFORMATION);
		}
	}

	WeaponNode = smgr->addAnimatedMeshSceneNode(
						weaponMesh,
						smgr->getActiveCamera(),
						10,
						vector3df( 0, 0, 0),
						vector3df(-90,-90,90)
						);
	WeaponNode->setMaterialFlag(EMF_LIGHTING, false);
	WeaponNode->setMaterialTexture(0, driver->getTexture( "gun.jpg"));
	WeaponNode->setLoopMode ( false );
	WeaponNode->setName ( "tommi the gun man" );

	//create a collision auto response animator
	ISceneNodeAnimator* anim =
		smgr->createCollisionResponseAnimator( meta, camera,
			vector3df(30,45,30),
			getGravity ( "earth" ),
			vector3df(0,40,0),
			0.0005f
		);

	camera->addAnimator( anim );
	anim->drop();

	if ( meta )
	{
		meta->drop ();
	}

	respawn ();
	setAnim ( "idle" );
}


/*
	so we need a good starting Position in the level.
	we can ask the Quake3 Loader for all entities with class_name "info_player_deathmatch"
*/
void Q3Player::respawn ()
{
	if (!Device)
		return;
	ICameraSceneNode* camera = Device->getSceneManager()->getActiveCamera();

	Device->getLogger()->log( "respawn" );

	if (StartPositionCurrent >= Q3StartPosition(Mesh, camera,
			StartPositionCurrent, cam()->getEllipsoidTranslation()))
		StartPositionCurrent = 0;
	else
		++StartPositionCurrent;
}

/*
	set Player position from saved coordinates
*/
void Q3Player::setpos ( const vector3df &pos, const vector3df &rotation )
{
	if (!Device)
		return;
	Device->getLogger()->log( "setpos" );

	ICameraSceneNode* camera = Device->getSceneManager()->getActiveCamera();
	if ( camera )
	{
		camera->setPosition ( pos );
		camera->setRotation ( rotation );
		//! New. FPSCamera and animators catches reset on animate 0
		camera->OnAnimate ( 0 );
	}
}

/* set the Animation of the player and weapon
*/
void Q3Player::setAnim ( const c8 *name )
{
	if ( name )
	{
		snprintf_irr ( animation, 64, "%s", name );
		if ( WeaponNode )
		{
			WeaponNode->setAnimationEndCallback ( this );
			WeaponNode->setMD2Animation ( animation );
		}
	}
	else
	{
		animation[0] = 0;
		if ( WeaponNode )
		{
			WeaponNode->setAnimationEndCallback ( 0 );
		}
	}
}


// Callback
void Q3Player::OnAnimationEnd(IAnimatedMeshSceneNode* node)
{
	setAnim ( 0 );
}



/* GUI Elements
*/
struct GUI
{
	GUI ()
	{
		memset ( this, 0, sizeof ( *this ) );
	}

	void drop()
	{
		dropElement ( Window );
		dropElement ( Logo );
	}

	IGUIComboBox* VideoDriver;
	IGUIComboBox* VideoMode;
	IGUICheckBox* FullScreen;
	IGUICheckBox* Bit32;
	IGUIScrollBar* MultiSample;
	IGUIButton* SetVideoMode;

	IGUIScrollBar* Tesselation;
	IGUIScrollBar* Gamma;
	IGUICheckBox* Collision;
	IGUICheckBox* Visible_Map;
	IGUICheckBox* Visible_Shader;
	IGUICheckBox* Visible_Fog;
	IGUICheckBox* Visible_Unresolved;
	IGUICheckBox* Visible_Skydome;
	IGUIButton* Respawn;

	IGUITable* ArchiveList;
	IGUIButton* ArchiveAdd;
	IGUIButton* ArchiveRemove;
	IGUIFileOpenDialog* ArchiveFileOpen;
	IGUIButton* ArchiveUp;
	IGUIButton* ArchiveDown;

	IGUIListBox* MapList;
	IGUITreeView* SceneTree;
	IGUIStaticText* StatusLine;
	IGUIImage* Logo;
	IGUIWindow* Window;
};


/*
	CQuake3EventHandler controls the game
*/
class CQuake3EventHandler : public IEventReceiver
{
public:

	CQuake3EventHandler( GameData *gameData );
	virtual ~CQuake3EventHandler ();

	void Animate();
	void Render();

	void AddArchive ( const path& archiveName );
	void LoadMap ( const stringw& mapName, s32 collision );
	void CreatePlayers();
	void AddSky( u32 dome, const c8 *texture );
	Q3Player *GetPlayer ( u32 index ) { return &Player[index]; }

	void CreateGUI();
	void SetGUIActive( s32 command);

	bool OnEvent(const SEvent& eve);


private:

	GameData *Game;

	IQ3LevelMesh* Mesh;
	ISceneNode* MapParent;
	ISceneNode* ShaderParent;
	ISceneNode* ItemParent;
	ISceneNode* UnresolvedParent;
	ISceneNode* BulletParent;
	ISceneNode* FogParent;
	ISceneNode * SkyNode;
	IMetaTriangleSelector *Meta;

	c8 buf[256];

	Q3Player Player[2];

	struct SParticleImpact
	{
		u32 when;
		vector3df pos;
		vector3df outVector;
	};
	array<SParticleImpact> Impacts;
	void useItem( Q3Player * player);
	void createParticleImpacts( u32 now );

	void createTextures ();
	void addSceneTreeItem( ISceneNode * parent, IGUITreeViewNode* nodeParent);

	GUI gui;
	void dropMap ();
};

/* Constructor
*/
CQuake3EventHandler::CQuake3EventHandler( GameData *game )
: Game(game), Mesh(0), MapParent(0), ShaderParent(0), ItemParent(0), UnresolvedParent(0),
	BulletParent(0), FogParent(0), SkyNode(0), Meta(0)
{
	buf[0]=0;
	// Also use 16 Bit Textures for 16 Bit RenderDevice
	if ( Game->deviceParam.Bits == 16 )
	{
		game->Device->getVideoDriver()->setTextureCreationFlag(ETCF_ALWAYS_16_BIT, true);
	}

	// Quake3 Shader controls Z-Writing
	game->Device->getSceneManager()->getParameters()->setAttribute(scene::ALLOW_ZWRITE_ON_TRANSPARENT, true);

	// create internal textures
	createTextures ();

	sound_init ( game->Device );

	Game->Device->setEventReceiver ( this );
}


// destructor
CQuake3EventHandler::~CQuake3EventHandler ()
{
	Player[0].shutdown ();
	sound_shutdown ();

	Game->save( "explorer.cfg" );

	Game->Device->drop();
}


// create runtime textures smog, fog
void CQuake3EventHandler::createTextures()
{
	IVideoDriver * driver = Game->Device->getVideoDriver();

	dimension2du dim(64, 64);

	video::IImage* image;
	u32 i;
	u32 x;
	u32 y;
	u32 * data;
	for ( i = 0; i != 8; ++i )
	{
		image = driver->createImage ( video::ECF_A8R8G8B8, dim);
		data = (u32*) image->getData ();
		for ( y = 0; y != dim.Height; ++y )
		{
			for ( x = 0; x != dim.Width; ++x )
			{
				data [x] = 0xFFFFFFFF;
			}
			data = (u32*) ( (u8*) data + image->getPitch() );
		}
		snprintf_irr ( buf, 64, "smoke_%02d", i );
		driver->addTexture( buf, image );
		image->drop ();
	}

	// fog
	for ( i = 0; i != 1; ++i )
	{
		image = driver->createImage ( video::ECF_A8R8G8B8, dim);
		data = (u32*) image->getData ();
		for ( y = 0; y != dim.Height; ++y )
		{
			for ( x = 0; x != dim.Width; ++x )
			{
				data [x] = 0xFFFFFFFF;
			}
			data = (u32*) ( (u8*) data + image->getPitch() );
		}
		snprintf_irr ( buf, 64, "fog_%02d", i );
		driver->addTexture( buf, image );
		image->drop ();
	}
}


/*
	create the GUI
*/
void CQuake3EventHandler::CreateGUI()
{

	IGUIEnvironment *env = Game->Device->getGUIEnvironment();
	IVideoDriver * driver = Game->Device->getVideoDriver();

	gui.drop();

	// set skin font
	IGUIFont* font = env->getFont("fontlucida.png");
	if (font)
		env->getSkin()->setFont(font);
	env->getSkin()->setColor ( EGDC_BUTTON_TEXT, video::SColor(240,0xAA,0xAA,0xAA) );
	env->getSkin()->setColor ( EGDC_3D_HIGH_LIGHT, video::SColor(240,0x22,0x22,0x22) );
	env->getSkin()->setColor ( EGDC_3D_FACE, video::SColor(240,0x44,0x44,0x44) );
	env->getSkin()->setColor ( EGDC_EDITABLE, video::SColor(240,0x44,0x44,0x44) );
	env->getSkin()->setColor ( EGDC_FOCUSED_EDITABLE, video::SColor(240,0x54,0x54,0x54) );
	env->getSkin()->setColor ( EGDC_WINDOW, video::SColor(240,0x66,0x66,0x66) );

	// minimal gui size 800x600
	dimension2d<u32> dim ( 800, 600 );
	dimension2d<u32> vdim ( Game->Device->getVideoDriver()->getScreenSize() );

	if ( vdim.Height >= dim.Height && vdim.Width >= dim.Width )
	{
		//dim = vdim;
	}
	else
	{
	}

	gui.Window = env->addWindow ( rect<s32> ( 0, 0, dim.Width, dim.Height ), false, L"Quake3 Explorer" );
	gui.Window->setToolTipText ( L"Quake3Explorer. Loads and show various BSP File Format and Shaders." );
	gui.Window->getCloseButton()->setToolTipText ( L"Quit Quake3 Explorer" );

	// add a status line help text
	gui.StatusLine = env->addStaticText( 0, rect<s32>( 5,dim.Height - 30,dim.Width - 5,dim.Height - 10),
								false, false, gui.Window, -1, true
							);


	env->addStaticText ( L"VideoDriver:", rect<s32>( dim.Width - 400, 24, dim.Width - 310, 40 ),false, false, gui.Window, -1, false );
	gui.VideoDriver = env->addComboBox(rect<s32>( dim.Width - 300, 24, dim.Width - 10, 40 ),gui.Window);
	gui.VideoDriver->addItem(L"Direct3D 9.0c", EDT_DIRECT3D9 );
	gui.VideoDriver->addItem(L"OpenGL 1.5", EDT_OPENGL);
	gui.VideoDriver->addItem(L"Software Renderer", EDT_SOFTWARE);
	gui.VideoDriver->addItem(L"Burning's Video (TM) Thomas Alten", EDT_BURNINGSVIDEO);
	gui.VideoDriver->setSelected ( gui.VideoDriver->getIndexForItemData ( Game->deviceParam.DriverType ) );
	gui.VideoDriver->setToolTipText ( L"Use a VideoDriver" );

	env->addStaticText ( L"VideoMode:", rect<s32>( dim.Width - 400, 44, dim.Width - 310, 60 ),false, false, gui.Window, -1, false );
	gui.VideoMode = env->addComboBox(rect<s32>( dim.Width - 300, 44, dim.Width - 10, 60 ),gui.Window);
	gui.VideoMode->setToolTipText ( L"Supported Screenmodes" );
	IVideoModeList *modeList = Game->Device->getVideoModeList();
	if ( modeList )
	{
		s32 i;
		for ( i = 0; i != modeList->getVideoModeCount (); ++i )
		{
			u16 d = modeList->getVideoModeDepth ( i );
			if ( d < 16 )
				continue;

			u16 w = modeList->getVideoModeResolution ( i ).Width;
			u16 h = modeList->getVideoModeResolution ( i ).Height;
			u32 val = w << 16 | h;

			if ( gui.VideoMode->getIndexForItemData ( val ) >= 0 )
				continue;

			f32 aspect = (f32) w / (f32) h;
			const c8 *a = "";
			if ( core::equals ( aspect, 1.3333333333f ) ) a = "4:3";
			else if ( core::equals ( aspect, 1.6666666f ) ) a = "15:9 widescreen";
			else if ( core::equals ( aspect, 1.7777777f ) ) a = "16:9 widescreen";
			else if ( core::equals ( aspect, 1.6f ) ) a = "16:10 widescreen";
			else if ( core::equals ( aspect, 2.133333f ) ) a = "20:9 widescreen";

			snprintf_irr ( buf, sizeof ( buf ), "%d x %d, %s",w, h, a );
			gui.VideoMode->addItem ( stringw ( buf ).c_str(), val );
		}
	}
	gui.VideoMode->setSelected ( gui.VideoMode->getIndexForItemData (
									Game->deviceParam.WindowSize.Width << 16 |
									Game->deviceParam.WindowSize.Height ) );

	gui.FullScreen = env->addCheckBox ( Game->deviceParam.Fullscreen, rect<s32>( dim.Width - 400, 64, dim.Width - 300, 80 ), gui.Window,-1, L"Fullscreen" );
	gui.FullScreen->setToolTipText ( L"Set Fullscreen or Window Mode" );

	gui.Bit32 = env->addCheckBox ( Game->deviceParam.Bits == 32, rect<s32>( dim.Width - 300, 64, dim.Width - 240, 80 ), gui.Window,-1, L"32Bit" );
	gui.Bit32->setToolTipText ( L"Use 16 or 32 Bit" );

	env->addStaticText ( L"MultiSample:", rect<s32>( dim.Width - 235, 64, dim.Width - 150, 80 ),false, false, gui.Window, -1, false );
	gui.MultiSample = env->addScrollBar( true, rect<s32>( dim.Width - 150, 64, dim.Width - 70, 80 ), gui.Window,-1 );
	gui.MultiSample->setMin ( 0 );
	gui.MultiSample->setMax ( 8 );
	gui.MultiSample->setSmallStep ( 1 );
	gui.MultiSample->setLargeStep ( 1 );
	gui.MultiSample->setPos ( Game->deviceParam.AntiAlias );
	gui.MultiSample->setToolTipText ( L"Set the MultiSample (disable, 1x, 2x, 4x, 8x )" );

	gui.SetVideoMode = env->addButton (rect<s32>( dim.Width - 60, 64, dim.Width - 10, 80 ), gui.Window, -1,L"set" );
	gui.SetVideoMode->setToolTipText ( L"Set Video Mode with current values" );

	env->addStaticText ( L"Gamma:", rect<s32>( dim.Width - 400, 104, dim.Width - 310, 120 ),false, false, gui.Window, -1, false );
	gui.Gamma = env->addScrollBar( true, rect<s32>( dim.Width - 300, 104, dim.Width - 10, 120 ), gui.Window,-1 );
	gui.Gamma->setMin ( 50 );
	gui.Gamma->setMax ( 350 );
	gui.Gamma->setSmallStep ( 1 );
	gui.Gamma->setLargeStep ( 10 );
	gui.Gamma->setPos ( core::floor32 ( Game->GammaValue * 100.f ) );
	gui.Gamma->setToolTipText ( L"Adjust Gamma Ramp ( 0.5 - 3.5)" );
	Game->Device->setGammaRamp ( Game->GammaValue, Game->GammaValue, Game->GammaValue, 0.f, 0.f );


	env->addStaticText ( L"Tesselation:", rect<s32>( dim.Width - 400, 124, dim.Width - 310, 140 ),false, false, gui.Window, -1, false );
	gui.Tesselation = env->addScrollBar( true, rect<s32>( dim.Width - 300, 124, dim.Width - 10, 140 ), gui.Window,-1 );
	gui.Tesselation->setMin ( 2 );
	gui.Tesselation->setMax ( 12 );
	gui.Tesselation->setSmallStep ( 1 );
	gui.Tesselation->setLargeStep ( 1 );
	gui.Tesselation->setPos ( Game->loadParam.patchTesselation );
	gui.Tesselation->setToolTipText ( L"How smooth should curved surfaces be rendered" );

	gui.Collision = env->addCheckBox ( true, rect<s32>( dim.Width - 400, 150, dim.Width - 300, 166 ), gui.Window,-1, L"Collision" );
	gui.Collision->setToolTipText ( L"Set collision on or off ( flythrough ). \nPress F7 on your Keyboard" );
	gui.Visible_Map = env->addCheckBox ( true, rect<s32>( dim.Width - 300, 150, dim.Width - 240, 166 ), gui.Window,-1, L"Map" );
	gui.Visible_Map->setToolTipText ( L"Show or not show the static part the Level. \nPress F3 on your Keyboard" );
	gui.Visible_Shader = env->addCheckBox ( true, rect<s32>( dim.Width - 240, 150, dim.Width - 170, 166 ), gui.Window,-1, L"Shader" );
	gui.Visible_Shader->setToolTipText ( L"Show or not show the Shader Nodes. \nPress F4 on your Keyboard" );
	gui.Visible_Fog = env->addCheckBox ( true, rect<s32>( dim.Width - 170, 150, dim.Width - 110, 166 ), gui.Window,-1, L"Fog" );
	gui.Visible_Fog->setToolTipText ( L"Show or not show the Fog Nodes. \nPress F5 on your Keyboard" );
	gui.Visible_Unresolved = env->addCheckBox ( true, rect<s32>( dim.Width - 110, 150, dim.Width - 10, 166 ), gui.Window,-1, L"Unresolved" );
	gui.Visible_Unresolved->setToolTipText ( L"Show the or not show the Nodes the Engine can't handle. \nPress F6 on your Keyboard" );
	gui.Visible_Skydome = env->addCheckBox ( true, rect<s32>( dim.Width - 110, 180, dim.Width - 10, 196 ), gui.Window,-1, L"Skydome" );
	gui.Visible_Skydome->setToolTipText ( L"Show the or not show the Skydome." );

	//Respawn = env->addButton ( rect<s32>( dim.Width - 260, 90, dim.Width - 10, 106 ), 0,-1, L"Respawn" );

	env->addStaticText ( L"Archives:", rect<s32>( 5, dim.Height - 530, dim.Width - 600,dim.Height - 514 ),false, false, gui.Window, -1, false );

	gui.ArchiveAdd = env->addButton ( rect<s32>( dim.Width - 725, dim.Height - 530, dim.Width - 665, dim.Height - 514 ), gui.Window,-1, L"add" );
	gui.ArchiveAdd->setToolTipText ( L"Add an archive, usually packed zip-archives (*.pk3) to the Filesystem" );
	gui.ArchiveRemove = env->addButton ( rect<s32>( dim.Width - 660, dim.Height - 530, dim.Width - 600, dim.Height - 514 ), gui.Window,-1, L"del" );
	gui.ArchiveRemove->setToolTipText ( L"Remove the selected archive from the FileSystem." );
	gui.ArchiveUp = env->addButton ( rect<s32>( dim.Width - 575, dim.Height - 530, dim.Width - 515, dim.Height - 514 ), gui.Window,-1, L"up" );
	gui.ArchiveUp->setToolTipText ( L"Arrange Archive Look-up Hirachy. Move the selected Archive up" );
	gui.ArchiveDown = env->addButton ( rect<s32>( dim.Width - 510, dim.Height - 530, dim.Width - 440, dim.Height - 514 ), gui.Window,-1, L"down" );
	gui.ArchiveDown->setToolTipText ( L"Arrange Archive Look-up Hirachy. Move the selected Archive down" );


	gui.ArchiveList = env->addTable ( rect<s32>( 5,dim.Height - 510, dim.Width - 450,dim.Height - 410 ), gui.Window  );
	gui.ArchiveList->addColumn ( L"Type", 0 );
	gui.ArchiveList->addColumn ( L"Real File Path", 1 );
	gui.ArchiveList->setColumnWidth ( 0, 60 );
	gui.ArchiveList->setColumnWidth ( 1, 284 );
	gui.ArchiveList->setToolTipText ( L"Show the attached Archives" );


	env->addStaticText ( L"Maps:", rect<s32>( 5, dim.Height - 400, dim.Width - 450,dim.Height - 380 ),false, false, gui.Window, -1, false );
	gui.MapList = env->addListBox ( rect<s32>( 5,dim.Height - 380, dim.Width - 450,dim.Height - 40  ), gui.Window, -1, true  );
	gui.MapList->setToolTipText ( L"Show the current Maps in all Archives.\n Double-Click the Map to start the level" );


	// create a visible Scene Tree
	env->addStaticText ( L"Scenegraph:", rect<s32>( dim.Width - 400, dim.Height - 400, dim.Width - 5,dim.Height - 380 ),false, false, gui.Window, -1, false );
	gui.SceneTree = env->addTreeView(	rect<s32>( dim.Width - 400, dim.Height - 380, dim.Width - 5, dim.Height - 40 ),
									gui.Window, -1, true, true, false );
	gui.SceneTree->setToolTipText ( L"Show the current Scenegraph" );
	gui.SceneTree->getRoot()->clearChildren();
	addSceneTreeItem ( Game->Device->getSceneManager()->getRootSceneNode(), gui.SceneTree->getRoot() );


	IGUIImageList* imageList = env->createImageList(	driver->getTexture ( "iconlist.png" ),
										dimension2di( 32, 32 ), true );

	if ( imageList )
	{
		gui.SceneTree->setImageList( imageList );
		imageList->drop ();
	}


	// load the engine logo
	gui.Logo = env->addImage( driver->getTexture("irrlichtlogo3.png"), position2d<s32>(5, 16 ), true, 0 );
	gui.Logo->setToolTipText ( L"The great Irrlicht Engine" );

	AddArchive ( "" );
}


/*
	Add an Archive to the FileSystems and updates the GUI
*/
void CQuake3EventHandler::AddArchive ( const path& archiveName )
{
	IFileSystem *fs = Game->Device->getFileSystem();
	u32 i;

	if ( archiveName.size () )
	{
		bool exists = false;
		for ( i = 0; i != fs->getFileArchiveCount(); ++i )
		{
			if ( fs->getFileArchive(i)->getFileList()->getPath() == archiveName )
			{
				exists = true;
				break;
			}
		}

		if (!exists)
		{
			fs->addFileArchive(archiveName, true, false);
		}
	}

	// store the current archives in game data
	// show the attached Archive in proper order
	if ( gui.ArchiveList )
	{
		gui.ArchiveList->clearRows();

		for ( i = 0; i != fs->getFileArchiveCount(); ++i )
		{
			IFileArchive * archive = fs->getFileArchive ( i );

			u32 index = gui.ArchiveList->addRow(i);

			core::stringw typeName;
			switch(archive->getType())
			{
			case io::EFAT_ZIP:
				typeName = "ZIP";
				break;
			case io::EFAT_GZIP:
				typeName = "gzip";
				break;
			case io::EFAT_FOLDER:
				typeName = "Mount";
				break;
			case io::EFAT_PAK:
				typeName = "PAK";
				break;
			case io::EFAT_TAR:
				typeName = "TAR";
				break;
			default:
				typeName = "archive";
			}

			gui.ArchiveList->setCellText ( index, 0, typeName );
			gui.ArchiveList->setCellText ( index, 1, archive->getFileList()->getPath() );
		}
	}


	// browse the archives for maps
	if ( gui.MapList )
	{
		gui.MapList->clear();

		IGUISpriteBank *bank = Game->Device->getGUIEnvironment()->getSpriteBank("sprite_q3map");
		if ( 0 == bank )
			bank = Game->Device->getGUIEnvironment()->addEmptySpriteBank("sprite_q3map");

		SGUISprite sprite;
		SGUISpriteFrame frame;
		core::rect<s32> r;

		bank->getSprites().clear();
		bank->getPositions().clear ();
		gui.MapList->setSpriteBank ( bank );

		u32 g = 0;
		core::stringw s;

		// browse the attached file system
		fs->setFileListSystem ( FILESYSTEM_VIRTUAL );
		fs->changeWorkingDirectoryTo ( "/maps/" );
		IFileList *fileList = fs->createFileList ();
		fs->setFileListSystem ( FILESYSTEM_NATIVE );

		for ( i=0; i< fileList->getFileCount(); ++i)
		{
			s = fileList->getFullFileName(i);
			if ( s.find ( ".bsp" ) >= 0 )
			{
				// get level screenshot. reformat texture to 128x128
				path c ( s );
				deletePathFromFilename ( c );
				cutFilenameExtension ( c, c );
				c = path ( "levelshots/" ) + c;

				dimension2du dim ( 128, 128 );
				IVideoDriver * driver = Game->Device->getVideoDriver();
				IImage* image = 0;
				ITexture *tex = 0;
				path filename;

				filename = c + ".jpg";
				if ( fs->existFile ( filename ) )
					image = driver->createImageFromFile( filename );
				if ( 0 == image )
				{
					filename = c + ".tga";
					if ( fs->existFile ( filename ) )
						image = driver->createImageFromFile( filename );
				}

				if ( image )
				{
					IImage* filter = driver->createImage ( video::ECF_R8G8B8, dim );
					image->copyToScalingBoxFilter ( filter, 0 );
					image->drop ();
					image = filter;
				}

				if ( image )
				{
					tex = driver->addTexture ( filename, image );
					image->drop ();
				}


				bank->setTexture ( g, tex );

				r.LowerRightCorner.X = dim.Width;
				r.LowerRightCorner.Y = dim.Height;
				gui.MapList->setItemHeight ( r.LowerRightCorner.Y + 4 );
				frame.rectNumber = bank->getPositions().size();
				frame.textureNumber = g;

				bank->getPositions().push_back(r);

				sprite.Frames.set_used ( 0 );
				sprite.Frames.push_back(frame);
				sprite.frameTime = 0;
				bank->getSprites().push_back(sprite);

				gui.MapList->addItem ( s.c_str (), g );
				g += 1;
			}
		}
		fileList->drop ();

		gui.MapList->setSelected ( -1 );
		IGUIScrollBar * bar = (IGUIScrollBar*)gui.MapList->getElementFromId( 0 );
		if ( bar )
			bar->setPos ( 0 );

	}

}

/*
	clears the Map in Memory
*/
void CQuake3EventHandler::dropMap ()
{
	IVideoDriver * driver = Game->Device->getVideoDriver();

	driver->removeAllHardwareBuffers ();
	driver->removeAllTextures ();

	Player[0].shutdown ();


	dropElement ( ItemParent );
	dropElement ( ShaderParent );
	dropElement ( UnresolvedParent );
	dropElement ( FogParent );
	dropElement ( BulletParent );


	Impacts.clear();

	if ( Meta )
	{
		Meta = 0;
	}

	dropElement ( MapParent );
	dropElement ( SkyNode );

	// clean out meshes, because textures are invalid
	// TODO: better texture handling;-)
	IMeshCache *cache = Game->Device->getSceneManager ()->getMeshCache();
	cache->clear ();
	Mesh = 0;
}

/* Load new map
*/
void CQuake3EventHandler::LoadMap ( const stringw &mapName, s32 collision )
{
	if ( 0 == mapName.size() )
		return;

	dropMap ();

	IFileSystem *fs = Game->Device->getFileSystem();
	ISceneManager *smgr = Game->Device->getSceneManager ();

	IReadFile* file = fs->createMemoryReadFile(&Game->loadParam,
				sizeof(Game->loadParam), L"levelparameter.cfg", false);

	// load cfg file
	smgr->getMesh( file );
	file->drop ();

	// load the actual map
	Mesh = (IQ3LevelMesh*) smgr->getMesh(mapName);
	if ( 0 == Mesh )
		return;

	/*
		add the geometry mesh to the Scene ( polygon & patches )
		The Geometry mesh is optimised for faster drawing
	*/

	IMesh *geometry = Mesh->getMesh(E_Q3_MESH_GEOMETRY);
	if ( 0 == geometry || geometry->getMeshBufferCount() == 0)
		return;

	Game->CurrentMapName = mapName;

	//create a collision list
	Meta = 0;

	ITriangleSelector * selector = 0;
	if (collision)
		Meta = smgr->createMetaTriangleSelector();

	//IMeshBuffer *b0 = geometry->getMeshBuffer(0);
	//s32 minimalNodes = b0 ? core::s32_max ( 2048, b0->getVertexCount() / 32 ) : 2048;
	s32 minimalNodes = 2048;

	MapParent = smgr->addOctreeSceneNode(geometry, 0, -1, minimalNodes);
	MapParent->setName ( mapName );
	if ( Meta )
	{
		selector = smgr->createOctreeTriangleSelector( geometry,MapParent, minimalNodes);
		//selector = smgr->createTriangleSelector ( geometry, MapParent );
		Meta->addTriangleSelector( selector);
		selector->drop ();
	}

	// logical parent for the items
	ItemParent = smgr->addEmptySceneNode();
	if ( ItemParent )
		ItemParent->setName ( "Item Container" );

	ShaderParent = smgr->addEmptySceneNode();
	if ( ShaderParent )
		ShaderParent->setName ( "Shader Container" );

	UnresolvedParent = smgr->addEmptySceneNode();
	if ( UnresolvedParent )
		UnresolvedParent->setName ( "Unresolved Container" );

	FogParent = smgr->addEmptySceneNode();
	if ( FogParent )
		FogParent->setName ( "Fog Container" );

	// logical parent for the bullets
	BulletParent = smgr->addEmptySceneNode();
	if ( BulletParent )
		BulletParent->setName ( "Bullet Container" );

	/*
		now construct SceneNodes for each Shader
		The Objects are stored in the quake mesh E_Q3_MESH_ITEMS
		and the Shader ID is stored in the MaterialParameters
		mostly dark looking skulls and moving lava.. or green flashing tubes?
	*/
	Q3ShaderFactory ( Game->loadParam, Game->Device, Mesh, E_Q3_MESH_ITEMS,ShaderParent, Meta, false );
	Q3ShaderFactory ( Game->loadParam, Game->Device, Mesh, E_Q3_MESH_FOG,FogParent, 0, false );
	Q3ShaderFactory ( Game->loadParam, Game->Device, Mesh, E_Q3_MESH_UNRESOLVED,UnresolvedParent, Meta, true );

	/*
		Now construct Models from Entity List
	*/
	Q3ModelFactory ( Game->loadParam, Game->Device, Mesh, ItemParent, false );
}

/*
	Adds a SceneNode with an icon to the Scene Tree
*/
void CQuake3EventHandler::addSceneTreeItem( ISceneNode * parent, IGUITreeViewNode* nodeParent)
{
	IGUITreeViewNode* node;
	wchar_t msg[128];

	s32 imageIndex;
	list<ISceneNode*>::ConstIterator it = parent->getChildren().begin();
	for (; it != parent->getChildren().end(); ++it)
	{
		switch ( (*it)->getType () )
		{
			case ESNT_Q3SHADER_SCENE_NODE: imageIndex = 0; break;
			case ESNT_CAMERA: imageIndex = 1; break;
			case ESNT_EMPTY: imageIndex = 2; break;
			case ESNT_MESH: imageIndex = 3; break;
			case ESNT_OCTREE: imageIndex = 3; break;
			case ESNT_ANIMATED_MESH: imageIndex = 4; break;
			case ESNT_SKY_BOX: imageIndex = 5; break;
			case ESNT_BILLBOARD: imageIndex = 6; break;
			case ESNT_PARTICLE_SYSTEM: imageIndex = 7; break;
			case ESNT_TEXT: imageIndex = 8; break;
			default:imageIndex = -1; break;
		}

		if ( imageIndex < 0 )
		{
			swprintf_irr ( msg, 128, L"%hs,%hs",
				Game->Device->getSceneManager ()->getSceneNodeTypeName ( (*it)->getType () ),
				(*it)->getName()
				);
		}
		else
		{
			swprintf_irr ( msg, 128, L"%hs",(*it)->getName() );
		}

		node = nodeParent->addChildBack( msg, 0, imageIndex );

		// Add all Animators
		list<ISceneNodeAnimator*>::ConstIterator ait = (*it)->getAnimators().begin();
		for (; ait != (*it)->getAnimators().end(); ++ait)
		{
			imageIndex = -1;
			swprintf_irr ( msg, 128, L"%hs",
				Game->Device->getSceneManager ()->getAnimatorTypeName ( (*ait)->getType () )
				);

			switch ( (*ait)->getType () )
			{
				case ESNAT_FLY_CIRCLE:
				case ESNAT_FLY_STRAIGHT:
				case ESNAT_FOLLOW_SPLINE:
				case ESNAT_ROTATION:
				case ESNAT_TEXTURE:
				case ESNAT_DELETION:
				case ESNAT_COLLISION_RESPONSE:
				case ESNAT_CAMERA_FPS:
				case ESNAT_CAMERA_MAYA:
				default:
					break;
			}
			node->addChildBack( msg, 0, imageIndex );
		}

		addSceneTreeItem ( *it, node );
	}
}


// Adds life!
void CQuake3EventHandler::CreatePlayers()
{
	Player[0].create ( Game->Device, Mesh, MapParent, Meta );
}


// Adds a skydome to the scene
void CQuake3EventHandler::AddSky( u32 dome, const c8 *texture)
{
	ISceneManager *smgr = Game->Device->getSceneManager ();
	IVideoDriver * driver = Game->Device->getVideoDriver();

	bool oldMipMapState = driver->getTextureCreationFlag(video::ETCF_CREATE_MIP_MAPS);
	driver->setTextureCreationFlag(video::ETCF_CREATE_MIP_MAPS, false);

	if ( 0 == dome )
	{
		// irrlicht order
		//static const c8*p[] = { "ft", "lf", "bk", "rt", "up", "dn" };
		// quake3 order
		static const c8*p[] = { "ft", "rt", "bk", "lf", "up", "dn" };

		u32 i = 0;
		snprintf_irr ( buf, 64, "%s_%s.jpg", texture, p[i] );
		SkyNode = smgr->addSkyBoxSceneNode( driver->getTexture ( buf ), 0, 0, 0, 0, 0 );

		if (SkyNode)
		{
			for ( i = 0; i < 6; ++i )
			{
				snprintf_irr ( buf, 64, "%s_%s.jpg", texture, p[i] );
				SkyNode->getMaterial(i).setTexture ( 0, driver->getTexture ( buf ) );
			}
		}
	}
	else
	if ( 1 == dome )
	{
		snprintf_irr ( buf, 64, "%s.jpg", texture );
		SkyNode = smgr->addSkyDomeSceneNode(
				driver->getTexture( buf ), 32,32,
				1.f, 1.f, 1000.f, 0, 11);
	}
	else
	if ( 2 == dome )
	{
		snprintf_irr ( buf, 64, "%s.jpg", texture );
		SkyNode = smgr->addSkyDomeSceneNode(
				driver->getTexture( buf ), 16,8,
				0.95f, 2.f, 1000.f, 0, 11);
	}

	if (SkyNode)
		SkyNode->setName("Skydome");
	//SkyNode->getMaterial(0).ZBuffer = video::EMDF_DEPTH_LESS_EQUAL;

	driver->setTextureCreationFlag(video::ETCF_CREATE_MIP_MAPS, oldMipMapState);
}


// enable GUI elements
void CQuake3EventHandler::SetGUIActive( s32 command)
{
	bool inputState = false;

	ICameraSceneNode * camera = Game->Device->getSceneManager()->getActiveCamera ();

	switch ( command )
	{
		case 0: Game->guiActive = 0; inputState = !Game->guiActive; break;
		case 1: Game->guiActive = 1; inputState = !Game->guiActive;;break;
		case 2: Game->guiActive ^= 1; inputState = !Game->guiActive;break;
		case 3:
			if ( camera )
				inputState = !camera->isInputReceiverEnabled();
			break;
	}

	if ( camera )
	{
		camera->setInputReceiverEnabled ( inputState );
		Game->Device->getCursorControl()->setVisible( !inputState );
	}

	if ( gui.Window )
	{
		gui.Window->setVisible ( Game->guiActive != 0 );
	}

	if ( Game->guiActive &&
			gui.SceneTree && Game->Device->getGUIEnvironment()->getFocus() != gui.SceneTree
		)
	{
		gui.SceneTree->getRoot()->clearChildren();
		addSceneTreeItem ( Game->Device->getSceneManager()->getRootSceneNode(), gui.SceneTree->getRoot() );
	}

	Game->Device->getGUIEnvironment()->setFocus ( Game->guiActive ? gui.Window: 0 );
}


/*
	Handle game input
*/
bool CQuake3EventHandler::OnEvent(const SEvent& eve)
{
	if ( eve.EventType == EET_LOG_TEXT_EVENT )
	{
		return false;
	}

	if ( Game->guiActive && eve.EventType == EET_GUI_EVENT )
	{
		if ( eve.GUIEvent.Caller == gui.MapList && eve.GUIEvent.EventType == gui::EGET_LISTBOX_SELECTED_AGAIN )
		{
			s32 selected = gui.MapList->getSelected();
			if ( selected >= 0 )
			{
				stringw loadMap = gui.MapList->getListItem ( selected );
				if ( 0 == MapParent || loadMap != Game->CurrentMapName )
				{
					printf ( "Loading map %ls\n", loadMap.c_str() );
					LoadMap ( loadMap , 1 );
					if ( 0 == Game->loadParam.loadSkyShader )
					{
						AddSky ( 1, "skydome2" );
					}
					CreatePlayers ();
					CreateGUI ();
					SetGUIActive ( 0 );
					return true;
				}
			}
		}
		else
		if ( eve.GUIEvent.Caller == gui.ArchiveRemove && eve.GUIEvent.EventType == gui::EGET_BUTTON_CLICKED )
		{
			Game->Device->getFileSystem()->removeFileArchive( gui.ArchiveList->getSelected() );
			Game->CurrentMapName = "";
			AddArchive ( "" );
		}
		else
		if ( eve.GUIEvent.Caller == gui.ArchiveAdd && eve.GUIEvent.EventType == gui::EGET_BUTTON_CLICKED )
		{
			if ( 0 == gui.ArchiveFileOpen )
			{
				Game->Device->getFileSystem()->setFileListSystem ( FILESYSTEM_NATIVE );
				gui.ArchiveFileOpen = Game->Device->getGUIEnvironment()->addFileOpenDialog ( L"Add Game Archive" , false,gui.Window  );
			}
		}
		else
		if ( eve.GUIEvent.Caller == gui.ArchiveFileOpen && eve.GUIEvent.EventType == gui::EGET_FILE_SELECTED )
		{
			AddArchive ( gui.ArchiveFileOpen->getFileNameP() );
			gui.ArchiveFileOpen = 0;
		}
		else
		if ( eve.GUIEvent.Caller == gui.ArchiveFileOpen && eve.GUIEvent.EventType == gui::EGET_DIRECTORY_SELECTED )
		{
			AddArchive ( gui.ArchiveFileOpen->getDirectoryName() );
		}
		else
		if ( eve.GUIEvent.Caller == gui.ArchiveFileOpen && eve.GUIEvent.EventType == gui::EGET_FILE_CHOOSE_DIALOG_CANCELLED )
		{
			gui.ArchiveFileOpen = 0;
		}
		else
		if ( ( eve.GUIEvent.Caller == gui.ArchiveUp || eve.GUIEvent.Caller == gui.ArchiveDown ) &&
			eve.GUIEvent.EventType == gui::EGET_BUTTON_CLICKED )
		{
			s32 rel = eve.GUIEvent.Caller == gui.ArchiveUp ? -1 : 1;
			if ( Game->Device->getFileSystem()->moveFileArchive ( gui.ArchiveList->getSelected (), rel ) )
			{
				s32 newIndex = core::s32_clamp ( gui.ArchiveList->getSelected() + rel, 0, gui.ArchiveList->getRowCount() - 1 );
				AddArchive ( "" );
				gui.ArchiveList->setSelected ( newIndex );
				Game->CurrentMapName = "";
			}
		}
		else
		if ( eve.GUIEvent.Caller == gui.VideoDriver && eve.GUIEvent.EventType == gui::EGET_COMBO_BOX_CHANGED )
		{
			Game->deviceParam.DriverType = (E_DRIVER_TYPE) gui.VideoDriver->getItemData ( gui.VideoDriver->getSelected() );
		}
		else
		if ( eve.GUIEvent.Caller == gui.VideoMode && eve.GUIEvent.EventType == gui::EGET_COMBO_BOX_CHANGED )
		{
			u32 val = gui.VideoMode->getItemData ( gui.VideoMode->getSelected() );
			Game->deviceParam.WindowSize.Width = val >> 16;
			Game->deviceParam.WindowSize.Height = val & 0xFFFF;
		}
		else
		if ( eve.GUIEvent.Caller == gui.FullScreen && eve.GUIEvent.EventType == gui::EGET_CHECKBOX_CHANGED )
		{
			Game->deviceParam.Fullscreen = gui.FullScreen->isChecked();
		}
		else
		if ( eve.GUIEvent.Caller == gui.Bit32 && eve.GUIEvent.EventType == gui::EGET_CHECKBOX_CHANGED )
		{
			Game->deviceParam.Bits = gui.Bit32->isChecked() ? 32 : 16;
		}
		else
		if ( eve.GUIEvent.Caller == gui.MultiSample && eve.GUIEvent.EventType == gui::EGET_SCROLL_BAR_CHANGED )
		{
			Game->deviceParam.AntiAlias = gui.MultiSample->getPos();
		}
		else
		if ( eve.GUIEvent.Caller == gui.Tesselation && eve.GUIEvent.EventType == gui::EGET_SCROLL_BAR_CHANGED )
		{
			Game->loadParam.patchTesselation = gui.Tesselation->getPos ();
		}
		else
		if ( eve.GUIEvent.Caller == gui.Gamma && eve.GUIEvent.EventType == gui::EGET_SCROLL_BAR_CHANGED )
		{
			Game->GammaValue = gui.Gamma->getPos () * 0.01f;
			Game->Device->setGammaRamp ( Game->GammaValue, Game->GammaValue, Game->GammaValue, 0.f, 0.f );
		}
		else
		if ( eve.GUIEvent.Caller == gui.SetVideoMode && eve.GUIEvent.EventType == gui::EGET_BUTTON_CLICKED )
		{
			Game->retVal = 2;
			Game->Device->closeDevice();
		}
		else
		if ( eve.GUIEvent.Caller == gui.Window && eve.GUIEvent.EventType == gui::EGET_ELEMENT_CLOSED )
		{
			Game->Device->closeDevice();
		}
		else
		if ( eve.GUIEvent.Caller == gui.Collision && eve.GUIEvent.EventType == gui::EGET_CHECKBOX_CHANGED )
		{
			// set fly through active
			Game->flyTroughState ^= 1;
			Player[0].cam()->setAnimateTarget ( Game->flyTroughState == 0 );

			printf ( "collision %d\n", Game->flyTroughState == 0 );
		}
		else
		if ( eve.GUIEvent.Caller == gui.Visible_Map && eve.GUIEvent.EventType == gui::EGET_CHECKBOX_CHANGED )
		{
			bool v = gui.Visible_Map->isChecked();

			if ( MapParent )
			{
				printf ( "static node set visible %d\n",v );
				MapParent->setVisible ( v );
			}
		}
		else
		if ( eve.GUIEvent.Caller == gui.Visible_Shader && eve.GUIEvent.EventType == gui::EGET_CHECKBOX_CHANGED )
		{
			bool v = gui.Visible_Shader->isChecked();

			if ( ShaderParent )
			{
				printf ( "shader node set visible %d\n",v );
				ShaderParent->setVisible ( v );
			}
		}
		else
		if ( eve.GUIEvent.Caller == gui.Visible_Skydome && eve.GUIEvent.EventType == gui::EGET_CHECKBOX_CHANGED )
		{
			if ( SkyNode )
			{
				bool v = !SkyNode->isVisible();
				printf ( "skynode set visible %d\n",v );
				SkyNode->setVisible ( v );
			}
		}
		else
		if ( eve.GUIEvent.Caller == gui.Respawn && eve.GUIEvent.EventType == gui::EGET_BUTTON_CLICKED )
		{
			Player[0].respawn ();
		}

		return false;
	}

	// fire
	if ((eve.EventType == EET_KEY_INPUT_EVENT && eve.KeyInput.Key == KEY_SPACE &&
		eve.KeyInput.PressedDown == false) ||
		(eve.EventType == EET_MOUSE_INPUT_EVENT && eve.MouseInput.Event == EMIE_LMOUSE_LEFT_UP)
		)
	{
		ICameraSceneNode * camera = Game->Device->getSceneManager()->getActiveCamera ();
		if ( camera && camera->isInputReceiverEnabled () )
		{
			useItem( Player + 0 );
		}
	}

	// gui active
	if ((eve.EventType == EET_KEY_INPUT_EVENT && eve.KeyInput.Key == KEY_F1 &&
		eve.KeyInput.PressedDown == false) ||
		(eve.EventType == EET_MOUSE_INPUT_EVENT && eve.MouseInput.Event == EMIE_RMOUSE_LEFT_UP)
		)
	{
		SetGUIActive ( 2 );
	}

	// check if user presses the key
	if ( eve.EventType == EET_KEY_INPUT_EVENT && eve.KeyInput.PressedDown == false)
	{
		// Escape toggles camera Input
		if ( eve.KeyInput.Key == irr::KEY_ESCAPE )
		{
			SetGUIActive ( 3 );
		}
		else
		if (eve.KeyInput.Key == KEY_F11)
		{
			// screenshot are taken without gamma!
			IImage* image = Game->Device->getVideoDriver()->createScreenShot();
			if (image)
			{
				core::vector3df pos;
				core::vector3df rot;
				ICameraSceneNode * cam = Game->Device->getSceneManager()->getActiveCamera ();
				if ( cam )
				{
					pos = cam->getPosition ();
					rot = cam->getRotation ();
				}

				snprintf_irr(buf, 256, "%s_%ls_%.0f_%.0f_%.0f_%.0f_%.0f_%.0f.jpg",
						DRIVER_TYPE_NAMES_SHORT[Game->Device->getVideoDriver()->getDriverType()],
						Game->CurrentMapName.c_str(),
						pos.X, pos.Y, pos.Z,
						rot.X, rot.Y, rot.Z
						);
				path filename ( buf );
				filename.replace ( '/', '_' );
				printf ( "screenshot : %s\n", filename.c_str() );
				Game->Device->getVideoDriver()->writeImageToFile(image, filename, 100 );
				image->drop();
			}
		}
		else
		if (eve.KeyInput.Key == KEY_F9)
		{
			s32 value = EDS_OFF;

			Game->debugState = ( Game->debugState + 1 ) & 3;

			switch ( Game->debugState )
			{
				case 1: value = EDS_NORMALS | EDS_MESH_WIRE_OVERLAY | EDS_BBOX_ALL; break;
				case 2: value = EDS_NORMALS | EDS_MESH_WIRE_OVERLAY | EDS_SKELETON; break;
			}
/*
			// set debug map data on/off
			debugState = debugState == EDS_OFF ?
				EDS_NORMALS | EDS_MESH_WIRE_OVERLAY | EDS_BBOX_ALL:
				EDS_OFF;
*/
			if ( ItemParent )
			{
				list<ISceneNode*>::ConstIterator it = ItemParent->getChildren().begin();
				for (; it != ItemParent->getChildren().end(); ++it)
				{
					(*it)->setDebugDataVisible ( value );
				}
			}

			if ( ShaderParent )
			{
				list<ISceneNode*>::ConstIterator it = ShaderParent->getChildren().begin();
				for (; it != ShaderParent->getChildren().end(); ++it)
				{
					(*it)->setDebugDataVisible ( value );
				}
			}

			if ( UnresolvedParent )
			{
				list<ISceneNode*>::ConstIterator it = UnresolvedParent->getChildren().begin();
				for (; it != UnresolvedParent->getChildren().end(); ++it)
				{
					(*it)->setDebugDataVisible ( value );
				}
			}

			if ( FogParent )
			{
				list<ISceneNode*>::ConstIterator it = FogParent->getChildren().begin();
				for (; it != FogParent->getChildren().end(); ++it)
				{
					(*it)->setDebugDataVisible ( value );
				}
			}

			if ( SkyNode )
			{
				SkyNode->setDebugDataVisible ( value );
			}

		}
		else
		if (eve.KeyInput.Key == KEY_F8)
		{
			// set gravity on/off
			Game->gravityState ^= 1;
			Player[0].cam()->setGravity ( getGravity ( Game->gravityState ? "earth" : "none" ) );
			printf ( "gravity %s\n", Game->gravityState ? "earth" : "none" );
		}
		else
		if (eve.KeyInput.Key == KEY_F7)
		{
			// set fly through active
			Game->flyTroughState ^= 1;
			Player[0].cam()->setAnimateTarget ( Game->flyTroughState == 0 );
			if ( gui.Collision )
				gui.Collision->setChecked ( Game->flyTroughState == 0 );

			printf ( "collision %d\n", Game->flyTroughState == 0 );
		}
		else
		if (eve.KeyInput.Key == KEY_F2)
		{
			Player[0].respawn ();
		}
		else
		if (eve.KeyInput.Key == KEY_F3)
		{
			if ( MapParent )
			{
				bool v = !MapParent->isVisible ();
				printf ( "static node set visible %d\n",v );
				MapParent->setVisible ( v );
				if ( gui.Visible_Map )
					gui.Visible_Map->setChecked ( v );
			}
		}
		else
		if (eve.KeyInput.Key == KEY_F4)
		{
			if ( ShaderParent )
			{
				bool v = !ShaderParent->isVisible ();
				printf ( "shader node set visible %d\n",v );
				ShaderParent->setVisible ( v );
				if ( gui.Visible_Shader )
					gui.Visible_Shader->setChecked ( v );
			}
		}
		else
		if (eve.KeyInput.Key == KEY_F5)
		{
			if ( FogParent )
			{
				bool v = !FogParent->isVisible ();
				printf ( "fog node set visible %d\n",v );
				FogParent->setVisible ( v );
				if ( gui.Visible_Fog )
					gui.Visible_Fog->setChecked ( v );
			}

		}
		else
		if (eve.KeyInput.Key == KEY_F6)
		{
			if ( UnresolvedParent )
			{
				bool v = !UnresolvedParent->isVisible ();
				printf ( "unresolved node set visible %d\n",v );
				UnresolvedParent->setVisible ( v );
				if ( gui.Visible_Unresolved )
					gui.Visible_Unresolved->setChecked ( v );
			}
		}
	}

	// check if user presses the key C ( for crouch)
	if ( eve.EventType == EET_KEY_INPUT_EVENT && eve.KeyInput.Key == KEY_KEY_C )
	{
		// crouch
		ISceneNodeAnimatorCollisionResponse *anim = Player[0].cam ();
		if ( anim && 0 == Game->flyTroughState )
		{
			if ( false == eve.KeyInput.PressedDown )
			{
				// stand up
				anim->setEllipsoidRadius (  vector3df(30,45,30) );
				anim->setEllipsoidTranslation ( vector3df(0,40,0));

			}
			else
			{
				// on your knees
				anim->setEllipsoidRadius (  vector3df(30,20,30) );
				anim->setEllipsoidTranslation ( vector3df(0,20,0));
			}
			return true;
		}
	}
	return false;
}



/*
	useItem
*/
void CQuake3EventHandler::useItem( Q3Player * player)
{
	ISceneManager* smgr = Game->Device->getSceneManager();
	ICameraSceneNode* camera = smgr->getActiveCamera();

	if (!camera)
		return;

	SParticleImpact imp;
	imp.when = 0;

	// get line of camera

	vector3df start = camera->getPosition();

	if ( player->WeaponNode )
	{
		start.X += 0.f;
		start.Y += 0.f;
		start.Z += 0.f;
	}

	vector3df end = (camera->getTarget() - start);
	end.normalize();
	start += end*20.0f;

	end = start + (end * camera->getFarValue());

	triangle3df triangle;
	line3d<f32> line(start, end);

	// get intersection point with map
	scene::ISceneNode* hitNode;
	if (smgr->getSceneCollisionManager()->getCollisionPoint(
		line, Meta, end, triangle,hitNode))
	{
		// collides with wall
		vector3df out = triangle.getNormal();
		out.setLength(0.03f);

		imp.when = 1;
		imp.outVector = out;
		imp.pos = end;

		player->setAnim ( "pow" );
		player->Anim[1].next += player->Anim[1].delta;
	}
	else
	{
		// doesnt collide with wall
		vector3df start = camera->getPosition();
		if ( player->WeaponNode )
		{
			//start.X += 10.f;
			//start.Y += -5.f;
			//start.Z += 1.f;
		}

		vector3df end = (camera->getTarget() - start);
		end.normalize();
		start += end*20.0f;
		end = start + (end * camera->getFarValue());
	}

	// create fire ball
	ISceneNode* node = 0;
	node = smgr->addBillboardSceneNode( BulletParent,dimension2d<f32>(10,10), start);

	node->setMaterialFlag(EMF_LIGHTING, false);
	node->setMaterialTexture(0, Game->Device->getVideoDriver()->getTexture("fireball.bmp"));
	node->setMaterialFlag(video::EMF_ZWRITE_ENABLE, false);
	node->setMaterialType(EMT_TRANSPARENT_ADD_COLOR);

	f32 length = (f32)(end - start).getLength();
	const f32 speed = 5.8f;
	u32 time = (u32)(length / speed);

	ISceneNodeAnimator* anim = 0;

	// set flight line

	anim = smgr->createFlyStraightAnimator(start, end, time);
	node->addAnimator(anim);
	anim->drop();

	snprintf_irr ( buf, 64, "bullet: %s on %.1f,%1.f,%1.f",
				imp.when ? "hit" : "nohit", end.X, end.Y, end.Z );
	node->setName ( buf );


	anim = smgr->createDeleteAnimator(time);
	node->addAnimator(anim);
	anim->drop();

	if (imp.when)
	{
		// create impact note
		imp.when = Game->Device->getTimer()->getTime() +
			(time + (s32) ( ( 1.f + Noiser::get() ) * 250.f ));
		Impacts.push_back(imp);
	}

	// play sound
}

// rendered when bullets hit something
void CQuake3EventHandler::createParticleImpacts( u32 now )
{
	ISceneManager* sm = Game->Device->getSceneManager();

	struct smokeLayer
	{
		const c8 * texture;
		f32 scale;
		f32 minparticleSize;
		f32 maxparticleSize;
		f32 boxSize;
		u32 minParticle;
		u32 maxParticle;
		u32 fadeout;
		u32 lifetime;
	};

	smokeLayer smoke[] =
	{
		{ "smoke2.jpg", 0.4f, 1.5f, 18.f, 20.f, 20, 50, 2000, 10000 },
		{ "smoke3.jpg", 0.2f, 1.2f, 15.f, 20.f, 10, 30, 1000, 12000 }
	};


	u32 i;
	u32 g;
	s32 factor = 1;
	for ( g = 0; g != 2; ++g )
	{
		smoke[g].minParticle *= factor;
		smoke[g].maxParticle *= factor;
		smoke[g].lifetime *= factor;
		smoke[g].boxSize *= Noiser::get() * 0.5f;
	}

	for ( i=0; i < Impacts.size(); ++i)
	{
		if (now < Impacts[i].when)
			continue;

		// create smoke particle system
		IParticleSystemSceneNode* pas = 0;

		for ( g = 0; g != 2; ++g )
		{
			pas = sm->addParticleSystemSceneNode(false, BulletParent, -1, Impacts[i].pos);

			snprintf_irr ( buf, 64, "bullet impact smoke at %.1f,%.1f,%1.f",
				Impacts[i].pos.X,Impacts[i].pos.Y,Impacts[i].pos.Z);
			pas->setName ( buf );

			// create a flat smoke
			vector3df direction = Impacts[i].outVector;
			direction *= smoke[g].scale;
			IParticleEmitter* em = pas->createBoxEmitter(
				aabbox3d<f32>(-4.f,0.f,-4.f,20.f,smoke[g].minparticleSize,20.f),
				direction,smoke[g].minParticle, smoke[g].maxParticle,
				video::SColor(0,0,0,0),video::SColor(0,128,128,128),
				250,4000, 60);

			em->setMinStartSize (dimension2d<f32>( smoke[g].minparticleSize, smoke[g].minparticleSize));
			em->setMaxStartSize (dimension2d<f32>( smoke[g].maxparticleSize, smoke[g].maxparticleSize));

			pas->setEmitter(em);
			em->drop();

			// particles get invisible
			IParticleAffector* paf = pas->createFadeOutParticleAffector(
				video::SColor ( 0, 0, 0, 0 ), smoke[g].fadeout);
			pas->addAffector(paf);
			paf->drop();

			// particle system life time
			ISceneNodeAnimator* anim = sm->createDeleteAnimator( smoke[g].lifetime);
			pas->addAnimator(anim);
			anim->drop();

			pas->setMaterialFlag(video::EMF_LIGHTING, false);
			pas->setMaterialFlag(video::EMF_ZWRITE_ENABLE, false);
			pas->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR );
			pas->setMaterialTexture(0, Game->Device->getVideoDriver()->getTexture( smoke[g].texture ));
		}


		// play impact sound
		#ifdef USE_IRRKLANG
/*
		if (irrKlang)
		{
			audio::ISound* sound =
				irrKlang->play3D(impactSound, Impacts[i].pos, false, false, true);

			if (sound)
			{
				// adjust max value a bit to make to sound of an impact louder
				sound->setMinDistance(400);
				sound->drop();
			}
		}
*/
		#endif


		// delete entry
		Impacts.erase(i);
		i--;
	}
}

/*
	render
*/
void CQuake3EventHandler::Render()
{
	IVideoDriver * driver = Game->Device->getVideoDriver();
	if ( 0 == driver )
		return;

	// TODO: This does not work, yet.
	const bool anaglyph=false;
	if (anaglyph)
	{
		scene::ICameraSceneNode* cameraOld = Game->Device->getSceneManager()->getActiveCamera();
		driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, SColor(0,0,0,0));
		driver->getOverrideMaterial().Material.ColorMask = ECP_NONE;
		driver->getOverrideMaterial().EnableFlags  = EMF_COLOR_MASK;
        driver->getOverrideMaterial().EnablePasses = ESNRP_SKY_BOX +
                                                     ESNRP_SOLID +
                                                     ESNRP_TRANSPARENT +
                                                     ESNRP_TRANSPARENT_EFFECT +
                                                     ESNRP_SHADOW;
		Game->Device->getSceneManager()->drawAll();
		driver->clearBuffers(video::ECBF_DEPTH, video::SColor(255,0,0,0));

		const vector3df oldPosition = cameraOld->getPosition();
		const vector3df oldTarget   = cameraOld->getTarget();
		const matrix4 startMatrix   = cameraOld->getAbsoluteTransformation();
		const vector3df focusPoint  = (oldTarget -
				cameraOld->getAbsolutePosition()).setLength(10000) +
				cameraOld->getAbsolutePosition() ;

		scene::ICameraSceneNode* camera = cameraOld;//Game->Device->getSceneManager()->addCameraSceneNode();

		//Left eye...
		vector3df pos;
		matrix4   move;

		move.setTranslation( vector3df(-1.5f,0.0f,0.0f) );
		pos=(startMatrix*move).getTranslation();

		driver->getOverrideMaterial().Material.ColorMask = ECP_RED;
		driver->getOverrideMaterial().EnableFlags  = EMF_COLOR_MASK;
		driver->getOverrideMaterial().EnablePasses =
				ESNRP_SKY_BOX|ESNRP_SOLID|ESNRP_TRANSPARENT|
				ESNRP_TRANSPARENT_EFFECT|ESNRP_SHADOW;

		camera->setPosition(pos);
		camera->setTarget(focusPoint);

		Game->Device->getSceneManager()->drawAll();
		driver->clearBuffers(video::ECBF_DEPTH, video::SColor(255, 0, 0, 0));

		//Right eye...
		move.setTranslation( vector3df(1.5f,0.0f,0.0f) );
		pos=(startMatrix*move).getTranslation();

		driver->getOverrideMaterial().Material.ColorMask = ECP_GREEN + ECP_BLUE;
		driver->getOverrideMaterial().EnableFlags  = EMF_COLOR_MASK;
		driver->getOverrideMaterial().EnablePasses =
				ESNRP_SKY_BOX|ESNRP_SOLID|ESNRP_TRANSPARENT|
				ESNRP_TRANSPARENT_EFFECT|ESNRP_SHADOW;

		camera->setPosition(pos);
		camera->setTarget(focusPoint);

		Game->Device->getSceneManager()->drawAll();

		driver->getOverrideMaterial().Material.ColorMask=ECP_ALL;
		driver->getOverrideMaterial().EnableFlags=0;
		driver->getOverrideMaterial().EnablePasses=0;

		if (camera != cameraOld)
		{
			Game->Device->getSceneManager()->setActiveCamera(cameraOld);
			camera->remove();
		}
		else
		{
			camera->setPosition(oldPosition);
			camera->setTarget(oldTarget);
		}
	}
	else
	{
		driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, SColor(0,0,0,0));
		Game->Device->getSceneManager()->drawAll();
	}
	Game->Device->getGUIEnvironment()->drawAll();
	driver->endScene();
}

/*
	update the generic scene node
*/
void CQuake3EventHandler::Animate()
{
	u32 now = Game->Device->getTimer()->getTime();

	Q3Player * player = Player + 0;

	checkTimeFire ( player->Anim, 4, now );

	// Query Scene Manager attributes
	if ( player->Anim[0].flags & FIRED )
	{
		wchar_t msg[128];
		IVideoDriver * driver = Game->Device->getVideoDriver();

#ifdef _IRR_SCENEMANAGER_DEBUG
		IAttributes * attr = Game->Device->getSceneManager()->getParameters();
		swprintf_irr ( msg, 128,
			L"Q3 %s [%ls], FPS:%03d Tri:%.03fm Cull %d/%d nodes (%d,%d,%d)",
			Game->CurrentMapName.c_str(),
			driver->getName(),
			driver->getFPS (),
			(f32) driver->getPrimitiveCountDrawn( 0 ) * ( 1.f / 1000000.f ),
			attr->getAttributeAsInt ( "culled" ),
			attr->getAttributeAsInt ( "calls" ),
			attr->getAttributeAsInt ( "drawn_solid" ),
			attr->getAttributeAsInt ( "drawn_transparent" ),
			attr->getAttributeAsInt ( "drawn_transparent_effect" )
			);
#else
swprintf_irr ( msg, 128,
			L"Q3 %s [%ls], FPS:%03d Tri:%.03fm",
			Game->CurrentMapName.c_str(),
			driver->getName(),
			driver->getFPS (),
			(f32) driver->getPrimitiveCountDrawn( 0 ) * ( 1.f / 1000000.f )
			);
#endif
		Game->Device->setWindowCaption( msg );

		swprintf_irr ( msg, 128,
					L"%03d fps, F1 GUI on/off, F2 respawn, F3-F6 toggle Nodes, F7 Collision on/off"
					L", F8 Gravity on/off, Right Mouse Toggle GUI",
					Game->Device->getVideoDriver()->getFPS ()
				);
		if ( gui.StatusLine )
			gui.StatusLine->setText ( msg );
		player->Anim[0].flags &= ~FIRED;
	}

	// idle..
	if ( player->Anim[1].flags & FIRED )
	{
		if ( strcmp ( player->animation, "idle" ) )
			player->setAnim ( "idle" );

		player->Anim[1].flags &= ~FIRED;
	}

	createParticleImpacts ( now );

}


/* The main game states
*/
void runGame ( GameData *game )
{
	if ( game->retVal >= 3 )
		return;

	game->Device = (*game->createExDevice) ( game->deviceParam );
	if ( 0 == game->Device)
	{
		// could not create selected driver.
		game->retVal = 0;
		return;
	}

	// create an event receiver based on current game data
	CQuake3EventHandler *eventHandler = new CQuake3EventHandler( game );

	// load stored config
	game->load ( "explorer.cfg" );

	// add our media directory and archive to the file system
	for ( u32 i = 0; i < game->CurrentArchiveList.size(); ++i )
	{
		eventHandler->AddArchive ( game->CurrentArchiveList[i] );
	}

	// Load a Map or startup to the GUI
	if ( game->CurrentMapName.size () )
	{
		eventHandler->LoadMap ( game->CurrentMapName, 1 );
		if ( 0 == game->loadParam.loadSkyShader )
			eventHandler->AddSky ( 1, "skydome2" );
		eventHandler->CreatePlayers ();
		eventHandler->CreateGUI ();
		eventHandler->SetGUIActive ( 0 );

		// set player to last position on restart
		if ( game->retVal == 2 )
		{
			eventHandler->GetPlayer( 0 )->setpos ( game->PlayerPosition, game->PlayerRotation );
		}
	}
	else
	{
		// start up empty
		eventHandler->AddSky ( 1, "skydome2" );
		eventHandler->CreatePlayers ();
		eventHandler->CreateGUI ();
		eventHandler->SetGUIActive ( 1 );
		background_music ( "IrrlichtTheme.ogg" );
	}


	game->retVal = 3;
	while( game->Device->run() )
	{
		eventHandler->Animate ();
		eventHandler->Render ();
		//if ( !game->Device->isWindowActive() )
			game->Device->yield();
	}

	game->Device->setGammaRamp ( 1.f, 1.f, 1.f, 0.f, 0.f );
	delete eventHandler;
}

#if defined (_IRR_WINDOWS_) && 0
	#pragma comment(linker, "/subsystem:windows /ENTRY:mainCRTStartup")
#endif


/* The main routine, doing all setup
*/
int IRRCALLCONV main(int argc, char* argv[])
{
	path prgname(argv[0]);
	GameData game ( deletePathFromPath ( prgname, 1 ) );

	// dynamically load irrlicht
	const c8 * dllName = argc > 1 ? argv[1] : "irrlicht.dll";
	game.createExDevice = load_createDeviceEx ( dllName );
	if ( 0 == game.createExDevice )
	{
		game.retVal = 3;
		printf ( "Could not load %s.\n", dllName );
		return game.retVal; // could not load dll
	}

	// start without asking for driver
	game.retVal = 1;
	do
	{
		// if driver could not created, ask for another driver
		if ( game.retVal == 0 )
		{
			game.setDefault ();
			// ask user for driver
			game.deviceParam.DriverType=driverChoiceConsole();
			if (game.deviceParam.DriverType==video::EDT_COUNT)
				game.retVal = 3;
		}
		runGame ( &game );
	} while ( game.retVal < 3 );

	return game.retVal;
}

/*
**/
