/*!
	Model Factory.
	create the additional scenenodes for ( bullets, health... )

	Defines the Entities for Quake3
*/

#include <irrlicht.h>
#include "q3factory.h"
#include "sound.h"

using namespace irr;
using namespace scene;
using namespace gui;
using namespace video;
using namespace core;
using namespace quake3;

//! This list is based on the original quake3.
static const SItemElement Quake3ItemElement [] = {
{	"item_health",
	{"models/powerups/health/medium_cross.md3",
	"models/powerups/health/medium_sphere.md3"},
	"sound/items/n_health.wav",
	"icons/iconh_yellow",
	"25 Health",
	25,
	HEALTH,
	SUB_NONE,
	SPECIAL_SFX_BOUNCE | SPECIAL_SFX_ROTATE_1
},
{	"item_health_large",
	"models/powerups/health/large_cross.md3",
	"models/powerups/health/large_sphere.md3",
	"sound/items/l_health.wav",
	"icons/iconh_red",
	"50 Health",
	50,
	HEALTH,
	SUB_NONE,
	SPECIAL_SFX_BOUNCE | SPECIAL_SFX_ROTATE_1
},
{
	"item_health_mega",
	"models/powerups/health/mega_cross.md3",
	"models/powerups/health/mega_sphere.md3",
	"sound/items/m_health.wav",
	"icons/iconh_mega",
	"Mega Health",
	100,
	HEALTH,
	SUB_NONE,
	SPECIAL_SFX_BOUNCE | SPECIAL_SFX_ROTATE_1
},
{
	"item_health_small",
	"models/powerups/health/small_cross.md3",
	"models/powerups/health/small_sphere.md3",
	"sound/items/s_health.wav",
	"icons/iconh_green",
	"5 Health",
	5,
	HEALTH,
	SUB_NONE,
	SPECIAL_SFX_BOUNCE | SPECIAL_SFX_ROTATE_1
},
{	"ammo_bullets",
	"models/powerups/ammo/machinegunam.md3",
	"",
	"sound/misc/am_pkup.wav",
	"icons/icona_machinegun",
	"Bullets",
	50,
	AMMO,
	MACHINEGUN,
	SPECIAL_SFX_BOUNCE,
},
{
	"ammo_cells",
	"models/powerups/ammo/plasmaam.md3",
	"",
	"sound/misc/am_pkup.wav",
	"icons/icona_plasma",
	"Cells",
	30,
	AMMO,
	PLASMAGUN,
	SPECIAL_SFX_BOUNCE
},
{	"ammo_rockets",
	"models/powerups/ammo/rocketam.md3",
	"",
	"",
	"icons/icona_rocket",
	"Rockets",
	5,
	AMMO,
	ROCKET_LAUNCHER,
	SPECIAL_SFX_ROTATE
},
{
	"ammo_shells",
	"models/powerups/ammo/shotgunam.md3",
	"",
	"sound/misc/am_pkup.wav",
	"icons/icona_shotgun",
	"Shells",
	10,
	AMMO,
	SHOTGUN,
	SPECIAL_SFX_ROTATE
},
{
	"ammo_slugs",
	"models/powerups/ammo/railgunam.md3",
	"",
	"sound/misc/am_pkup.wav",
	"icons/icona_railgun",
	"Slugs",
	10,
	AMMO,
	RAILGUN,
	SPECIAL_SFX_ROTATE
},
{
	"item_armor_body",
	"models/powerups/armor/armor_red.md3",
	"",
	"sound/misc/ar2_pkup.wav",
	"icons/iconr_red",
	"Heavy Armor",
	100,
	ARMOR,
	SUB_NONE,
	SPECIAL_SFX_ROTATE
},
{
	"item_armor_combat",
	"models/powerups/armor/armor_yel.md3",
	"",
	"sound/misc/ar2_pkup.wav",
	"icons/iconr_yellow",
	"Armor",
	50,
	ARMOR,
	SUB_NONE,
	SPECIAL_SFX_ROTATE
},
{
	"item_armor_shard",
	"models/powerups/armor/shard.md3",
	"",
	"sound/misc/ar1_pkup.wav",
	"icons/iconr_shard",
	"Armor Shared",
	5,
	ARMOR,
	SUB_NONE,
	SPECIAL_SFX_ROTATE
},
{
	"weapon_gauntlet",
	"models/weapons2/gauntlet/gauntlet.md3",
	"",
	"sound/misc/w_pkup.wav",
	"icons/iconw_gauntlet",
	"Gauntlet",
	0,
	WEAPON,
	GAUNTLET,
	SPECIAL_SFX_ROTATE
},
{
	"weapon_shotgun",
	"models/weapons2/shotgun/shotgun.md3",
	"",
	"sound/misc/w_pkup.wav",
	"icons/iconw_shotgun",
	"Shotgun",
	10,
	WEAPON,
	SHOTGUN,
	SPECIAL_SFX_ROTATE
},
{
	"weapon_machinegun",
	"models/weapons2/machinegun/machinegun.md3",
	"",
	"sound/misc/w_pkup.wav",
	"icons/iconw_machinegun",
	"Machinegun",
	40,
	WEAPON,
	MACHINEGUN,
	SPECIAL_SFX_ROTATE
},
{
	"weapon_grenadelauncher",
	"models/weapons2/grenadel/grenadel.md3",
	"",
	"sound/misc/w_pkup.wav",
	"icons/iconw_grenade",
	"Grenade Launcher",
	10,
	WEAPON,
	GRENADE_LAUNCHER,
	SPECIAL_SFX_ROTATE
},
{
	"weapon_rocketlauncher",
	"models/weapons2/rocketl/rocketl.md3",
	"",
	"sound/misc/w_pkup.wav",
	"icons/iconw_rocket",
	"Rocket Launcher",
	10,
	WEAPON,
	ROCKET_LAUNCHER,
	SPECIAL_SFX_ROTATE
},
{
	"weapon_lightning",
	"models/weapons2/lightning/lightning.md3",
	"",
	"sound/misc/w_pkup.wav",
	"icons/iconw_lightning",
	"Lightning Gun",
	100,
	WEAPON,
	LIGHTNING,
	SPECIAL_SFX_ROTATE
},
{
	"weapon_railgun",
	"models/weapons2/railgun/railgun.md3",
	"",
	"sound/misc/w_pkup.wav",
	"icons/iconw_railgun",
	"Railgun",
	10,
	WEAPON,
	RAILGUN,
	SPECIAL_SFX_ROTATE
},
{
	"weapon_plasmagun",
	"models/weapons2/plasma/plasma.md3",
	"",
	"sound/misc/w_pkup.wav",
	"icons/iconw_plasma",
	"Plasma Gun",
	50,
	WEAPON,
	PLASMAGUN,
	SPECIAL_SFX_ROTATE
},
{
	"weapon_bfg",
	"models/weapons2/bfg/bfg.md3",
	"",
	"sound/misc/w_pkup.wav",
	"icons/iconw_bfg",
	"BFG10K",
	20,
	WEAPON,
	BFG,
	SPECIAL_SFX_ROTATE
},
{
	"weapon_grapplinghook",
	"models/weapons2/grapple/grapple.md3",
	"",
	"sound/misc/w_pkup.wav",
	"icons/iconw_grapple",
	"Grappling Hook",
	0,
	WEAPON,
	GRAPPLING_HOOK,
	SPECIAL_SFX_ROTATE
},
{
	0
}

};


