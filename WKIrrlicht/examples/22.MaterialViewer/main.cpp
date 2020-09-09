/** Example 022 Material Viewer

This example can be used to play around with material settings and watch the results.
Only the default non-shader materials are used in here.

You have a node with a mesh, one dynamic light and global ambient light to play around with.
You can move the light with cursor-keys and +/-.
You can move the camera while left-mouse button is clicked.
*/

// TODO: Should be possible to set all material values by the GUI.
//		 For now just change the defaultMaterial in CApp::init for the rest.
// TODO: Allow users to switch between a sphere and a box mesh.

#include <irrlicht.h>
#include "driverChoice.h"
#include "exampleHelper.h"
#include "main.h"

using namespace irr;

#ifdef _MSC_VER
#pragma comment(lib, "Irrlicht.lib")
#endif

/*
	Variables within the empty namespace are globals which are restricted to this file.
*/
namespace
{
	// For the gui id's
	enum EGUI_IDS
	{
		GUI_ID_OPEN_TEXTURE = 1,
		GUI_ID_QUIT,
		GUI_ID_MAX
	};

	// Name used in texture selection to clear the textures on the node
	const core::stringw CLEAR_TEXTURE = L"CLEAR texture";

	// some useful color constants
	const video::SColor SCOL_BLACK     = video::SColor(255, 0,   0,   0);
	const video::SColor SCOL_BLUE      = video::SColor(255, 0,   0,  255);
	const video::SColor SCOL_CYAN      = video::SColor(255, 0,  255, 255);
	const video::SColor SCOL_GRAY      = video::SColor(255, 128,128, 128);
	const video::SColor SCOL_GREEN     = video::SColor(255, 0,  255,  0);
	const video::SColor SCOL_MAGENTA   = video::SColor(255, 255, 0,  255);
	const video::SColor SCOL_RED       = video::SColor(255, 255, 0,   0);
	const video::SColor SCOL_YELLOW    = video::SColor(255, 255, 255, 0);
	const video::SColor SCOL_WHITE     = video::SColor(255, 255, 255, 255);
};	// namespace

/*
	Returns a new unique number on each call.
*/
s32 makeUniqueId()
{
	static int unique = GUI_ID_MAX;
	++unique;
	return unique;
}

/*
	Find out which vertex-type is needed for the given material type.
*/
video::E_VERTEX_TYPE getVertexTypeForMaterialType(video::E_MATERIAL_TYPE materialType)
{
	using namespace video;

	switch ( materialType )
	{
		case EMT_SOLID:
			return EVT_STANDARD;

		case EMT_SOLID_2_LAYER:
			return EVT_STANDARD;

		case EMT_LIGHTMAP:
		case EMT_LIGHTMAP_ADD:
		case EMT_LIGHTMAP_M2:
		case EMT_LIGHTMAP_M4:
		case EMT_LIGHTMAP_LIGHTING:
		case EMT_LIGHTMAP_LIGHTING_M2:
		case EMT_LIGHTMAP_LIGHTING_M4:
			return EVT_2TCOORDS;

		case EMT_DETAIL_MAP:
			return EVT_2TCOORDS;

		case EMT_SPHERE_MAP:
			return EVT_STANDARD;

		case EMT_REFLECTION_2_LAYER:
			return EVT_2TCOORDS;

		case EMT_TRANSPARENT_ADD_COLOR:
			return EVT_STANDARD;

		case EMT_TRANSPARENT_ALPHA_CHANNEL:
			return EVT_STANDARD;

		case EMT_TRANSPARENT_ALPHA_CHANNEL_REF:
			return EVT_STANDARD;

		case EMT_TRANSPARENT_VERTEX_ALPHA:
			return EVT_STANDARD;

		case EMT_TRANSPARENT_REFLECTION_2_LAYER:
			return EVT_2TCOORDS;

		case EMT_NORMAL_MAP_SOLID:
		case EMT_NORMAL_MAP_TRANSPARENT_ADD_COLOR:
		case EMT_NORMAL_MAP_TRANSPARENT_VERTEX_ALPHA:
		case EMT_PARALLAX_MAP_SOLID:
		case EMT_PARALLAX_MAP_TRANSPARENT_ADD_COLOR:
		case EMT_PARALLAX_MAP_TRANSPARENT_VERTEX_ALPHA:
			return EVT_TANGENTS;

		case EMT_ONETEXTURE_BLEND:
			return EVT_STANDARD;

		case EMT_FORCE_32BIT:
			return EVT_STANDARD;
	}
	return EVT_STANDARD;
}

