// This is a Demo of the Irrlicht Engine (c) 2005 by N.Gebhardt.
// This file is not documentated.

#ifndef __C_MAIN_MENU_H_INCLUDED__
#define __C_MAIN_MENU_H_INCLUDED__

#include <irrlicht.h>

using namespace irr;

class CMainMenu : public IEventReceiver
{
public:

	CMainMenu();

	bool run();

	bool getFullscreen() const { return fullscreen; }
	bool getMusic() const { return music; }
	bool getShadows() const { return shadows; }
	bool getAdditive() const { return additive; }
	bool getVSync() const { return vsync; }
	bool getAntiAliasing() const { return aa; }
	video::E_DRIVER_TYPE getDriverType() const { return driverType; }


	virtual bool OnEvent(const SEvent& event);

private:

	void setTransparency();

	gui::IGUIButton* startButton;
	IrrlichtDevice *MenuDevice;
	s32 selected;
	bool start;
	bool fullscreen;
	bool music;
	bool shadows;
	bool additive;
	bool transparent;
	bool vsync;
	bool aa;
	video::E_DRIVER_TYPE driverType;

	scene::IAnimatedMesh* quakeLevel;
	scene::ISceneNode* lightMapNode;
	scene::ISceneNode* dynamicNode;

	video::SColor SkinColor [ gui::EGDC_COUNT ];
	void getOriginalSkinColor();
};

#endif

