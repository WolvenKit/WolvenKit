#ifndef EXAMPLE22_MATERIAL_VIEWER_MAIN_H
#define EXAMPLE22_MATERIAL_VIEWER_MAIN_H

#include <irrlicht.h>

// Helper control to allow setting colors
class CColorControl : public irr::gui::IGUIElement
{
public:
	CColorControl(irr::gui::IGUIEnvironment* guiEnv, const irr::core::position2d<irr::s32> & pos, const wchar_t *text, irr::gui::IGUIElement* parent, irr::s32 id=-1);

	// Event receiver
	virtual bool OnEvent(const irr::SEvent &event);

	// Set the color values
	void setColor(const irr::video::SColor& col);

	// Get the color values
	const irr::video::SColor& getColor() const
	{
		return Color;
	}

	// To reset the dirty flag
	void resetDirty()
	{
		DirtyFlag = false;
	}

	// when the color was changed the dirty flag is set
	bool isDirty() const
	{
		return DirtyFlag;
	};

protected:

	// Add a staticbox for a description + an editbox so users can enter numbers
	irr::gui::IGUIEditBox* addEditForNumbers(irr::gui::IGUIEnvironment* guiEnv, const irr::core::position2d<irr::s32> & pos, const wchar_t *text, irr::s32 id, irr::gui::IGUIElement * parent);

	// Get the color value from the editfields
	irr::video::SColor getColorFromEdits() const;

	// Fill the editfields with the value for the given color
	void setEditsFromColor(irr::video::SColor col);

private:

	bool DirtyFlag;
	irr::video::SColor Color;
	irr::s32 ButtonSetId;
	irr::gui::IGUIStaticText * ColorStatic;
	irr::gui::IGUIEditBox * EditAlpha;
	irr::gui::IGUIEditBox * EditRed;
	irr::gui::IGUIEditBox * EditGreen;
	irr::gui::IGUIEditBox * EditBlue;
};

/*
	Custom GUI-control for to edit all colors typically used in materials and lights
*/
class CTypicalColorsControl : public irr::gui::IGUIElement
{
public:
	// Constructor
	CTypicalColorsControl(irr::gui::IGUIEnvironment* guiEnv, const irr::core::position2d<irr::s32> & pos, bool hasEmissive, irr::gui::IGUIElement* parent, irr::s32 id=-1);

	// Destructor
	virtual ~CTypicalColorsControl();

	// Set the color values to those within the material
	void setColorsToMaterialColors(const irr::video::SMaterial & material);

	// Update all changed colors in the material
	void updateMaterialColors(irr::video::SMaterial & material) const;

	// Set the color values to those from the light data
	void setColorsToLightDataColors(const irr::video::SLight & lightData);

	// Update all changed colors in the light data
	void updateLightColors(irr::video::SLight & lightData) const;

	// To reset the dirty flags
	void resetDirty();

private:
	CColorControl*	ControlAmbientColor;
	CColorControl*	ControlDiffuseColor;
	CColorControl*	ControlSpecularColor;
	CColorControl*	ControlEmissiveColor;
};

/*
	GUI-Control to offer a selection of available textures.
*/
class CTextureControl : public irr::gui::IGUIElement
{
public:
	CTextureControl(irr::gui::IGUIEnvironment* guiEnv, irr::video::IVideoDriver * driver, const irr::core::position2d<irr::s32> & pos, irr::gui::IGUIElement* parent, irr::s32 id=-1);

	virtual bool OnEvent(const irr::SEvent &event);

	// Workaround for a problem with comboboxes.
	// We have to get in front when the combobox wants to get in front or combobox-list might be drawn below other elements.
	virtual bool bringToFront(irr::gui::IGUIElement* element);

	// Return selected texturename (if any, otherwise 0)
	const wchar_t * getSelectedTextureName() const;

	// Change active selectionbased on the texture name
	void selectTextureByName(const irr::core::stringw& name);

	// Reset the dirty flag
	void resetDirty()
	{
		DirtyFlag = false;
	}

	// When the texture was changed the dirty flag is set
	bool isDirty() const
	{
		return DirtyFlag;
	};

	// Put the names of all currently loaded textures in a combobox
	void updateTextures(irr::video::IVideoDriver * driver);

private:
	bool DirtyFlag;
	irr::gui::IGUIComboBox * ComboTexture;
};

/*
	Control which allows setting some of the material values for a meshscenenode
*/
class CMaterialControl
{
public:
	// constructor
	CMaterialControl()
	: Initialized(false), Driver(0)
	, TypicalColorsControl(0), ButtonLighting(0), InfoLighting(0), ComboMaterial(0)
	{
		for (irr::u32 i=0; i<irr::video::MATERIAL_MAX_TEXTURES; ++i)
			TextureControls[i] = 0;
	}

	// Destructor
	~CMaterialControl()
	{
		for (irr::u32 i=0; i<irr::video::MATERIAL_MAX_TEXTURES; ++i)
		{
			if (TextureControls[i] )
				TextureControls[i]->drop();
		}
		if ( TypicalColorsControl )
			TypicalColorsControl->drop();
	}

