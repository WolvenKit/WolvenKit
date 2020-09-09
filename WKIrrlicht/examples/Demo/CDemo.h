// This is a Demo of the Irrlicht Engine (c) 2006 by N.Gebhardt.
// This file is not documented.

#ifndef __C_DEMO_H_INCLUDED__
#define __C_DEMO_H_INCLUDED__

//#define USE_IRRKLANG
//#define USE_SDL_MIXER

#include <irrlicht.h>

#ifdef _IRR_WINDOWS_
#include <windows.h>
#endif

using namespace irr;

// audio support

#ifdef USE_IRRKLANG
	#include <irrKlang.h>	// problem here? go to http://www.ambiera.com/irrklang and download
							// the irrKlang library or undefine USE_IRRKLANG at the beginning
							// of this file.
	#ifdef _MSC_VER
	#pragma comment (lib, "irrKlang.lib")
	#endif
#endif
#ifdef USE_SDL_MIXER
	# include <SDL/SDL.h>
	# include <SDL/SDL_mixer.h>
#endif

const int CAMERA_COUNT = 7;

class CDemo : public IEventReceiver
{
public:

	CDemo(bool fullscreen, bool music, bool shadows, bool additive, bool vsync, bool aa, video::E_DRIVER_TYPE driver);

	~CDemo();

	void run();

	virtual bool OnEvent(const SEvent& event);

private:

	void createLoadingScreen();
	void loadSceneData();
	void switchToNextScene();
	void shoot();
	void createParticleImpacts();

	bool fullscreen;
	bool music;
	bool shadows;
	bool additive;
	bool vsync;
	bool aa;
	video::E_DRIVER_TYPE driverType;
	IrrlichtDevice *device;

#ifdef USE_IRRKLANG
	void startIrrKlang();
	irrklang::ISoundEngine* irrKlang;
	irrklang::ISoundSource* ballSound;
	irrklang::ISoundSource* impactSound;
#endif

#ifdef USE_SDL_MIXER
	void startSound();
	void playSound(Mix_Chunk *);
	void pollSound();
	Mix_Music *stream;
	Mix_Chunk *ballSound;
	Mix_Chunk *impactSound;
#endif

	struct SParticleImpact
	{
		u32 when;
		core::vector3df pos;
		core::vector3df outVector;
	};

	int currentScene;
	video::SColor backColor;

	gui::IGUIStaticText* statusText;
	gui::IGUIInOutFader* inOutFader;

	scene::IQ3LevelMesh* quakeLevelMesh;
	scene::ISceneNode* quakeLevelNode;
	scene::ISceneNode* skyboxNode;
	scene::IAnimatedMeshSceneNode* model1;
	scene::IAnimatedMeshSceneNode* model2;
	scene::IParticleSystemSceneNode* campFire;

	scene::IMetaTriangleSelector* metaSelector;
	scene::ITriangleSelector* mapSelector;

	s32 sceneStartTime;
	s32 timeForThisScene;

	core::array<SParticleImpact> Impacts;
};

#endif

