/** Example 009 Mesh Viewer

This tutorial show how to create a more complex application with the engine.
We construct a simple mesh viewer using the user interface API and the
scene management of Irrlicht. The tutorial show how to create and use Buttons,
Windows, Toolbars, Menus, ComboBoxes, Tabcontrols, Editboxes, Images,
MessageBoxes, SkyBoxes, and how to parse XML files with the integrated XML
reader of the engine.

We start like in most other tutorials: Include all necessary header files, add
a comment to let the engine be linked with the correct .lib file in Visual
Studio, and declare some global variables. We also add two 'using namespace'
statements, so we do not need to write the whole names of all classes. In this
tutorial, we use a lot of stuff from the gui namespace.
*/
#include <irrlicht.h>
#include "driverChoice.h"
#include "exampleHelper.h"

using namespace irr;
using namespace gui;

#ifdef _MSC_VER
#pragma comment(lib, "Irrlicht.lib")
#endif


/*
Some global variables used later on
*/
IrrlichtDevice *Device = 0;
io::path StartUpModelFile;
core::stringw MessageText;
core::stringw Caption;
scene::ISceneNode* Model = 0;
scene::ISceneNode* SkyBox = 0;
bool Octree=false;
bool UseLight=false;

scene::ICameraSceneNode* Camera[2] = {0, 0};

// Values used to identify individual GUI elements
enum
{
	GUI_ID_DIALOG_ROOT_WINDOW  = 0x10000,

	GUI_ID_X_SCALE,
	GUI_ID_Y_SCALE,
	GUI_ID_Z_SCALE,

	GUI_ID_OPEN_MODEL,
	GUI_ID_SET_MODEL_ARCHIVE,
	GUI_ID_LOAD_AS_OCTREE,

	GUI_ID_SKY_BOX_VISIBLE,
	GUI_ID_TOGGLE_DEBUG_INFO,

	GUI_ID_DEBUG_OFF,
	GUI_ID_DEBUG_BOUNDING_BOX,
	GUI_ID_DEBUG_NORMALS,
	GUI_ID_DEBUG_SKELETON,
	GUI_ID_DEBUG_WIRE_OVERLAY,
	GUI_ID_DEBUG_HALF_TRANSPARENT,
	GUI_ID_DEBUG_BUFFERS_BOUNDING_BOXES,
	GUI_ID_DEBUG_ALL,

	GUI_ID_MODEL_MATERIAL_SOLID,
	GUI_ID_MODEL_MATERIAL_TRANSPARENT,
	GUI_ID_MODEL_MATERIAL_REFLECTION,

	GUI_ID_CAMERA_MAYA,
	GUI_ID_CAMERA_FIRST_PERSON,

	GUI_ID_POSITION_TEXT,

	GUI_ID_ABOUT,
	GUI_ID_QUIT,

	GUI_ID_TEXTUREFILTER,
	GUI_ID_SKIN_TRANSPARENCY,
	GUI_ID_SKIN_ANIMATION_FPS,

	GUI_ID_BUTTON_SET_SCALE,
	GUI_ID_BUTTON_SCALE_MUL10,
	GUI_ID_BUTTON_SCALE_DIV10,
	GUI_ID_BUTTON_OPEN_MODEL,
	GUI_ID_BUTTON_SHOW_ABOUT,
	GUI_ID_BUTTON_SHOW_TOOLBOX,
	GUI_ID_BUTTON_SELECT_ARCHIVE,

	GUI_ID_ANIMATION_INFO,

	// And some magic numbers
	MAX_FRAMERATE = 80,
	DEFAULT_FRAMERATE = 30
};


/*
Toggle between various cameras
*/
void setActiveCamera(scene::ICameraSceneNode* newActive)
{
	if (0 == Device)
		return;

	scene::ICameraSceneNode * active = Device->getSceneManager()->getActiveCamera();
	active->setInputReceiverEnabled(false);

	newActive->setInputReceiverEnabled(true);
	Device->getSceneManager()->setActiveCamera(newActive);
}

/*
	Set the skin transparency by changing the alpha values of all skin-colors
*/
void setSkinTransparency(s32 alpha, irr::gui::IGUISkin * skin)
{
	for (s32 i=0; i<irr::gui::EGDC_COUNT ; ++i)
	{
		video::SColor col = skin->getColor((EGUI_DEFAULT_COLOR)i);
		col.setAlpha(alpha);
		skin->setColor((EGUI_DEFAULT_COLOR)i, col);
	}
}

/*
  Update the display of the model scaling
*/
void updateScaleInfo(scene::ISceneNode* model)
{
	IGUIElement* toolboxWnd = Device->getGUIEnvironment()->getRootGUIElement()->getElementFromId(GUI_ID_DIALOG_ROOT_WINDOW, true);
	if (!toolboxWnd)
		return;
	if (!model)
	{
		toolboxWnd->getElementFromId(GUI_ID_X_SCALE, true)->setText( L"-" );
		toolboxWnd->getElementFromId(GUI_ID_Y_SCALE, true)->setText( L"-" );
		toolboxWnd->getElementFromId(GUI_ID_Z_SCALE, true)->setText( L"-" );
	}
	else
	{
		core::vector3df scale = model->getScale();
		toolboxWnd->getElementFromId(GUI_ID_X_SCALE, true)->setText( core::stringw(scale.X).c_str() );
		toolboxWnd->getElementFromId(GUI_ID_Y_SCALE, true)->setText( core::stringw(scale.Y).c_str() );
		toolboxWnd->getElementFromId(GUI_ID_Z_SCALE, true)->setText( core::stringw(scale.Z).c_str() );
	}
}