/*
	Custom GUI-control to edit colorvalues.
*/
// Constructor
CColorControl::CColorControl(gui::IGUIEnvironment* guiEnv, const core::position2d<s32> & pos, const wchar_t *text, IGUIElement* parent, s32 id)
	: gui::IGUIElement(gui::EGUIET_ELEMENT, guiEnv, parent,id, core::rect< s32 >(pos, pos+core::dimension2d<s32>(80, 75)))
	, DirtyFlag(true)
	, Color(0)
	, ColorStatic(0)
	, EditAlpha(0)
	, EditRed(0)
	, EditGreen(0)
	, EditBlue(0)
{
	using namespace gui;
	ButtonSetId = makeUniqueId();

	const core::rect< s32 > rectControls(0,0,AbsoluteRect.getWidth(),AbsoluteRect.getHeight() );
	IGUIStaticText * groupElement =	guiEnv->addStaticText (L"", rectControls, true, false, this, -1, false);
	groupElement->setNotClipped(true);

	guiEnv->addStaticText (text, core::rect<s32>(0,0,80,15), false, false, groupElement, -1, false);

	EditAlpha = addEditForNumbers(guiEnv, core::position2d<s32>(0,15), L"a", -1, groupElement );
	EditRed = addEditForNumbers(guiEnv, core::position2d<s32>(0,30), L"r", -1, groupElement );
	EditGreen = addEditForNumbers(guiEnv, core::position2d<s32>(0,45), L"g", -1, groupElement );
	EditBlue = addEditForNumbers(guiEnv, core::position2d<s32>(0,60), L"b", -1, groupElement );

	ColorStatic = guiEnv->addStaticText (L"", core::rect<s32>(60,15,80,75), true, false, groupElement, -1, true);

	guiEnv->addButton (core::rect<s32>(60,35,80,50), groupElement, ButtonSetId, L"set");
	setEditsFromColor(Color);
}

// event receiver
bool CColorControl::OnEvent(const SEvent &event)
{
	if ( event.EventType != EET_GUI_EVENT )
		return false;

	if ( event.GUIEvent.Caller->getID() == ButtonSetId && event.GUIEvent.EventType == gui::EGET_BUTTON_CLICKED )
	{
		Color = getColorFromEdits();
		setEditsFromColor(Color);
	}

	return false;
}

// set the color values
void CColorControl::setColor(const video::SColor& col)
{
	DirtyFlag = true;
	Color = col;
	setEditsFromColor(Color);
}

// Add a staticbox for a description + an editbox so users can enter numbers
gui::IGUIEditBox* CColorControl::addEditForNumbers(gui::IGUIEnvironment* guiEnv, const core::position2d<s32> & pos, const wchar_t *text, s32 id, gui::IGUIElement * parent)
{
	using namespace gui;

	core::rect< s32 > rect(pos, pos+core::dimension2d<s32>(10, 15));
	guiEnv->addStaticText (text, rect, false, false, parent, -1, false);
	rect += core::position2d<s32>( 20, 0 );
	rect.LowerRightCorner.X += 20;
	gui::IGUIEditBox* edit = guiEnv->addEditBox(L"0", rect, true, parent, id);
	return edit;
}

// Get the color value from the editfields
video::SColor CColorControl::getColorFromEdits() const
{
	video::SColor col;

	if (EditAlpha)
	{
		u32 alpha = core::strtoul10(core::stringc(EditAlpha->getText()).c_str());
		if (alpha > 255)
			alpha = 255;
		col.setAlpha(alpha);
	}

	if (EditRed)
	{
		u32 red = core::strtoul10(core::stringc(EditRed->getText()).c_str());
		if (red > 255)
			red = 255;
		col.setRed(red);
	}

	if (EditGreen)
	{
		u32 green = core::strtoul10(core::stringc(EditGreen->getText()).c_str());
		if (green > 255)
			green = 255;
		col.setGreen(green);
	}

	if (EditBlue)
	{
		u32 blue = core::strtoul10(core::stringc(EditBlue->getText()).c_str());
		if (blue > 255)
			blue = 255;
		col.setBlue(blue);
	}

	return col;
}

// Fill the editfields with the value for the given color
void CColorControl::setEditsFromColor(video::SColor col)
{
	DirtyFlag = true;
	if ( EditAlpha )
		EditAlpha->setText( core::stringw(col.getAlpha()).c_str() );
	if ( EditRed )
		EditRed->setText( core::stringw(col.getRed()).c_str() );
	if ( EditGreen )
		EditGreen->setText( core::stringw(col.getGreen()).c_str() );
	if ( EditBlue )
		EditBlue->setText( core::stringw(col.getBlue()).c_str() );
	if ( ColorStatic )
		ColorStatic->setBackgroundColor(col);
}

/*
	Custom GUI-control for to edit all colors typically used in materials and lights
*/
// Constructor
CTypicalColorsControl::CTypicalColorsControl(gui::IGUIEnvironment* guiEnv, const core::position2d<s32> & pos, bool hasEmissive, IGUIElement* parent, s32 id)
	: gui::IGUIElement(gui::EGUIET_ELEMENT, guiEnv, parent,id, core::rect<s32>(pos,pos+core::dimension2d<s32>(60,250)))
	, ControlAmbientColor(0), ControlDiffuseColor(0), ControlSpecularColor(0), ControlEmissiveColor(0)
{
	ControlAmbientColor = new CColorControl( guiEnv, core::position2d<s32>(0, 0), L"Ambient", this);
	ControlDiffuseColor = new CColorControl( guiEnv, core::position2d<s32>(0, 75), L"Diffuse", this );
	ControlSpecularColor = new CColorControl( guiEnv, core::position2d<s32>(0, 150), L"Specular", this );
	if ( hasEmissive )
	{
		ControlEmissiveColor = new CColorControl( guiEnv, core::position2d<s32>(0, 225), L"Emissive", this );
	}
}

