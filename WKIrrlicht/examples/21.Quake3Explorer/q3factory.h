/*!
	Model Factory.
	create the additional scenenodes for ( bullets, health... ) 

	Defines the Entities for Quake3
*/
#ifndef __QUAKE3_FACTORY__H_INCLUDED__
#define __QUAKE3_FACTORY__H_INCLUDED__

using namespace irr;
using namespace scene;
using namespace gui;
using namespace video;
using namespace core;
using namespace quake3;
using namespace io;



//! Defines to which group the entities belong
enum eItemGroup
{
	WEAPON,
	AMMO,
	ARMOR,
	HEALTH,
	POWERUP
};

//! define a supgroup for the item. for e.q the Weapons
enum eItemSubGroup
{
	SUB_NONE = 0,
	GAUNTLET,
	MACHINEGUN,
	SHOTGUN,
	GRENADE_LAUNCHER,
	ROCKET_LAUNCHER,
	LIGHTNING,
	RAILGUN,
	PLASMAGUN,
	BFG,
	GRAPPLING_HOOK,
	NAILGUN,
	PROX_LAUNCHER,
	CHAINGUN,
};

//! aplly a special effect to the shader
enum eItemSpecialEffect
{
	SPECIAL_SFX_NONE		= 0,
	SPECIAL_SFX_ROTATE		= 1,
	SPECIAL_SFX_BOUNCE		= 2,
	SPECIAL_SFX_ROTATE_1	= 4,
};

// a List for defining a model
struct SItemElement
{
	const c8 *key;
	const c8 *model[2];
	const c8 *sound;
	const c8 *icon;
	const c8 *pickup;
	s32 value;
	eItemGroup group;
	eItemSubGroup sub;
	u32 special;
};


//! Get's an entity based on it's key
const SItemElement * getItemElement ( const stringc& key );

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
						bool showShaderName 
					);


/*!
	Creates Model based on the entity list
*/
void Q3ModelFactory (	Q3LevelLoadParameter &loadParam,
						IrrlichtDevice *device, 
						IQ3LevelMesh* masterMesh, 
						ISceneNode *parent,
						bool showShaderName
					);

/*!
	so we need a good starting Position in the level.
	we can ask the Quake3 Loader for all entities with class_name "info_player_deathmatch"
*/
s32 Q3StartPosition (	IQ3LevelMesh* mesh,
						ICameraSceneNode* camera,
						s32 startposIndex,
						const vector3df &translation
					);
/*!
	gets a accumulated force on a given surface
*/
vector3df getGravity ( const c8 * surface );


/*
	Dynamically load the Irrlicht Library
*/
funcptr_createDevice load_createDevice ( const c8 * filename);
funcptr_createDeviceEx load_createDeviceEx ( const c8 * filename);


//! Macro for save Dropping an Element
#define dropElement(x)	if (x) { x->remove(); x = 0; }


/*
	get the current collision respone camera animator
*/
ISceneNodeAnimatorCollisionResponse* camCollisionResponse( IrrlichtDevice * device );

//! internal Animation
enum eTimeFireFlag
{
	FIRED = 1,
};

struct TimeFire
{
	u32 flags;
	u32 next;
	u32 delta;
};

void setTimeFire ( TimeFire *t, u32 delta, u32 flags = 0 );
void checkTimeFire ( TimeFire *t, u32 listSize, u32 now );

#endif // __QUAKE3_FACTORY__H_INCLUDED__