/*
Function showAboutText() displays a messagebox with a caption and
a message text. The texts will be stored in the MessageText and Caption
variables at startup.
*/
void showAboutText()
{
	// create modal message box with the text
	// loaded from the xml file.
	Device->getGUIEnvironment()->addMessageBox(
		Caption.c_str(), MessageText.c_str());
}


/*
Function loadModel() loads a model and displays it using an
addAnimatedMeshSceneNode and the scene manager. Nothing difficult. It also
displays a short message box, if the model could not be loaded.
*/
void loadModel(const io::path& filename)
{
	io::path extension;
	core::getFileNameExtension(extension, filename);
	extension.make_lower();

	// if a texture is loaded apply it to the current model..
	if (extension == ".jpg" || extension == ".pcx" ||
		extension == ".png" || extension == ".ppm" ||
		extension == ".pgm" || extension == ".pbm" ||
		extension == ".psd" || extension == ".tga" ||
		extension == ".bmp" || extension == ".wal" ||
		extension == ".rgb" || extension == ".rgba")
	{
		// Ensure reloading texture by clearing old one out of cache
		video::ITexture * texture = Device->getVideoDriver()->findTexture( filename );
		if ( texture )
			Device->getVideoDriver()->removeTexture(texture);

		// Load the new one and put int on the model
		texture = Device->getVideoDriver()->getTexture( filename );
		if ( texture && Model )
		{
			Model->setMaterialTexture(0, texture);
		}
		return;
	}
	// if a archive is loaded add it to the FileArchive..
	else if (extension == ".pk3" || extension == ".zip" || extension == ".pak" || extension == ".npk")
	{
		Device->getFileSystem()->addFileArchive(filename.c_str());
		return;
	}

	// Remove old model

	if (Model)
	{
		Model->remove();
		Model = 0;
	}

	// .irr is a scene format, so load as scene and set Model pointer to first object in the scene

	if (extension==".irr")
	{
		core::array<scene::ISceneNode*> outNodes;
		Device->getSceneManager()->loadScene(filename);
		Device->getSceneManager()->getSceneNodesFromType(scene::ESNT_ANIMATED_MESH, outNodes);
		if (outNodes.size())
			Model = outNodes[0];
		return;
	}

	// load a model into the engine. Also log the time it takes to load it.

	u32 then = Device->getTimer()->getRealTime();
	scene::IAnimatedMesh* mesh = Device->getSceneManager()->getMesh( filename.c_str() );
	Device->getLogger()->log("Loading time (ms): ", core::stringc(Device->getTimer()->getRealTime() - then).c_str());

	if (!mesh)
	{
		// model could not be loaded

		if (StartUpModelFile != filename)
			Device->getGUIEnvironment()->addMessageBox(
			Caption.c_str(), L"The model could not be loaded. " \
			L"Maybe it is not a supported file format.");
		return;
	}

	// set default material properties

	if (Octree)
		Model = Device->getSceneManager()->addOctreeSceneNode(mesh->getMesh(0));
	else
	{
		scene::IAnimatedMeshSceneNode* animModel = Device->getSceneManager()->addAnimatedMeshSceneNode(mesh);
		Model = animModel;
	}
	Model->setMaterialFlag(video::EMF_LIGHTING, UseLight);
	Model->setMaterialFlag(video::EMF_NORMALIZE_NORMALS, UseLight);
//	Model->setMaterialFlag(video::EMF_BACK_FACE_CULLING, false);
	Model->setDebugDataVisible(scene::EDS_OFF);

	// we need to uncheck the menu entries. would be cool to fake a menu event, but
	// that's not so simple. so we do it brute force
	gui::IGUIContextMenu* menu = (gui::IGUIContextMenu*)Device->getGUIEnvironment()->getRootGUIElement()->getElementFromId(GUI_ID_TOGGLE_DEBUG_INFO, true);
	if (menu)
		for(int item = 1; item < 6; ++item)
			menu->setItemChecked(item, false);
	updateScaleInfo(Model);
}