// Destructor
CTypicalColorsControl::~CTypicalColorsControl()
{
	ControlAmbientColor->drop();
	ControlDiffuseColor->drop();
	if ( ControlEmissiveColor )
		ControlEmissiveColor->drop();
	ControlSpecularColor->drop();
}

// Set the color values to those within the material
void CTypicalColorsControl::setColorsToMaterialColors(const video::SMaterial & material)
{
	ControlAmbientColor->setColor(material.AmbientColor);
	ControlDiffuseColor->setColor(material.DiffuseColor);
	ControlEmissiveColor->setColor(material.EmissiveColor);
	ControlSpecularColor->setColor(material.SpecularColor);
}

// Update all changed colors in the material
void CTypicalColorsControl::updateMaterialColors(video::SMaterial & material) const
{
	if ( ControlAmbientColor->isDirty() )
		material.AmbientColor = ControlAmbientColor->getColor();
	if ( ControlDiffuseColor->isDirty() )
		material.DiffuseColor = ControlDiffuseColor->getColor();
	if ( ControlEmissiveColor->isDirty() )
		material.EmissiveColor = ControlEmissiveColor->getColor();
	if ( ControlSpecularColor->isDirty() )
		material.SpecularColor = ControlSpecularColor->getColor();
}

// Set the color values to those from the light data
void CTypicalColorsControl::setColorsToLightDataColors(const video::SLight & lightData)
{
	ControlAmbientColor->setColor(lightData.AmbientColor.toSColor());
	ControlDiffuseColor->setColor(lightData.DiffuseColor.toSColor());
	ControlSpecularColor->setColor(lightData.SpecularColor.toSColor());
}

// Update all changed colors in the light data
void CTypicalColorsControl::updateLightColors(video::SLight & lightData) const
{
	if ( ControlAmbientColor->isDirty() )
		lightData.AmbientColor = video::SColorf( ControlAmbientColor->getColor() );
	if ( ControlDiffuseColor->isDirty() )
		lightData.DiffuseColor = video::SColorf( ControlDiffuseColor->getColor() );
	if ( ControlSpecularColor->isDirty() )
		lightData.SpecularColor = video::SColorf(ControlSpecularColor->getColor() );
}

// To reset the dirty flags
void CTypicalColorsControl::resetDirty()
{
	ControlAmbientColor->resetDirty();
	ControlDiffuseColor->resetDirty();
	ControlSpecularColor->resetDirty();
	if ( ControlEmissiveColor )
		ControlEmissiveColor->resetDirty();
}


/*
	GUI-Control to offer a selection of available textures.
*/
CTextureControl::CTextureControl(gui::IGUIEnvironment* guiEnv, video::IVideoDriver * driver, const core::position2d<s32> & pos, IGUIElement* parent, s32 id)
: gui::IGUIElement(gui::EGUIET_ELEMENT, guiEnv, parent,id, core::rect<s32>(pos,pos+core::dimension2d<s32>(150,15)))
, DirtyFlag(true), ComboTexture(0)
{
	core::rect<s32> rectCombo(0, 0, AbsoluteRect.getWidth(),AbsoluteRect.getHeight());
	ComboTexture = guiEnv->addComboBox (rectCombo, this);
	updateTextures(driver);
}

bool CTextureControl::OnEvent(const SEvent &event)
{
	if ( event.EventType != EET_GUI_EVENT )
		return false;

	if ( event.GUIEvent.Caller == ComboTexture && event.GUIEvent.EventType == gui::EGET_COMBO_BOX_CHANGED )
	{
		DirtyFlag = true;
	}

	return false;
}

// Workaround for a problem with comboboxes.
// We have to get in front when the combobox wants to get in front or combobox-list might be drawn below other elements.
bool CTextureControl::bringToFront(IGUIElement* element)
{
	bool result = gui::IGUIElement::bringToFront(element);
	if ( Parent && element == ComboTexture )
		result &= Parent->bringToFront(this);
	return result;
}

// return selected texturename (if any, otherwise 0)
const wchar_t * CTextureControl::getSelectedTextureName() const
{
	s32 selected = ComboTexture->getSelected();
	if ( selected < 0 )
		return 0;
	return ComboTexture->getItem(selected);
}

void CTextureControl::selectTextureByName(const irr::core::stringw& name)
{
	for (u32 i=0; i< ComboTexture->getItemCount(); ++i)
	{
		if ( name == ComboTexture->getItem(i))
		{
			ComboTexture->setSelected(i);
			DirtyFlag = true;
			return;
		}
	}
}