/*!
*/
const SItemElement * getItemElement ( const stringc& key )
{
	const SItemElement *item = Quake3ItemElement;

	while ( item->key )
	{
		if ( 0 == strcmp ( key.c_str(), item->key ) )
			return item;
		item += 1;
	}
	return 0;
}

/*!
	Quake3 Model Factory.
	Takes the mesh buffers and creates scenenodes for their associated shaders
*/
void Q3ShaderFactory (	Q3LevelLoadParameter &loadParam,
						IrrlichtDevice *device,
						IQ3LevelMesh* mesh,
						eQ3MeshIndex meshIndex,
						ISceneNode *parent,
						IMetaTriangleSelector *meta,
						bool showShaderName )
{
	if ( 0 == mesh || 0 == device )
		return;

	IMeshSceneNode* node = 0;
	ISceneManager* smgr = device->getSceneManager();
	ITriangleSelector * selector = 0;

	// the additional mesh can be quite huge and is unoptimized
	// Save to cast to SMesh
	SMesh * additional_mesh = (SMesh*) mesh->getMesh ( meshIndex );
	if ( 0 == additional_mesh || additional_mesh->getMeshBufferCount() == 0)
		return;

	char buf[128];
	if ( loadParam.verbose > 0 )
	{
		loadParam.startTime = device->getTimer()->getRealTime();
		if ( loadParam.verbose > 1 )
		{
			snprintf_irr(buf, 128, "q3shaderfactory start" );
			device->getLogger()->log( buf, ELL_INFORMATION);
		}
	}

	IGUIFont *font = 0;
	if ( showShaderName )
		font = device->getGUIEnvironment()->getFont("fontlucida.png");

	IVideoDriver *driver = device->getVideoDriver();

	// create helper textures
	if ( 1 )
	{
		tTexArray tex;
		u32 pos = 0;
		getTextures ( tex, "$redimage $blueimage $whiteimage $checkerimage", pos,
								device->getFileSystem(), driver );
	}

	s32 sceneNodeID = 0;
	for ( u32 i = 0; i!= additional_mesh->getMeshBufferCount (); ++i )
	{
		IMeshBuffer *meshBuffer = additional_mesh->getMeshBuffer ( i );
		const SMaterial &material = meshBuffer->getMaterial();

		//! The ShaderIndex is stored in the second material parameter
		s32 shaderIndex = (s32) material.MaterialTypeParam2;

		// the meshbuffer can be rendered without additional support, or it has no shader
		IShader *shader = (IShader *) mesh->getShader ( shaderIndex );

		// no shader, or mapped to existing material
		if ( 0 == shader )
		{

#if 1
			// clone mesh
			SMesh * m = new SMesh ();
			m->addMeshBuffer ( meshBuffer );
			SMaterial &mat = m->getMeshBuffer( 0 )->getMaterial();
			if ( mat.getTexture( 0 ) == 0 )
				mat.setTexture ( 0, driver->getTexture ( "$blueimage" ) );
			if ( mat.getTexture( 1 ) == 0 )
				mat.setTexture ( 1, driver->getTexture ( "$redimage" ) );

			IMesh * store = smgr->getMeshManipulator ()->createMeshWith2TCoords ( m );
			m->drop();

			node = smgr->addMeshSceneNode ( store,  parent, sceneNodeID );
			node->setAutomaticCulling ( scene::EAC_OFF );
			store->drop ();
			sceneNodeID += 1;
#endif
		}
		else if ( 1 )
		{
/*
			stringc s;
			dumpShader ( s, shader );
			printf ( s.c_str () );
*/
			// create sceneNode
			node = smgr->addQuake3SceneNode ( meshBuffer, shader, parent, sceneNodeID );
			node->setAutomaticCulling ( scene::EAC_FRUSTUM_BOX );
			sceneNodeID += 1;
		}

		// show Debug Shader Name
		if ( showShaderName && node )
		{
			swprintf_irr ( (wchar_t*) buf, 64, L"%hs:%d", node->getName(),node->getID() );
			smgr->addBillboardTextSceneNode(
					font,
					(wchar_t*) buf,
					node,
					dimension2d<f32>(80.0f, 8.0f),
					vector3df(0, 10, 0),
					sceneNodeID);
			sceneNodeID += 1;
		}

		// create Portal Rendertargets
		if ( shader )
		{
			const SVarGroup *group = shader->getGroup(1);
			if ( group->isDefined( "surfaceparm", "portal" ) )
			{
			}

		}


		// add collision
		// find out if shader is marked as nonsolid
		u8 doCreate = meta !=0  ;

		if ( shader )
		{
			const SVarGroup *group = shader->getGroup(1);
			if (	group->isDefined( "surfaceparm", "trans" )
					// || group->isDefined( "surfaceparm", "sky" )
					// || group->isDefined( "surfaceparm", "nonsolid" )
				)
			{
				if ( !group->isDefined( "surfaceparm", "metalsteps" ) )
				{
					doCreate = 0;
				}
			}
		}

		if ( doCreate )
		{
			IMesh *m = 0;

			//! controls if triangles are modified by the scenenode during runtime
			bool takeOriginal = true;

			if ( takeOriginal )
			{
				m = new SMesh ();
				((SMesh*) m )->addMeshBuffer (meshBuffer);
			}
			else
			{
				m = node->getMesh();
			}

			//selector = smgr->createOctreeTriangleSelector ( m, 0, 128 );
			selector = smgr->createTriangleSelector ( m, 0 );
			meta->addTriangleSelector ( selector );
			selector->drop ();

			if ( takeOriginal )
			{
				delete m;
			}
		}

	}

#if 0
	if ( meta )
	{
		selector = smgr->createOctreeTriangleSelector ( additional_mesh, 0 );
		meta->addTriangleSelector ( selector );
		selector->drop ();
	}
#endif

	if ( loadParam.verbose > 0 )
	{
		loadParam.endTime = device->getTimer()->getRealTime ();
		snprintf_irr(buf, 128, "q3shaderfactory needed %04d ms to create %d shader nodes",
			loadParam.endTime - loadParam.startTime,
			sceneNodeID
			);
		device->getLogger()->log(buf, ELL_INFORMATION);
	}

}