/*
Function createToolBox() creates a toolbox window. In this simple mesh
viewer, this toolbox only contains a controls to change the scale
and animation speed of the model and a control to set the transparency
of the GUI-elements.
*/
void createToolBox()
{
	// remove tool box if already there
	IGUIEnvironment* env = Device->getGUIEnvironment();
	IGUIElement* root = env->getRootGUIElement();
	IGUIElement* e = root->getElementFromId(GUI_ID_DIALOG_ROOT_WINDOW, true);
	if (e)
		e->remove();

	// create the toolbox window
	IGUIWindow* wnd = env->addWindow(core::rect<s32>(600,45,800,480),
		false, L"Toolset", 0, GUI_ID_DIALOG_ROOT_WINDOW);

	// create tab control and tabs
	IGUITabControl* tab = env->addTabControl(
		core::rect<s32>(2,20,800-602,480-7), wnd, true, true);

	IGUITab* t1 = tab->addTab(L"Config");

	// add some edit boxes and a button to tab one
	env->addStaticText(L"Scale:",
			core::rect<s32>(10,20,60,45), false, false, t1);
	env->addStaticText(L"X:", core::rect<s32>(22,48,40,66), false, false, t1);
	env->addEditBox(L"1.0", core::rect<s32>(40,46,130,66), true, t1, GUI_ID_X_SCALE);
	env->addStaticText(L"Y:", core::rect<s32>(22,82,40,96), false, false, t1);
	env->addEditBox(L"1.0", core::rect<s32>(40,76,130,96), true, t1, GUI_ID_Y_SCALE);
	env->addStaticText(L"Z:", core::rect<s32>(22,108,40,126), false, false, t1);
	env->addEditBox(L"1.0", core::rect<s32>(40,106,130,126), true, t1, GUI_ID_Z_SCALE);

	env->addButton(core::rect<s32>(10,134,85,165), t1, GUI_ID_BUTTON_SET_SCALE, L"Set");

	// quick scale buttons
	env->addButton(core::rect<s32>(65,20,95,40), t1, GUI_ID_BUTTON_SCALE_MUL10, L"* 10");
	env->addButton(core::rect<s32>(100,20,130,40), t1, GUI_ID_BUTTON_SCALE_DIV10, L"* 0.1");

	updateScaleInfo(Model);

	// add transparency control
	env->addStaticText(L"GUI Transparency Control:",
			core::rect<s32>(10,200,150,225), true, false, t1);
	IGUIScrollBar* scrollbar = env->addScrollBar(true,
			core::rect<s32>(10,225,150,240), t1, GUI_ID_SKIN_TRANSPARENCY);
	scrollbar->setMax(255);
	scrollbar->setPos(255);

	// add framerate control
	env->addStaticText(L":", core::rect<s32>(10,240,150,265), true, false, t1);
	env->addStaticText(L"Framerate:",
			core::rect<s32>(12,240,75,265), false, false, t1);
	// current frame info
	env->addStaticText(L"", core::rect<s32>(75,240,200,265), false, false, t1,
			GUI_ID_ANIMATION_INFO);
	scrollbar = env->addScrollBar(true,
			core::rect<s32>(10,265,150,280), t1, GUI_ID_SKIN_ANIMATION_FPS);
	scrollbar->setMax(MAX_FRAMERATE);
	scrollbar->setMin(-MAX_FRAMERATE);
	scrollbar->setPos(DEFAULT_FRAMERATE);
	scrollbar->setSmallStep(1);
}

/*
Function updateToolBox() is called each frame to update dynamic information in
the toolbox.
*/
void updateToolBox()
{
	IGUIEnvironment* env = Device->getGUIEnvironment();
	IGUIElement* root = env->getRootGUIElement();
	IGUIElement* dlg = root->getElementFromId(GUI_ID_DIALOG_ROOT_WINDOW, true);
	if (!dlg )
		return;

	// update the info we have about the animation of the model
	IGUIStaticText *  aniInfo = (IGUIStaticText *)(dlg->getElementFromId(GUI_ID_ANIMATION_INFO, true));
	if (aniInfo)
	{
		if ( Model && scene::ESNT_ANIMATED_MESH == Model->getType() )
		{
			scene::IAnimatedMeshSceneNode* animatedModel = (scene::IAnimatedMeshSceneNode*)Model;

			core::stringw str( (s32)core::round_(animatedModel->getAnimationSpeed()) );
			str += L" Frame: ";
			str += core::stringw((s32)animatedModel->getFrameNr());
			aniInfo->setText(str.c_str());
		}
		else
			aniInfo->setText(L"");
	}
}

void onKillFocus()
{
	// Avoid that the FPS-camera continues moving when the user presses alt-tab while
	// moving the camera.
	const core::list<scene::ISceneNodeAnimator*>& animators = Camera[1]->getAnimators();
	core::list<irr::scene::ISceneNodeAnimator*>::ConstIterator iter = animators.begin();
	while ( iter != animators.end() )
	{
		if ( (*iter)->getType() == scene::ESNAT_CAMERA_FPS )
		{
			// we send a key-down event for all keys used by this animator
			scene::ISceneNodeAnimatorCameraFPS * fpsAnimator = static_cast<scene::ISceneNodeAnimatorCameraFPS*>(*iter);
			const core::array<SKeyMap>& keyMap = fpsAnimator->getKeyMap();
			for ( irr::u32 i=0; i< keyMap.size(); ++i )
			{
				irr::SEvent event;
				event.EventType = EET_KEY_INPUT_EVENT;
				event.KeyInput.Key = keyMap[i].KeyCode;
				event.KeyInput.PressedDown = false;
				fpsAnimator->OnEvent(event);
			}
		}
		++iter;
	}
}