// Put the names of all currently loaded textures in a combobox
void CTextureControl::updateTextures(video::IVideoDriver * driver)
{
	s32 oldSelected = ComboTexture->getSelected();
	s32 selectNew = -1;
	core::stringw oldTextureName;
	if ( oldSelected >= 0 )
	{
		oldTextureName = ComboTexture->getItem(oldSelected);
	}
	ComboTexture->clear();
	for ( u32 i=0; i < driver->getTextureCount(); ++i )
	{
		video::ITexture * texture = driver->getTextureByIndex(i);
		core::stringw name( texture->getName() );
		ComboTexture->addItem( name.c_str() );
		if ( !oldTextureName.empty() && selectNew < 0 && name == oldTextureName )
			selectNew = i;
	}

	// add another name which can be used to clear the texture
	ComboTexture->addItem( CLEAR_TEXTURE.c_str() );
	if ( CLEAR_TEXTURE == oldTextureName )
		selectNew = ComboTexture->getItemCount()-1;

	if ( selectNew >= 0 )
		ComboTexture->setSelected(selectNew);

	DirtyFlag = true;
}

/*
	Control which allows setting some of the material values for a meshscenenode
*/
void CMaterialControl::init(scene::IMeshSceneNode* node, IrrlichtDevice * device, const core::position2d<s32> & pos, const wchar_t * description)
{
	if ( Initialized || !node || !device) // initializing twice or with invalid data not allowed
		return;

	Driver = device->getVideoDriver ();
	gui::IGUIEnvironment* guiEnv = device->getGUIEnvironment();
	scene::ISceneManager* smgr = device->getSceneManager();
	const video::SMaterial & material = node->getMaterial(0);

	s32 top = pos.Y;

	// Description
	guiEnv->addStaticText(description, core::rect<s32>(pos.X, top, pos.X+60, top+15), false, false, 0, -1, false);
	top += 15;

	// Control for material type
	core::rect<s32> rectCombo(pos.X, top, 150, top+15);
	top += 15;
	ComboMaterial = guiEnv->addComboBox (rectCombo);
	for ( int i=0; i <= (int)video::EMT_ONETEXTURE_BLEND; ++i )
	{
		ComboMaterial->addItem( core::stringw(video::sBuiltInMaterialTypeNames[i]).c_str() );
	}
	ComboMaterial->setSelected( (s32)material.MaterialType );

	// Control to enable/disabling material lighting
	core::rect<s32> rectBtn(core::position2d<s32>(pos.X, top), core::dimension2d<s32>(100, 15));
	top += 15;
	ButtonLighting = guiEnv->addButton (rectBtn, 0, -1, L"Lighting");
	ButtonLighting->setIsPushButton(true);
	ButtonLighting->setPressed(material.Lighting);
	core::rect<s32> rectInfo( rectBtn.LowerRightCorner.X, rectBtn.UpperLeftCorner.Y, rectBtn.LowerRightCorner.X+40, rectBtn.UpperLeftCorner.Y+15 );
	InfoLighting = guiEnv->addStaticText(L"", rectInfo, true, false );
	InfoLighting->setTextAlignment(gui::EGUIA_CENTER, gui::EGUIA_CENTER );

	// Controls for colors
	TypicalColorsControl = new CTypicalColorsControl(guiEnv, core::position2d<s32>(pos.X, top), true, guiEnv->getRootGUIElement());
	top += 300;
	TypicalColorsControl->setColorsToMaterialColors(material);

	// Controls for selecting the material textures
	guiEnv->addStaticText(L"Textures", core::rect<s32>(pos.X, top, pos.X+60, top+15), false, false, 0, -1, false);
	top += 15;

	for (irr::u32 i=0; i<irr::video::MATERIAL_MAX_TEXTURES; ++i)
	{
		TextureControls[i] = new CTextureControl(guiEnv, Driver, core::position2di(pos.X, top), guiEnv->getRootGUIElement());
		top += 15;
	}

	Initialized = true;
}

void CMaterialControl::update(scene::IMeshSceneNode* sceneNode, scene::IMeshSceneNode* sceneNode2T, scene::IMeshSceneNode* sceneNodeTangents)
{
	if ( !Initialized )
		return;

	video::SMaterial & material = sceneNode->getMaterial(0);
	video::SMaterial & material2T = sceneNode2T->getMaterial(0);
	video::SMaterial & materialTangents = sceneNodeTangents->getMaterial(0);

	s32 selectedMaterial = ComboMaterial->getSelected();
	if ( selectedMaterial >= (s32)video::EMT_SOLID && selectedMaterial <= (s32)video::EMT_ONETEXTURE_BLEND)
	{
		// Show the node which has a mesh to work with the currently selected material
		video::E_VERTEX_TYPE vertexType = getVertexTypeForMaterialType((video::E_MATERIAL_TYPE)selectedMaterial);
		switch ( vertexType )
		{
			case video::EVT_STANDARD:
				material.MaterialType = (video::E_MATERIAL_TYPE)selectedMaterial;
				sceneNode->setVisible(true);
				sceneNode2T->setVisible(false);
				sceneNodeTangents->setVisible(false);
				break;
			case video::EVT_2TCOORDS:
				material2T.MaterialType = (video::E_MATERIAL_TYPE)selectedMaterial;
				sceneNode->setVisible(false);
				sceneNode2T->setVisible(true);
				sceneNodeTangents->setVisible(false);
				break;
			case video::EVT_TANGENTS:
				materialTangents.MaterialType = (video::E_MATERIAL_TYPE)selectedMaterial;
				sceneNode->setVisible(false);
				sceneNode2T->setVisible(false);
				sceneNodeTangents->setVisible(true);
				break;
		}
	}

	// Always update materials of all nodes, otherwise the tool is confusing to use.
	updateMaterial(material);
	updateMaterial(material2T);
	updateMaterial(materialTangents);

	if ( ButtonLighting->isPressed() )
		InfoLighting->setText(L"is on");
	else
		InfoLighting->setText(L"is off");

	TypicalColorsControl->resetDirty();

	for (irr::u32 i=0; i<irr::video::MATERIAL_MAX_TEXTURES; ++i)
		TextureControls[i]->resetDirty();
}