	void init(irr::scene::IMeshSceneNode* node, irr::IrrlichtDevice * device, const irr::core::position2d<irr::s32> & pos, const wchar_t * description);

	void update(irr::scene::IMeshSceneNode* sceneNode, irr::scene::IMeshSceneNode* sceneNode2T, irr::scene::IMeshSceneNode* sceneNodeTangents);

	void updateTextures();

	void selectTextures(const irr::core::stringw& name);

	bool isLightingEnabled() const;

protected:

	void updateMaterial(irr::video::SMaterial & material);

	bool Initialized;
	irr::video::IVideoDriver * 	Driver;
	CTypicalColorsControl* 		TypicalColorsControl;
	irr::gui::IGUIButton * 		ButtonLighting;
	irr::gui::IGUIStaticText* 	InfoLighting;
	irr::gui::IGUIComboBox * 	ComboMaterial;
	CTextureControl*			TextureControls[irr::video::MATERIAL_MAX_TEXTURES];
};

/*
	Control to allow setting the color values of a lightscenenode.
*/
class CLightNodeControl
{
public:
	// constructor
	CLightNodeControl() : Initialized(false), TypicalColorsControl(0)
	{}

	~CLightNodeControl()
	{
		if ( TypicalColorsControl )
			TypicalColorsControl->drop();
	}

	void init(irr::scene::ILightSceneNode* node, irr::gui::IGUIEnvironment* guiEnv, const irr::core::position2d<irr::s32> & pos, const wchar_t * description);

	void update(irr::scene::ILightSceneNode* node);

protected:
	bool Initialized;
	CTypicalColorsControl* TypicalColorsControl;
};

/*
	Application configuration
*/
struct SConfig
{
	SConfig()
	: RenderInBackground(true)
	, DriverType(irr::video::EDT_NULL)
	, ScreenSize(640, 480)
	{
	}

	bool RenderInBackground;
	irr::video::E_DRIVER_TYPE DriverType;
	irr::core::dimension2d<irr::u32> ScreenSize;
};

/*
	Main application class
*/
class CApp : public irr::IEventReceiver
{
	friend int main(int argc, char *argv[]);

public:
	// constructor
	CApp()
	: IsRunning(false)
	, RealTimeTick(0)
	, Device(0)
	, MeshManipulator(0)
	, Camera(0)
	, SceneNode(0), SceneNode2T(0), SceneNodeTangents(0), NodeLight(0)
	, CameraRotationAxis(irr::core::vector3df(1,0,0))
	, LightRotationAxis(irr::core::vector3df(1,0,0))
	, MeshMaterialControl(0)
	, LightControl(0)
	, ControlVertexColors(0)
	, GlobalAmbient(0)
	, MousePressed(false)
	{
		memset(KeysPressed, 0, sizeof KeysPressed);
	}

	// destructor
	~CApp()
	{
	}

	// Tell it to stop running
	void setRunning(bool appRuns)
	{
		IsRunning = appRuns;
	}

	// Check if it should continue running
	bool isRunning() const
	{
		return IsRunning;
	}

	// Event handler
	virtual bool OnEvent(const irr::SEvent &event);

protected:

	// Application initialization
	// returns true when it was successful initialized, otherwise false.
	bool init(int argc, char *argv[]);

	// Update one frame
	bool update();

	// Close down the application
	void quit();

	// Create some useful textures.
	void createDefaultTextures(irr::video::IVideoDriver * driver);

	// Load a texture and make sure nodes know it when more textures are available.
	void loadTexture(const irr::io::path &name);

	// Rotate a node around the origin (0,0,0)
	void RotateHorizontal(irr::scene::ISceneNode* node, irr::f32 angle);
	void RotateAroundAxis(irr::scene::ISceneNode* node, irr::f32 angle, const irr::core::vector3df& axis);
	void ZoomOut(irr::scene::ISceneNode* node, irr::f32 units);
	void UpdateRotationAxis(irr::scene::ISceneNode* node, irr::core::vector3df& axis);


private:
	SConfig	Config;
	bool	IsRunning;
	irr::u32 RealTimeTick;
	irr::IrrlichtDevice * 			Device;
	irr::scene::IMeshManipulator* 	MeshManipulator;
	irr::scene::ICameraSceneNode *	Camera;
	irr::scene::IMeshSceneNode* 	SceneNode;
	irr::scene::IMeshSceneNode* 	SceneNode2T;
	irr::scene::IMeshSceneNode* 	SceneNodeTangents;
	irr::scene::ILightSceneNode* 	NodeLight;
	irr::core::vector3df CameraRotationAxis;
	irr::core::vector3df LightRotationAxis;
	CMaterialControl*	MeshMaterialControl;
	CLightNodeControl*	LightControl;
	CColorControl*	ControlVertexColors;
	CColorControl*	GlobalAmbient;
	bool KeysPressed[irr::KEY_KEY_CODES_COUNT];
	bool MousePressed;
	irr::core::position2d<irr::s32> MouseStart;
};

#endif