/*
Function hasModalDialog() checks if we currently have a modal dialog open.
*/
bool hasModalDialog()
{
	if ( !Device )
		return false;
	IGUIEnvironment* env = Device->getGUIEnvironment();
	IGUIElement * focused = env->getFocus();
	while ( focused )
	{
		if ( focused->isVisible() && focused->hasType(EGUIET_MODAL_SCREEN) )
			return true;
		focused = focused->getParent();
	}
	return false;
}

/*
To get all the events sent by the GUI Elements, we need to create an event
receiver. This one is really simple. If an event occurs, it checks the id of
the caller and the event type, and starts an action based on these values. For
example, if a menu item with id GUI_ID_OPEN_MODEL was selected, it opens a file-open-dialog.
*/
class MyEventReceiver : public IEventReceiver
{
public:
	virtual bool OnEvent(const SEvent& event)
	{
		// Key events
		if (event.EventType == EET_KEY_INPUT_EVENT &&
			event.KeyInput.PressedDown == false)
		{
			if ( OnKeyUp(event.KeyInput.Key) )
				return true;
		}

		// GUI events
		if (event.EventType == EET_GUI_EVENT)
		{
			s32 id = event.GUIEvent.Caller->getID();
			IGUIEnvironment* env = Device->getGUIEnvironment();

			switch(event.GUIEvent.EventType)
			{
			case EGET_MENU_ITEM_SELECTED:
					// a menu item was clicked
					OnMenuItemSelected( (IGUIContextMenu*)event.GUIEvent.Caller );
				break;

			case EGET_FILE_SELECTED:
				{
					// load the model file, selected in the file open dialog
					IGUIFileOpenDialog* dialog =
						(IGUIFileOpenDialog*)event.GUIEvent.Caller;
					loadModel(dialog->getFileNameP());
				}
				break;

			case EGET_SCROLL_BAR_CHANGED:

				// control skin transparency
				if (id == GUI_ID_SKIN_TRANSPARENCY)
				{
					const s32 pos = ((IGUIScrollBar*)event.GUIEvent.Caller)->getPos();
					setSkinTransparency(pos, env->getSkin());
				}
				// control animation speed
				else if (id == GUI_ID_SKIN_ANIMATION_FPS)
				{
					const s32 pos = ((IGUIScrollBar*)event.GUIEvent.Caller)->getPos();
					if (scene::ESNT_ANIMATED_MESH == Model->getType())
						((scene::IAnimatedMeshSceneNode*)Model)->setAnimationSpeed((f32)pos);
				}
				break;

			case EGET_COMBO_BOX_CHANGED:

				// control anti-aliasing/filtering
				if (id == GUI_ID_TEXTUREFILTER)
				{
					OnTextureFilterSelected( (IGUIComboBox*)event.GUIEvent.Caller );
				}
				break;

			case EGET_BUTTON_CLICKED:

				switch(id)
				{
				case GUI_ID_BUTTON_SET_SCALE:
					{
						// set model scale
						gui::IGUIElement* root = env->getRootGUIElement();
						core::vector3df scale;
						core::stringc s;

						s = root->getElementFromId(GUI_ID_X_SCALE, true)->getText();
						scale.X = (f32)atof(s.c_str());
						s = root->getElementFromId(GUI_ID_Y_SCALE, true)->getText();
						scale.Y = (f32)atof(s.c_str());
						s = root->getElementFromId(GUI_ID_Z_SCALE, true)->getText();
						scale.Z = (f32)atof(s.c_str());

						if (Model)
							Model->setScale(scale);
						updateScaleInfo(Model);
					}
					break;
				case GUI_ID_BUTTON_SCALE_MUL10:
					if (Model)
						Model->setScale(Model->getScale()*10.f);
					updateScaleInfo(Model);
					break;
				case GUI_ID_BUTTON_SCALE_DIV10:
					if (Model)
						Model->setScale(Model->getScale()*0.1f);
					updateScaleInfo(Model);
					break;
				case GUI_ID_BUTTON_OPEN_MODEL:
					env->addFileOpenDialog(L"Please select a model file to open");
					break;
				case GUI_ID_BUTTON_SHOW_ABOUT:
					showAboutText();
					break;
				case GUI_ID_BUTTON_SHOW_TOOLBOX:
					createToolBox();
					break;
				case GUI_ID_BUTTON_SELECT_ARCHIVE:
					env->addFileOpenDialog(L"Please select your game archive/directory");
					break;
				}

				break;
			default:
				break;
			}
		}

		return false;
	}