void CMaterialControl::updateTextures()
{
	for (irr::u32 i=0; i<irr::video::MATERIAL_MAX_TEXTURES; ++i)
		TextureControls[i]->updateTextures(Driver);
}

void CMaterialControl::selectTextures(const irr::core::stringw& name)
{
	for (irr::u32 i=0; i<irr::video::MATERIAL_MAX_TEXTURES; ++i)
		TextureControls[i]->selectTextureByName(name);
}

bool CMaterialControl::isLightingEnabled() const
{
	return ButtonLighting && ButtonLighting->isPressed();
}

void CMaterialControl::updateMaterial(video::SMaterial & material)
{
	TypicalColorsControl->updateMaterialColors(material);
	material.Lighting = ButtonLighting->isPressed();
	for (irr::u32 i=0; i<irr::video::MATERIAL_MAX_TEXTURES; ++i)
	{
		if ( TextureControls[i]->isDirty() )
		{
			material.TextureLayer[i].Texture = Driver->getTexture( io::path(TextureControls[i]->getSelectedTextureName()) );
		}
	}
}

/*
	Control to allow setting the color values of a lightscenenode.
*/

void CLightNodeControl::init(scene::ILightSceneNode* node, gui::IGUIEnvironment* guiEnv, const core::position2d<s32> & pos, const wchar_t * description)
{
	if ( Initialized || !node || !guiEnv) // initializing twice or with invalid data not allowed
		return;

	guiEnv->addStaticText(description, core::rect<s32>(pos.X, pos.Y, pos.X+70, pos.Y+15), false, false, 0, -1, false);
	TypicalColorsControl = new CTypicalColorsControl(guiEnv, core::position2d<s32>(pos.X, pos.Y+15), false, guiEnv->getRootGUIElement());
	const video::SLight & lightData = node->getLightData();
	TypicalColorsControl->setColorsToLightDataColors(lightData);
	Initialized = true;
}

void CLightNodeControl::update(scene::ILightSceneNode* node)
{
	if ( !Initialized )
		return;

	video::SLight & lightData = node->getLightData();
	TypicalColorsControl->updateLightColors(lightData);
}

/*
	Main application class
*/

/*
	Event handler
*/
bool CApp::OnEvent(const SEvent &event)
{
	if (event.EventType == EET_GUI_EVENT)
	{
		gui::IGUIEnvironment* env = Device->getGUIEnvironment();

		switch(event.GUIEvent.EventType)
		{
			case gui::EGET_MENU_ITEM_SELECTED:
			{
				gui::IGUIContextMenu* menu = (gui::IGUIContextMenu*)event.GUIEvent.Caller;
				s32 id = menu->getItemCommandId(menu->getSelectedItem());

				switch(id)
				{
					case GUI_ID_OPEN_TEXTURE: // File -> Open Texture
						env->addFileOpenDialog(L"Please select a texture file to open");
					break;
					case GUI_ID_QUIT: // File -> Quit
						setRunning(false);
					break;
				}
			}
			break;

			case gui::EGET_FILE_SELECTED:
			{
				// load the model file, selected in the file open dialog
				gui::IGUIFileOpenDialog* dialog =
					(gui::IGUIFileOpenDialog*)event.GUIEvent.Caller;
				loadTexture(io::path(dialog->getFileName()).c_str());
			}
			break;

			default:
			break;
		}
	}
	else if (event.EventType == EET_KEY_INPUT_EVENT)
	{
		KeysPressed[event.KeyInput.Key] = event.KeyInput.PressedDown;
	}
	else if (event.EventType == EET_MOUSE_INPUT_EVENT)
	{
		if (!MousePressed && event.MouseInput.isLeftPressed())
		{
			gui::IGUIEnvironment* guiEnv = Device->getGUIEnvironment();
			if ( guiEnv->getHovered() == guiEnv->getRootGUIElement() )	// Click on background
			{
				MousePressed  = true;
				MouseStart.X = event.MouseInput.X;
				MouseStart.Y = event.MouseInput.Y;
			}
		}
		else if (MousePressed && !event.MouseInput.isLeftPressed())
		{
			MousePressed = false;
		}
	}

	return false;
}