/*!
	create Items from Entity
*/
void Q3ModelFactory (	Q3LevelLoadParameter &loadParam,
						IrrlichtDevice *device,
						IQ3LevelMesh* masterMesh,
						ISceneNode *parent,
						bool showShaderName
						)
{
	if ( 0 == masterMesh )
		return;

	tQ3EntityList &entity = masterMesh->getEntityList ();
	ISceneManager* smgr = device->getSceneManager();


	char buf[128];
	const SVarGroup *group;
	IEntity search;
	s32 index;
	s32 lastIndex;

/*
	stringc s;
	FILE *f = 0;
	f = fopen ( "entity.txt", "wb" );
	for ( index = 0; (u32) index < entityList.size (); ++index )
	{
		const IEntity *entity = &entityList[ index ];
		s = entity->name;
		dumpShader ( s, entity );
		fwrite ( s.c_str(), 1, s.size(), f );
	}
	fclose ( f );
*/
	IAnimatedMeshMD3* model;
	SMD3Mesh * mesh;
	const SMD3MeshBuffer *meshBuffer;
	IMeshSceneNode* node;
	ISceneNodeAnimator* anim;
	const IShader *shader;
	u32 pos;
	vector3df p;
	u32 nodeCount = 0;
	tTexArray textureArray;

	IGUIFont *font = 0;
	if ( showShaderName )
		font = device->getGUIEnvironment()->getFont("fontlucida.png");

	const SItemElement *itemElement;

	// walk list
	for ( index = 0; (u32) index < entity.size(); ++index )
	{
		itemElement = getItemElement ( entity[index].name );
		if ( 0 == itemElement )
			continue;

		pos = 0;
		p = getAsVector3df ( entity[index].getGroup(1)->get ( "origin" ), pos );

		nodeCount += 1;
		for ( u32 g = 0; g < 2; ++g )
		{
			if ( 0 == itemElement->model[g] || itemElement->model[g][0] == 0 )
				continue;
			model = (IAnimatedMeshMD3*) smgr->getMesh( itemElement->model[g] );
			if ( 0 == model )
				continue;

			mesh = model->getOriginalMesh();
			for ( u32 j = 0; j != mesh->Buffer.size (); ++j )
			{
				meshBuffer = mesh->Buffer[j];
				if ( 0 == meshBuffer )
					continue;

				shader = masterMesh->getShader ( meshBuffer->Shader.c_str(), false );
				IMeshBuffer *final = model->getMesh(0)->getMeshBuffer(j);
				if ( shader )
				{
					//!TODO: Hack don't modify the vertexbuffer. make it better;-)
					final->getMaterial().ColorMask = 0;
					node = smgr->addQuake3SceneNode ( final, shader, parent );
					final->getMaterial().ColorMask = 15;
				}
				else
				{
					// clone mesh
					SMesh * m = new SMesh ();
					m->addMeshBuffer ( final );
					node = smgr->addMeshSceneNode ( m,  parent );
					m->drop();
				}

				if ( 0 == node )
				{
					snprintf_irr ( buf, 128, "q3ModelFactory shader %s failed", meshBuffer->Shader.c_str() );
					device->getLogger()->log ( buf );
					continue;
				}

				// node was maybe centered by shaderscenenode
				node->setPosition ( p );
				node->setName ( meshBuffer->Shader );
				node->setAutomaticCulling ( scene::EAC_BOX );

				// add special effects to node
				if (	itemElement->special & SPECIAL_SFX_ROTATE ||
						(g == 0 && itemElement->special & SPECIAL_SFX_ROTATE_1)
					)
				{
					anim = smgr->createRotationAnimator ( vector3df ( 0.f,
						2.f, 0.f ) );
					node->addAnimator ( anim );
					anim->drop ();
				}

				if ( itemElement->special & SPECIAL_SFX_BOUNCE )
				{
					//anim = smgr->createFlyStraightAnimator (
					//	p, p + vector3df ( 0.f, 60.f, 0.f ), 1000, true, true );
					anim = smgr->createFlyCircleAnimator (
						p + vector3df( 0.f, 20.f, 0.f ),
						20.f,
						0.005f,
						vector3df ( 1.f, 0.f, 0.f ),
						core::fract ( nodeCount * 0.05f ),
						1.f
						);
					node->addAnimator ( anim );
					anim->drop ();
				}
			}
		}
		// show name
		if ( showShaderName )
		{
			swprintf_irr ( (wchar_t*) buf, sizeof(buf) / 2, L"%hs", itemElement->key );
			smgr->addBillboardTextSceneNode(
					font,
					(wchar_t*) buf,
					parent,
					dimension2d<f32>(80.0f, 8.0f),
					p + vector3df(0, 30, 0),
					0);
		}
	}

	// music
	search.name = "worldspawn";
	index = entity.binary_search_multi ( search, lastIndex );

	if ( index >= 0 )
	{
		group = entity[ index ].getGroup(1);
		background_music ( group->get ( "music" ).c_str () );
	}

	// music
	search.name = "worldspawn";
	index = entity.binary_search_multi ( search, lastIndex );

	if ( index >= 0 )
	{
		group = entity[ index ].getGroup(1);
		background_music ( group->get ( "music" ).c_str () );
	}

	//IAnimatedMesh* mesh = smgr->getMesh("../../media/sydney.md2");
	//IAnimatedMeshSceneNode* node = smgr->addAnimatedMeshSceneNode( mesh );

}