	/*
		Handle key-up events
	*/
	bool OnKeyUp(irr::EKEY_CODE keyCode)
	{
		// Don't handle keys if we have a modal dialog open as it would lead
		// to unexpected application behaviour for the user.
		if ( hasModalDialog() )
			return false;

		// Escape swaps Camera Input
		if (keyCode == irr::KEY_ESCAPE)
		{
			if (Device)
			{
				scene::ICameraSceneNode * camera =
					Device->getSceneManager()->getActiveCamera();
				if (camera)
				{
					camera->setInputReceiverEnabled( !camera->isInputReceiverEnabled() );
				}
				return true;
			}
		}
		else if (keyCode == irr::KEY_F1)
		{
			// Swap display of position information about the camera
			if (Device)
			{
				IGUIElement* elem = Device->getGUIEnvironment()->getRootGUIElement()->getElementFromId(GUI_ID_POSITION_TEXT);
				if (elem)
					elem->setVisible(!elem->isVisible());
			}
		}
		else if (keyCode == irr::KEY_KEY_M)
		{
			if (Device)
				Device->minimizeWindow();
		}
		else if (keyCode == irr::KEY_KEY_L)
		{
			UseLight=!UseLight;
			if (Model)
			{
				Model->setMaterialFlag(video::EMF_LIGHTING, UseLight);
				Model->setMaterialFlag(video::EMF_NORMALIZE_NORMALS, UseLight);
			}
		}
		return false;
	}


	/*
		Handle "menu item clicked" events.
	*/
	void OnMenuItemSelected( IGUIContextMenu* menu )
	{
		s32 id = menu->getItemCommandId(menu->getSelectedItem());
		IGUIEnvironment* env = Device->getGUIEnvironment();

		switch(id)
		{
		case GUI_ID_OPEN_MODEL: // File -> Open Model File & Texture
			env->addFileOpenDialog(L"Please select a model file to open");
			break;
		case GUI_ID_SET_MODEL_ARCHIVE: // File -> Set Model Archive
			env->addFileOpenDialog(L"Please select your game archive/directory");
			break;
		case GUI_ID_LOAD_AS_OCTREE: // File -> LoadAsOctree
			Octree = !Octree;
			menu->setItemChecked(menu->getSelectedItem(), Octree);
			break;
		case GUI_ID_QUIT: // File -> Quit
			Device->closeDevice();
			break;
		case GUI_ID_SKY_BOX_VISIBLE: // View -> Skybox
			menu->setItemChecked(menu->getSelectedItem(), !menu->isItemChecked(menu->getSelectedItem()));
			SkyBox->setVisible(!SkyBox->isVisible());
			break;
		case GUI_ID_DEBUG_OFF: // View -> Debug Information
			menu->setItemChecked(menu->getSelectedItem()+1, false);
			menu->setItemChecked(menu->getSelectedItem()+2, false);
			menu->setItemChecked(menu->getSelectedItem()+3, false);
			menu->setItemChecked(menu->getSelectedItem()+4, false);
			menu->setItemChecked(menu->getSelectedItem()+5, false);
			menu->setItemChecked(menu->getSelectedItem()+6, false);
			if (Model)
				Model->setDebugDataVisible(scene::EDS_OFF);
			break;
		case GUI_ID_DEBUG_BOUNDING_BOX: // View -> Debug Information
			menu->setItemChecked(menu->getSelectedItem(), !menu->isItemChecked(menu->getSelectedItem()));
			if (Model)
				Model->setDebugDataVisible((scene::E_DEBUG_SCENE_TYPE)(Model->isDebugDataVisible()^scene::EDS_BBOX));
			break;
		case GUI_ID_DEBUG_NORMALS: // View -> Debug Information
			menu->setItemChecked(menu->getSelectedItem(), !menu->isItemChecked(menu->getSelectedItem()));
			if (Model)
				Model->setDebugDataVisible((scene::E_DEBUG_SCENE_TYPE)(Model->isDebugDataVisible()^scene::EDS_NORMALS));
			break;
		case GUI_ID_DEBUG_SKELETON: // View -> Debug Information
			menu->setItemChecked(menu->getSelectedItem(), !menu->isItemChecked(menu->getSelectedItem()));
			if (Model)
				Model->setDebugDataVisible((scene::E_DEBUG_SCENE_TYPE)(Model->isDebugDataVisible()^scene::EDS_SKELETON));
			break;
		case GUI_ID_DEBUG_WIRE_OVERLAY: // View -> Debug Information
			menu->setItemChecked(menu->getSelectedItem(), !menu->isItemChecked(menu->getSelectedItem()));
			if (Model)
				Model->setDebugDataVisible((scene::E_DEBUG_SCENE_TYPE)(Model->isDebugDataVisible()^scene::EDS_MESH_WIRE_OVERLAY));
			break;
		case GUI_ID_DEBUG_HALF_TRANSPARENT: // View -> Debug Information
			menu->setItemChecked(menu->getSelectedItem(), !menu->isItemChecked(menu->getSelectedItem()));
			if (Model)
				Model->setDebugDataVisible((scene::E_DEBUG_SCENE_TYPE)(Model->isDebugDataVisible()^scene::EDS_HALF_TRANSPARENCY));
			break;
		case GUI_ID_DEBUG_BUFFERS_BOUNDING_BOXES: // View -> Debug Information
			menu->setItemChecked(menu->getSelectedItem(), !menu->isItemChecked(menu->getSelectedItem()));
			if (Model)
				Model->setDebugDataVisible((scene::E_DEBUG_SCENE_TYPE)(Model->isDebugDataVisible()^scene::EDS_BBOX_BUFFERS));
			break;
		case GUI_ID_DEBUG_ALL: // View -> Debug Information
			menu->setItemChecked(menu->getSelectedItem()-1, true);
			menu->setItemChecked(menu->getSelectedItem()-2, true);
			menu->setItemChecked(menu->getSelectedItem()-3, true);
			menu->setItemChecked(menu->getSelectedItem()-4, true);
			menu->setItemChecked(menu->getSelectedItem()-5, true);
			menu->setItemChecked(menu->getSelectedItem()-6, true);
			if (Model)
				Model->setDebugDataVisible(scene::EDS_FULL);
			break;
		case GUI_ID_ABOUT: // Help->About
			showAboutText();
			break;
		case GUI_ID_MODEL_MATERIAL_SOLID: // View -> Material -> Solid
			if (Model)
				Model->setMaterialType(video::EMT_SOLID);
			break;
		case GUI_ID_MODEL_MATERIAL_TRANSPARENT: // View -> Material -> Transparent
			if (Model)
				Model->setMaterialType(video::EMT_TRANSPARENT_ADD_COLOR);
			break;
		case GUI_ID_MODEL_MATERIAL_REFLECTION: // View -> Material -> Reflection
			if (Model)
				Model->setMaterialType(video::EMT_SPHERE_MAP);
			break;

		case GUI_ID_CAMERA_MAYA:
			setActiveCamera(Camera[0]);
			break;
		case GUI_ID_CAMERA_FIRST_PERSON:
			setActiveCamera(Camera[1]);
			break;
		}
	}