// Application initialization
// returns true when it was successful initialized, otherwise false.
bool CApp::init(int argc, char *argv[])
{
	// ask user for driver
	Config.DriverType=driverChoiceConsole();
	if (Config.DriverType==video::EDT_COUNT)
		return false;

	// create the device with the settings from our config
	Device = createDevice(Config.DriverType, Config.ScreenSize);
	if (!Device)
		return false;

	Device->setWindowCaption( core::stringw(video::DRIVER_TYPE_NAMES[Config.DriverType]).c_str() );
	Device->setEventReceiver(this);

	scene::ISceneManager* smgr = Device->getSceneManager();
	video::IVideoDriver * driver = Device->getVideoDriver ();
	gui::IGUIEnvironment* guiEnv = Device->getGUIEnvironment();
	MeshManipulator = smgr->getMeshManipulator();

	// set a nicer font
	gui::IGUISkin* skin = guiEnv->getSkin();
	gui::IGUIFont* font = guiEnv->getFont(getExampleMediaPath() + "fonthaettenschweiler.bmp");
	if (font)
		skin->setFont(font);

	// remove some alpha value because it makes those menus harder to read otherwise
	video::SColor col3dHighLight( skin->getColor(gui::EGDC_APP_WORKSPACE) );
	col3dHighLight.setAlpha(255);
	video::SColor colHighLight( col3dHighLight );
	skin->setColor(gui::EGDC_HIGH_LIGHT, colHighLight );
	skin->setColor(gui::EGDC_3D_HIGH_LIGHT, col3dHighLight );

	// Add some textures which are useful to test material settings
	createDefaultTextures(driver);

	// create a menu
	gui::IGUIContextMenu * menuBar = guiEnv->addMenu();
	menuBar->addItem(L"File", -1, true, true);

	gui::IGUIContextMenu* subMenuFile = menuBar->getSubMenu(0);
	subMenuFile->addItem(L"Open texture ...", GUI_ID_OPEN_TEXTURE);
	subMenuFile->addSeparator();
	subMenuFile->addItem(L"Quit", GUI_ID_QUIT);

	// a static camera
	Camera = smgr->addCameraSceneNode (0, core::vector3df(0, 40, -40),
										core::vector3df(0, 10, 0),
										-1);

	// default material
	video::SMaterial defaultMaterial;
	defaultMaterial.Shininess = 20.f;

	// add the nodes which are used to show the materials
	SceneNode = smgr->addCubeSceneNode (30.0f, 0, -1,
									   core::vector3df(0, 0, 0),
									   core::vector3df(0.f, 45.f, 0.f),
									   core::vector3df(1.0f, 1.0f, 1.0f));
	SceneNode->getMaterial(0) = defaultMaterial;

	const s32 controlsTop = 20;
	MeshMaterialControl = new CMaterialControl();
	MeshMaterialControl->init( SceneNode, Device, core::position2d<s32>(10,controlsTop), L"Material" );
	MeshMaterialControl->selectTextures(core::stringw("CARO_A8R8G8B8"));	// set a useful default texture

	// create nodes with other vertex types
	scene::IMesh * mesh2T = MeshManipulator->createMeshWith2TCoords(SceneNode->getMesh());
	SceneNode2T = smgr->addMeshSceneNode(mesh2T, 0, -1, SceneNode->getPosition(), SceneNode->getRotation(), SceneNode->getScale() );
	mesh2T->drop();

	scene::IMesh * meshTangents = MeshManipulator->createMeshWithTangents(SceneNode->getMesh(), false, false, false);
	SceneNodeTangents = smgr->addMeshSceneNode(meshTangents, 0, -1
										, SceneNode->getPosition(), SceneNode->getRotation(), SceneNode->getScale() );
	meshTangents->drop();


	// add one light
	NodeLight = smgr->addLightSceneNode(0, core::vector3df(0, 0, -40),
											video::SColorf(1.0f, 1.0f, 1.0f),
											35.0f);
	LightControl = new CLightNodeControl();
	LightControl->init(NodeLight, guiEnv, core::position2d<s32>(550,controlsTop), L"Dynamic light" );

	// one large cube around everything. That's mainly to make the light more obvious.
	scene::IMeshSceneNode* backgroundCube = smgr->addCubeSceneNode (200.0f, 0, -1, core::vector3df(0, 0, 0),
									   core::vector3df(45, 0, 0),
									   core::vector3df(1.0f, 1.0f, 1.0f));
	backgroundCube->getMaterial(0).BackfaceCulling = false;	 		// we are within the cube, so we have to disable backface culling to see it
	backgroundCube->getMaterial(0).EmissiveColor.set(255,50,50,50);	// we keep some self lighting to keep texts visible


	// Add a the mesh vertex color control
	guiEnv->addStaticText(L"Mesh", core::rect<s32>(200, controlsTop, 270, controlsTop+15), false, false, 0, -1, false);
	ControlVertexColors = new CColorControl( guiEnv, core::position2d<s32>(200, controlsTop+15), L"Vertex colors", guiEnv->getRootGUIElement());
	video::S3DVertex * vertices =  (video::S3DVertex *)SceneNode->getMesh()->getMeshBuffer(0)->getVertices();
	if ( vertices )
	{
		ControlVertexColors->setColor(vertices[0].Color);
	}

	// Add a control for ambient light
	GlobalAmbient = new CColorControl( guiEnv, core::position2d<s32>(550, 300), L"Global ambient", guiEnv->getRootGUIElement());
	GlobalAmbient->setColor( smgr->getAmbientLight().toSColor() );

	return true;
}