/*!
	so we need a good starting Position in the level.
	we can ask the Quake3 Loader for all entities with class_name "info_player_deathmatch"
*/
s32 Q3StartPosition (	IQ3LevelMesh* mesh,
						ICameraSceneNode* camera,
						s32 startposIndex,
						const vector3df &translation
					)
{
	if ( 0 == mesh )
		return 0;

	tQ3EntityList &entityList = mesh->getEntityList ();

	IEntity search;
	search.name = "info_player_start";	// "info_player_deathmatch";

	// find all entities in the multi-list
	s32 lastIndex;
	s32 index = entityList.binary_search_multi ( search, lastIndex );

	if ( index < 0 )
	{
		search.name = "info_player_deathmatch";
		index = entityList.binary_search_multi ( search, lastIndex );
	}

	if ( index < 0 )
		return 0;

	index += core::clamp ( startposIndex, 0, lastIndex - index );

	u32 parsepos;

	const SVarGroup *group;
	group = entityList[ index ].getGroup(1);

	parsepos = 0;
	vector3df pos = getAsVector3df ( group->get ( "origin" ), parsepos );
	pos += translation;

	parsepos = 0;
	f32 angle = getAsFloat ( group->get ( "angle"), parsepos );

	vector3df target ( 0.f, 0.f, 1.f );
	target.rotateXZBy ( angle - 90.f, vector3df () );

	if ( camera )
	{
		camera->setPosition ( pos );
		camera->setTarget ( pos + target );
		//! New. FPSCamera and animators catches reset on animate 0
		camera->OnAnimate ( 0 );
	}
	return lastIndex - index + 1;
}