	/*
		Handle the event that one of the texture-filters was selected in the corresponding combobox.
	*/
	void OnTextureFilterSelected( IGUIComboBox* combo )
	{
		s32 pos = combo->getSelected();
		switch (pos)
		{
			case 0:
			if (Model)
			{
				Model->setMaterialFlag(video::EMF_BILINEAR_FILTER, false);
				Model->setMaterialFlag(video::EMF_TRILINEAR_FILTER, false);
				Model->setMaterialFlag(video::EMF_ANISOTROPIC_FILTER, false);
			}
			break;
			case 1:
			if (Model)
			{
				Model->setMaterialFlag(video::EMF_BILINEAR_FILTER, true);
				Model->setMaterialFlag(video::EMF_TRILINEAR_FILTER, false);
			}
			break;
			case 2:
			if (Model)
			{
				Model->setMaterialFlag(video::EMF_BILINEAR_FILTER, false);
				Model->setMaterialFlag(video::EMF_TRILINEAR_FILTER, true);
			}
			break;
			case 3:
			if (Model)
			{
				Model->setMaterialFlag(video::EMF_ANISOTROPIC_FILTER, true);
			}
			break;
			case 4:
			if (Model)
			{
				Model->setMaterialFlag(video::EMF_ANISOTROPIC_FILTER, false);
			}
			break;
		}
	}
};