/*
	Update one frame
*/
bool CApp::update()
{
	using namespace irr;

	video::IVideoDriver* videoDriver =  Device->getVideoDriver();
	if ( !Device->run() )
		return false;

	// Figure out delta time since last frame
	ITimer * timer = Device->getTimer();
	u32 newTick = timer->getRealTime();
	f32 deltaTime = RealTimeTick > 0 ? f32(newTick-RealTimeTick)/1000.0 : 0.f;	// in seconds
	RealTimeTick = newTick;

	if ( Device->isWindowActive() || Config.RenderInBackground )
	{
		gui::IGUIEnvironment* guiEnv = Device->getGUIEnvironment();
		scene::ISceneManager* smgr = Device->getSceneManager();
		gui::IGUISkin * skin = guiEnv->getSkin();

		// update our controls
		MeshMaterialControl->update(SceneNode, SceneNode2T, SceneNodeTangents);
		LightControl->update(NodeLight);

		// Update vertices
		if ( ControlVertexColors->isDirty() )
		{
			MeshManipulator->setVertexColors (SceneNode->getMesh(), ControlVertexColors->getColor());
			MeshManipulator->setVertexColors (SceneNode2T->getMesh(), ControlVertexColors->getColor());
			MeshManipulator->setVertexColors (SceneNodeTangents->getMesh(), ControlVertexColors->getColor());
			ControlVertexColors->resetDirty();
		}

		// update ambient light settings
		if ( GlobalAmbient->isDirty() )
		{
			smgr->setAmbientLight( GlobalAmbient->getColor() );
			GlobalAmbient->resetDirty();
		}

		// Let the user move the light around
		const float zoomSpeed = 10.f * deltaTime;
		const float rotationSpeed = 100.f * deltaTime;
		if ( KeysPressed[KEY_PLUS] || KeysPressed[KEY_ADD])
			ZoomOut(NodeLight, zoomSpeed);
		if ( KeysPressed[KEY_MINUS] || KeysPressed[KEY_SUBTRACT])
			ZoomOut(NodeLight, -zoomSpeed);
		if ( KeysPressed[KEY_RIGHT])
			RotateHorizontal(NodeLight, rotationSpeed);
		if ( KeysPressed[KEY_LEFT])
			RotateHorizontal(NodeLight, -rotationSpeed);
		UpdateRotationAxis(NodeLight, LightRotationAxis);
		if ( KeysPressed[KEY_UP])
			RotateAroundAxis(NodeLight, rotationSpeed, LightRotationAxis);
		if ( KeysPressed[KEY_DOWN])
			RotateAroundAxis(NodeLight, -rotationSpeed, LightRotationAxis);

		// Let the user move the camera around
		if (MousePressed)
		{
			gui::ICursorControl* cursorControl = Device->getCursorControl();
			const core::position2d<s32>& mousePos = cursorControl->getPosition ();
			RotateHorizontal(Camera, rotationSpeed * (MouseStart.X - mousePos.X));
			RotateAroundAxis(Camera, rotationSpeed * (mousePos.Y - MouseStart.Y), CameraRotationAxis);
			MouseStart = mousePos;
		}

		// draw everything
		video::SColor bkColor( skin->getColor(gui::EGDC_APP_WORKSPACE) );
		videoDriver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, bkColor);

		smgr->drawAll();
		guiEnv->drawAll();

		if ( MeshMaterialControl->isLightingEnabled() )
		{
			// draw a line from the light to the target
			video::SMaterial lineMaterial;
			lineMaterial.Lighting = false;
			videoDriver->setMaterial(lineMaterial);
			videoDriver->setTransform(video::ETS_WORLD, core::IdentityMatrix);
			videoDriver->draw3DLine(NodeLight->getAbsolutePosition(), SceneNode->getAbsolutePosition());
		}

		videoDriver->endScene();
	}

	// be nice
	Device->sleep( 5 );

	return true;
}

// Close down the application
void CApp::quit()
{
	IsRunning = false;

	delete LightControl;
	LightControl = NULL;

	delete MeshMaterialControl;
	MeshMaterialControl = NULL;

	if ( ControlVertexColors )
	{
		ControlVertexColors->drop();
		ControlVertexColors = NULL;
	}
	if ( GlobalAmbient )
	{
		GlobalAmbient->drop();
		GlobalAmbient = NULL;
	}
	if ( Device )
	{
		Device->closeDevice();
		Device->drop();
		Device = NULL;
	}
}