/*!
	gets a accumulated force on a given surface
*/
vector3df getGravity ( const c8 * surface )
{
	if ( 0 == strcmp ( surface, "earth" ) ) return vector3df ( 0.f, -900.f, 0.f );
	if ( 0 == strcmp ( surface, "moon" ) ) return vector3df ( 0.f, -6.f , 0.f );
	if ( 0 == strcmp ( surface, "water" ) ) return vector3df ( 0.1f, -2.f, 0.f );
	if ( 0 == strcmp ( surface, "ice" ) ) return vector3df ( 0.2f, -9.f, 0.3f );

	return vector3df ( 0.f, 0.f, 0.f );
}



/*
	Dynamically load the Irrlicht Library
*/

#if defined(_IRR_WINDOWS_API_)
#ifdef _MSC_VER
#pragma comment(lib, "Irrlicht.lib")
#endif

#include <windows.h>

funcptr_createDevice load_createDevice ( const c8 * filename)
{
	return (funcptr_createDevice) GetProcAddress ( LoadLibrary ( filename ), "createDevice" );
}

funcptr_createDeviceEx load_createDeviceEx ( const c8 * filename)
{
	return (funcptr_createDeviceEx) GetProcAddress ( LoadLibrary ( filename ), "createDeviceEx" );
}