/*
Most of the hard work is done. We only need to create the Irrlicht Engine
device and all the buttons, menus and toolbars. We start up the engine as
usual, using createDevice(). To make our application catch events, we set our
eventreceiver as parameter. As you can see, there is also a call to
IrrlichtDevice::setResizeable(). This makes the render window resizeable, which
is quite useful for a mesh viewer.
*/
int main(int argc, char* argv[])
{
	// ask user for driver
	video::E_DRIVER_TYPE driverType=driverChoiceConsole();
	if (driverType==video::EDT_COUNT)
		return 1;

	// create device and exit if creation failed
	MyEventReceiver receiver;
	Device = createDevice(driverType, core::dimension2d<u32>(800, 600),
		16, false, false, false, &receiver);

	if (Device == 0)
		return 1; // could not create selected driver.

	Device->setResizable(true);

	Device->setWindowCaption(L"Irrlicht Engine - Loading...");

	video::IVideoDriver* driver = Device->getVideoDriver();
	IGUIEnvironment* env = Device->getGUIEnvironment();
	scene::ISceneManager* smgr = Device->getSceneManager();
	smgr->getParameters()->setAttribute(scene::COLLADA_CREATE_SCENE_INSTANCES, true);

	driver->setTextureCreationFlag(video::ETCF_ALWAYS_32_BIT, true);

	smgr->addLightSceneNode(0, core::vector3df(200,200,200),
		video::SColorf(1.0f,1.0f,1.0f),2000);
	smgr->setAmbientLight(video::SColorf(0.3f,0.3f,0.3f));
	// add our media directory as "search path"
	Device->getFileSystem()->addFileArchive(getExampleMediaPath());

	/*
	The next step is to read the configuration file. It is stored in the xml
	format and looks a little bit like this:

	@verbatim
	<?xml version="1.0"?>
	<config>
		<startUpModel file="some filename" />
		<messageText caption="Irrlicht Engine Mesh Viewer">
			Hello!
		</messageText>
	</config>
	@endverbatim

	We need the data stored in there to be written into the global variables
	StartUpModelFile, MessageText and Caption. This is now done using the
	Irrlicht Engine integrated XML parser:
	*/

	// read configuration from xml file

	io::IXMLReader* xml = Device->getFileSystem()->createXMLReader( L"config.xml");

	while(xml && xml->read())
	{
		switch(xml->getNodeType())
		{
		case io::EXN_TEXT:
			// in this xml file, the only text which occurs is the
			// messageText
			MessageText = xml->getNodeData();
			break;
		case io::EXN_ELEMENT:
			{
				if (core::stringw("startUpModel") == xml->getNodeName())
					StartUpModelFile = xml->getAttributeValue(L"file");
				else
				if (core::stringw("messageText") == xml->getNodeName())
					Caption = xml->getAttributeValue(L"caption");
			}
			break;
		default:
			break;
		}
	}

	if (xml)
		xml->drop(); // don't forget to delete the xml reader

	// We can pass a model to load per command line parameter
	if (argc > 1)
		StartUpModelFile = argv[1];

	// set a nicer font
	IGUISkin* skin = env->getSkin();
	IGUIFont* font = env->getFont("fonthaettenschweiler.bmp");
	if (font)
		skin->setFont(font);

	/*
	Now create the Menu.
	It is possible to create submenus for every menu item. The call
	menu->addItem(L"File", -1, true, true); for example adds a new menu
	Item with the name "File" and the id -1. The following parameter says
	that the menu item should be enabled, and the last one says, that there
	should be a submenu. The submenu can now be accessed with
	menu->getSubMenu(0), because the "File" entry is the menu item with
	index 0.
	*/
	gui::IGUIContextMenu* menu = env->addMenu();
	menu->addItem(L"File", -1, true, true);
	menu->addItem(L"View", -1, true, true);
	menu->addItem(L"Camera", -1, true, true);
	menu->addItem(L"Help", -1, true, true);

	gui::IGUIContextMenu* submenu;
	submenu = menu->getSubMenu(0);
	submenu->addItem(L"Open Model File & Texture...", GUI_ID_OPEN_MODEL);
	submenu->addItem(L"Set Model Archive...", GUI_ID_SET_MODEL_ARCHIVE);
	submenu->addItem(L"Load as Octree", GUI_ID_LOAD_AS_OCTREE);
	submenu->addSeparator();
	submenu->addItem(L"Quit", GUI_ID_QUIT);

	submenu = menu->getSubMenu(1);
	submenu->addItem(L"sky box visible", GUI_ID_SKY_BOX_VISIBLE, true, false, true);
	submenu->addItem(L"toggle model debug information", GUI_ID_TOGGLE_DEBUG_INFO, true, true);
	submenu->addItem(L"model material", -1, true, true );

	submenu = submenu->getSubMenu(1);
	submenu->addItem(L"Off", GUI_ID_DEBUG_OFF);
	submenu->addItem(L"Bounding Box", GUI_ID_DEBUG_BOUNDING_BOX);
	submenu->addItem(L"Normals", GUI_ID_DEBUG_NORMALS);
	submenu->addItem(L"Skeleton", GUI_ID_DEBUG_SKELETON);
	submenu->addItem(L"Wire overlay", GUI_ID_DEBUG_WIRE_OVERLAY);
	submenu->addItem(L"Half-Transparent", GUI_ID_DEBUG_HALF_TRANSPARENT);
	submenu->addItem(L"Buffers bounding boxes", GUI_ID_DEBUG_BUFFERS_BOUNDING_BOXES);
	submenu->addItem(L"All", GUI_ID_DEBUG_ALL);

	submenu = menu->getSubMenu(1)->getSubMenu(2);
	submenu->addItem(L"Solid", GUI_ID_MODEL_MATERIAL_SOLID);
	submenu->addItem(L"Transparent", GUI_ID_MODEL_MATERIAL_TRANSPARENT);
	submenu->addItem(L"Reflection", GUI_ID_MODEL_MATERIAL_REFLECTION);

	submenu = menu->getSubMenu(2);
	submenu->addItem(L"Maya Style", GUI_ID_CAMERA_MAYA);
	submenu->addItem(L"First Person", GUI_ID_CAMERA_FIRST_PERSON);

	submenu = menu->getSubMenu(3);
	submenu->addItem(L"About", GUI_ID_ABOUT);

	/*
	Below the menu we want a toolbar, onto which we can place colored
	buttons and important looking stuff like a senseless combobox.
	*/

	// create toolbar

	gui::IGUIToolBar* bar = env->addToolBar();

	video::ITexture* image = driver->getTexture("open.png");
	bar->addButton(GUI_ID_BUTTON_OPEN_MODEL, 0, L"Open a model",image, 0, false, true);

	image = driver->getTexture("tools.png");
	bar->addButton(GUI_ID_BUTTON_SHOW_TOOLBOX, 0, L"Open Toolset",image, 0, false, true);

	image = driver->getTexture("zip.png");
	bar->addButton(GUI_ID_BUTTON_SELECT_ARCHIVE, 0, L"Set Model Archive",image, 0, false, true);

	image = driver->getTexture("help.png");
	bar->addButton(GUI_ID_BUTTON_SHOW_ABOUT, 0, L"Open Help", image, 0, false, true);

	// create a combobox for texture filters

	gui::IGUIComboBox* box = env->addComboBox(core::rect<s32>(250,4,350,23), bar, GUI_ID_TEXTUREFILTER);
	box->addItem(L"No filtering");
	box->addItem(L"Bilinear");
	box->addItem(L"Trilinear");
	box->addItem(L"Anisotropic");
	box->addItem(L"Isotropic");

	/*
	To make the editor look a little bit better, we disable transparent gui
	elements, and add an Irrlicht Engine logo. In addition, a text showing
	the current frames per second value is created and the window caption is
	changed.
	*/

	// disable alpha

	for (s32 i=0; i<gui::EGDC_COUNT ; ++i)
	{
		video::SColor col = env->getSkin()->getColor((gui::EGUI_DEFAULT_COLOR)i);
		col.setAlpha(255);
		env->getSkin()->setColor((gui::EGUI_DEFAULT_COLOR)i, col);
	}

	// add a tabcontrol

	createToolBox();

	// create fps text

	IGUIStaticText* fpstext = env->addStaticText(L"",
			core::rect<s32>(400,4,570,23), true, false, bar);

	IGUIStaticText* postext = env->addStaticText(L"",
			core::rect<s32>(10,50,470,80),false, false, 0, GUI_ID_POSITION_TEXT);
	postext->setVisible(false);

	// set window caption
	Caption += " - [";
	Caption += driver->getName();
	Caption += "]";
	Device->setWindowCaption(Caption.c_str());

	/*
	Now we show the about message box at start up, and load the first model.
	To make everything look	better a skybox is created. We also add a user
	controlled camera, to make the application more interactive.
	Finally, everything is drawn in a standard drawing loop.
	*/

	// show about message box and load default model
	if (argc==1)
		showAboutText();
	loadModel(StartUpModelFile.c_str());

	// add skybox
	SkyBox = smgr->addSkyBoxSceneNode(
		driver->getTexture("irrlicht2_up.jpg"),
		driver->getTexture("irrlicht2_dn.jpg"),
		driver->getTexture("irrlicht2_lf.jpg"),
		driver->getTexture("irrlicht2_rt.jpg"),
		driver->getTexture("irrlicht2_ft.jpg"),
		driver->getTexture("irrlicht2_bk.jpg"));

	// add a camera scene node
	Camera[0] = smgr->addCameraSceneNodeMaya();
	Camera[0]->setFarValue(20000.f);
	// Maya cameras reposition themselves relative to their target, so target the location
	// where the mesh scene node is placed.
	Camera[0]->setTarget(core::vector3df(0,30,0));

	Camera[1] = smgr->addCameraSceneNodeFPS();
	Camera[1]->setFarValue(20000.f);
	Camera[1]->setPosition(core::vector3df(0,0,-70));
	Camera[1]->setTarget(core::vector3df(0,30,0));

	setActiveCamera(Camera[0]);

	// load the irrlicht engine logo
	IGUIImage *img =
		env->addImage(driver->getTexture("irrlichtlogo2.png"),
			core::position2d<s32>(10, driver->getScreenSize().Height - 128));

	// lock the logo's edges to the bottom left corner of the screen
	img->setAlignment(EGUIA_UPPERLEFT, EGUIA_UPPERLEFT,
			EGUIA_LOWERRIGHT, EGUIA_LOWERRIGHT);

	// remember state so we notice when the window does lose the focus
	bool hasFocus = Device->isWindowFocused();

	// draw everything
	while(Device->run() && driver)
	{
		// Catch focus changes (workaround until Irrlicht has events for this)
		bool focused = Device->isWindowFocused();
		if ( hasFocus && !focused )
			onKillFocus();
		hasFocus = focused;

		if (Device->isWindowActive())
		{
			driver->beginScene(video::ECBF_COLOR | video::ECBF_DEPTH, video::SColor(150,50,50,50));

			smgr->drawAll();
			env->drawAll();

			driver->endScene();

			// update information about current frame-rate
			core::stringw str(L"FPS: ");
			str.append(core::stringw(driver->getFPS()));
			str += L" Tris: ";
			str.append(core::stringw(driver->getPrimitiveCountDrawn()));
			fpstext->setText(str.c_str());

			// update information about the active camera
			scene::ICameraSceneNode* cam = Device->getSceneManager()->getActiveCamera();
			str = L"Pos: ";
			str.append(core::stringw(cam->getPosition().X));
			str += L" ";
			str.append(core::stringw(cam->getPosition().Y));
			str += L" ";
			str.append(core::stringw(cam->getPosition().Z));
			str += L" Tgt: ";
			str.append(core::stringw(cam->getTarget().X));
			str += L" ";
			str.append(core::stringw(cam->getTarget().Y));
			str += L" ";
			str.append(core::stringw(cam->getTarget().Z));
			postext->setText(str.c_str());

			// update the tool dialog
			updateToolBox();
		}
		else
			Device->yield();
	}

	Device->drop();
	return 0;
}

/*
**/