// Create some useful textures.
void CApp::createDefaultTextures(video::IVideoDriver * driver)
{
	const u32 width = 256;
	const u32 height = 256;
	video::IImage * imageA8R8G8B8 = driver->createImage (video::ECF_A8R8G8B8, core::dimension2d<u32>(width, height));
	if ( !imageA8R8G8B8 )
		return;
	const u32 pitch = imageA8R8G8B8->getPitch();

	// Some nice square-pattern with 9 typical colors
	// Note that the function put readability over speed, you shouldn't use setPixel at runtime but for initialization it's nice.
	for ( u32 y = 0; y < height; ++ y )
	{
		for ( u32 x = 0; x < pitch; ++x )
		{
			if ( y < height/3 )
			{
				if ( x < width/3 )
					imageA8R8G8B8->setPixel (x, y, SCOL_BLACK);
				else if ( x < 2*width/3 )
					imageA8R8G8B8->setPixel (x, y, SCOL_BLUE);
				else
					imageA8R8G8B8->setPixel (x, y, SCOL_CYAN);
			}
			else if ( y < 2*height/3 )
			{
				if ( x < width/3 )
					imageA8R8G8B8->setPixel (x, y, SCOL_GRAY);
				else if ( x < 2*width/3 )
					imageA8R8G8B8->setPixel (x, y, SCOL_GREEN);
				else
					imageA8R8G8B8->setPixel (x, y, SCOL_MAGENTA);
			}
			else
			{
				if ( x < width/3 )
					imageA8R8G8B8->setPixel (x, y, SCOL_RED);
				else if ( x < 2*width/3 )
					imageA8R8G8B8->setPixel (x, y, SCOL_YELLOW);
				else
					imageA8R8G8B8->setPixel (x, y, SCOL_WHITE);
			}
		}
	}
	driver->addTexture (io::path("CARO_A8R8G8B8"), imageA8R8G8B8);

	// all white
	imageA8R8G8B8->fill(SCOL_WHITE);
	driver->addTexture (io::path("WHITE_A8R8G8B8"), imageA8R8G8B8);

	// all black
	imageA8R8G8B8->fill(SCOL_BLACK);
	driver->addTexture (io::path("BLACK_A8R8G8B8"), imageA8R8G8B8);

	// gray-scale
	for ( u32 y = 0; y < height; ++ y )
	{
		for ( u32 x = 0; x < pitch; ++x )
		{
			imageA8R8G8B8->setPixel (x, y, video::SColor(y, x,x,x) );
		}
	}
	driver->addTexture (io::path("GRAYSCALE_A8R8G8B8"), imageA8R8G8B8);

	imageA8R8G8B8->drop();
}

// Load a texture and make sure nodes know it when more textures are available.
void CApp::loadTexture(const io::path &name)
{
	Device->getVideoDriver()->getTexture(name);
	MeshMaterialControl->updateTextures();
}

void CApp::RotateHorizontal(irr::scene::ISceneNode* node, irr::f32 angle)
{
	if ( node )
	{
		core::vector3df pos(node->getPosition());
		core::vector2df dir(pos.X, pos.Z);
		dir.rotateBy(angle);
		pos.X = dir.X;
		pos.Z = dir.Y;
		node->setPosition(pos);
	}
}

void CApp::RotateAroundAxis(irr::scene::ISceneNode* node, irr::f32 angle, const irr::core::vector3df& axis)
{
	if ( node )
	{
		// TOOD: yeah, doesn't rotate around top/bottom yet. Fixes welcome.
		core::vector3df pos(node->getPosition());
		core::matrix4 mat;
		mat.setRotationAxisRadians (core::degToRad(angle), axis);
		mat.rotateVect(pos);
		node->setPosition(pos);
	}
}

void CApp::ZoomOut(irr::scene::ISceneNode* node, irr::f32 units)
{
	if ( node )
	{
		core::vector3df pos(node->getPosition());
		irr::f32 len = pos.getLength() + units;
		pos.setLength(len);
		node->setPosition(pos);
	}
}

void CApp::UpdateRotationAxis(irr::scene::ISceneNode* node, irr::core::vector3df& axis)
{
	// Find a perpendicular axis to the x,z vector. If none found (vector straight up/down) continue to use the existing one.
	core::vector3df pos(node->getPosition());
	if ( !core::equals(pos.X, 0.f) || !core::equals(pos.Z, 0.f) )
	{
		axis.X = -pos.Z;
		axis.Z = pos.X;
		axis.normalize();
	}
}

/*
  Short main as most is done in classes.
*/
int main(int argc, char *argv[])
{
	CApp APP;

	if ( !APP.init(argc, argv) )
	{
		printf("init failed\n");
		APP.quit();
		return 1;
	}

	APP.setRunning(true);

	/*
		main application loop
	*/
	while(APP.isRunning())
	{
		if ( !APP.update() )
			break;
	}

	APP.quit();

	return 0;
}

/*
**/