#else

// TODO: Dynamic Loading for other os
funcptr_createDevice load_createDevice ( const c8 * filename)
{
	return createDevice;
}

funcptr_createDeviceEx load_createDeviceEx ( const c8 * filename)
{
	return createDeviceEx;
}

#endif

/*
	get the current collision response camera animator
*/
ISceneNodeAnimatorCollisionResponse* camCollisionResponse( IrrlichtDevice * device )
{
	ICameraSceneNode *camera = device->getSceneManager()->getActiveCamera();
	ISceneNodeAnimatorCollisionResponse *a = 0;

	list<ISceneNodeAnimator*>::ConstIterator it = camera->getAnimators().begin();
	for (; it != camera->getAnimators().end(); ++it)
	{
		a = (ISceneNodeAnimatorCollisionResponse*) (*it);
		if ( a->getType() == ESNAT_COLLISION_RESPONSE )
			return a;
	}

	return 0;
}


//! internal Animation
void setTimeFire ( TimeFire *t, u32 delta, u32 flags )
{
	t->flags = flags;
	t->next = 0;
	t->delta = delta;
}


void checkTimeFire ( TimeFire *t, u32 listSize, u32 now )
{
	u32 i;
	for ( i = 0; i < listSize; ++i )
	{
		if ( now < t[i].next )
			continue;

		t[i].next = core::max_ ( now + t[i].delta, t[i].next + t[i].delta );
		t[i].flags |= FIRED;
	}
}
