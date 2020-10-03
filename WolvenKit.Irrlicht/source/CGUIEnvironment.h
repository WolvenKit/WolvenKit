// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_GUI_ENVIRONMENT_H_INCLUDED__
#define __C_GUI_ENVIRONMENT_H_INCLUDED__

#include "IrrCompileConfig.h"
#ifdef _IRR_COMPILE_WITH_GUI_

#include "IGUIEnvironment.h"
#include "IGUIElement.h"
#include "irrArray.h"
#include "IFileSystem.h"
#include "IOSOperator.h"

namespace irr
{

namespace gui
{

class CGUIEnvironment : public IGUIEnvironment, public IGUIElement
{
public:

	//! constructor
	CGUIEnvironment(io::IFileSystem* fs, video::IVideoDriver* driver, IOSOperator* op);

	//! destructor
	virtual ~CGUIEnvironment();

	//! draws all gui elements
	virtual void drawAll() _IRR_OVERRIDE_;

	//! returns the current video driver
	virtual video::IVideoDriver* getVideoDriver() const _IRR_OVERRIDE_;

	//! returns pointer to the filesystem
	virtual io::IFileSystem* getFileSystem() const _IRR_OVERRIDE_;

	//! returns a pointer to the OS operator
	virtual IOSOperator* getOSOperator() const _IRR_OVERRIDE_;

	//! posts an input event to the environment
	virtual bool postEventFromUser(const SEvent& event) _IRR_OVERRIDE_;

	//! This sets a new event receiver for gui events. Usually you do not have to
	//! use this method, it is used by the internal engine.
	virtual void setUserEventReceiver(IEventReceiver* evr) _IRR_OVERRIDE_;

	//! removes all elements from the environment
	virtual void clear() _IRR_OVERRIDE_;

	//! called if an event happened.
	virtual bool OnEvent(const SEvent& event) _IRR_OVERRIDE_;

	//! returns the current gui skin
	virtual IGUISkin* getSkin() const _IRR_OVERRIDE_;

	//! Sets a new GUI Skin
	virtual void setSkin(IGUISkin* skin) _IRR_OVERRIDE_;

	//! Creates a new GUI Skin based on a template.
	/** \return Returns a pointer to the created skin.
	If you no longer need the skin, you should call IGUISkin::drop().
	See IReferenceCounted::drop() for more information. */
	virtual IGUISkin* createSkin(EGUI_SKIN_TYPE type) _IRR_OVERRIDE_;

	//! Creates the image list from the given texture.
	virtual IGUIImageList* createImageList(video::ITexture* texture,
					core::dimension2d<s32> imageSize, bool useAlphaChannel) _IRR_OVERRIDE_;

	//! returns the font
	virtual IGUIFont* getFont(const io::path& filename) _IRR_OVERRIDE_;

	//! add an externally loaded font
	virtual IGUIFont* addFont(const io::path& name, IGUIFont* font) _IRR_OVERRIDE_;

	//! remove loaded font
	virtual void removeFont(IGUIFont* font) _IRR_OVERRIDE_;

	//! returns default font
	virtual IGUIFont* getBuiltInFont() const _IRR_OVERRIDE_;

	//! returns the sprite bank
	virtual IGUISpriteBank* getSpriteBank(const io::path& filename) _IRR_OVERRIDE_;

	//! returns the sprite bank
	virtual IGUISpriteBank* addEmptySpriteBank(const io::path& name) _IRR_OVERRIDE_;

	//! adds an button. The returned pointer must not be dropped.
	virtual IGUIButton* addButton(const core::rect<s32>& rectangle, IGUIElement* parent=0, s32 id=-1, const wchar_t* text=0,const wchar_t* tooltiptext = 0) _IRR_OVERRIDE_;

	//! adds a window. The returned pointer must not be dropped.
	virtual IGUIWindow* addWindow(const core::rect<s32>& rectangle, bool modal = false,
		const wchar_t* text=0, IGUIElement* parent=0, s32 id=-1) _IRR_OVERRIDE_;

	//! adds a modal screen. The returned pointer must not be dropped.
	virtual IGUIElement* addModalScreen(IGUIElement* parent) _IRR_OVERRIDE_;

	//! Adds a message box.
	virtual IGUIWindow* addMessageBox(const wchar_t* caption, const wchar_t* text=0,
		bool modal = true, s32 flag = EMBF_OK, IGUIElement* parent=0, s32 id=-1, video::ITexture* image=0) _IRR_OVERRIDE_;

	//! adds a scrollbar. The returned pointer must not be dropped.
	virtual IGUIScrollBar* addScrollBar(bool horizontal, const core::rect<s32>& rectangle,
		IGUIElement* parent=0, s32 id=-1) _IRR_OVERRIDE_;

	//! Adds an image element.
	virtual IGUIImage* addImage(video::ITexture* image, core::position2d<s32> pos,
		bool useAlphaChannel=true, IGUIElement* parent=0, s32 id=-1, const wchar_t* text=0) _IRR_OVERRIDE_;

	//! adds an image. The returned pointer must not be dropped.
	virtual IGUIImage* addImage(const core::rect<s32>& rectangle,
		IGUIElement* parent=0, s32 id=-1, const wchar_t* text=0, bool useAlphaChannel=true) _IRR_OVERRIDE_;

	//! adds a checkbox
	virtual IGUICheckBox* addCheckBox(bool checked, const core::rect<s32>& rectangle,
		IGUIElement* parent=0, s32 id=-1, const wchar_t* text=0) _IRR_OVERRIDE_;

	//! adds a list box
	virtual IGUIListBox* addListBox(const core::rect<s32>& rectangle,
		IGUIElement* parent=0, s32 id=-1, bool drawBackground=false) _IRR_OVERRIDE_;

	//! adds a tree view
	virtual IGUITreeView* addTreeView(const core::rect<s32>& rectangle,
		IGUIElement* parent=0, s32 id=-1, bool drawBackground=false,
		bool scrollBarVertical = true, bool scrollBarHorizontal = false) _IRR_OVERRIDE_;

	//! adds an mesh viewer. The returned pointer must not be dropped.
	virtual IGUIMeshViewer* addMeshViewer(const core::rect<s32>& rectangle,
		IGUIElement* parent=0, s32 id=-1, const wchar_t* text=0) _IRR_OVERRIDE_;

	//! Adds a file open dialog.
	virtual IGUIFileOpenDialog* addFileOpenDialog(const wchar_t* title = 0,
			bool modal=true, IGUIElement* parent=0, s32 id=-1,
			bool restoreCWD=false, io::path::char_type* startDir=0) _IRR_OVERRIDE_;

	//! Adds a color select dialog.
	virtual IGUIColorSelectDialog* addColorSelectDialog(const wchar_t* title = 0,
		bool modal=true, IGUIElement* parent=0, s32 id=-1) _IRR_OVERRIDE_;

	//! adds a static text. The returned pointer must not be dropped.
	virtual IGUIStaticText* addStaticText(const wchar_t* text, const core::rect<s32>& rectangle,
		bool border=false, bool wordWrap=true, IGUIElement* parent=0, s32 id=-1, bool drawBackground = false) _IRR_OVERRIDE_;

	//! Adds an edit box. The returned pointer must not be dropped.
	virtual IGUIEditBox* addEditBox(const wchar_t* text, const core::rect<s32>& rectangle,
		bool border=false, IGUIElement* parent=0, s32 id=-1) _IRR_OVERRIDE_;

	//! Adds a spin box to the environment
	virtual IGUISpinBox* addSpinBox(const wchar_t* text, const core::rect<s32>& rectangle,
		bool border=false,IGUIElement* parent=0, s32 id=-1) _IRR_OVERRIDE_;

	//! Adds a tab control to the environment.
	virtual IGUITabControl* addTabControl(const core::rect<s32>& rectangle,
		IGUIElement* parent=0, bool fillbackground=false, bool border=true, s32 id=-1) _IRR_OVERRIDE_;

	//! Adds tab to the environment.
	virtual IGUITab* addTab(const core::rect<s32>& rectangle,
		IGUIElement* parent=0, s32 id=-1) _IRR_OVERRIDE_;

	//! Adds a context menu to the environment.
	virtual IGUIContextMenu* addContextMenu(const core::rect<s32>& rectangle,
		IGUIElement* parent=0, s32 id=-1) _IRR_OVERRIDE_;

	//! Adds a menu to the environment.
	virtual IGUIContextMenu* addMenu(IGUIElement* parent=0, s32 id=-1) _IRR_OVERRIDE_;

	//! Adds a toolbar to the environment. It is like a menu is always placed on top
	//! in its parent, and contains buttons.
	virtual IGUIToolBar* addToolBar(IGUIElement* parent=0, s32 id=-1) _IRR_OVERRIDE_;

	//! Adds a combo box to the environment.
	virtual IGUIComboBox* addComboBox(const core::rect<s32>& rectangle,
		IGUIElement* parent=0, s32 id=-1) _IRR_OVERRIDE_;

	//! Adds a table element.
	virtual IGUITable* addTable(const core::rect<s32>& rectangle,
		IGUIElement* parent=0, s32 id=-1, bool drawBackground=false) _IRR_OVERRIDE_;

	//! Adds an element to display the information from the Irrlicht profiler
	virtual IGUIProfiler* addProfilerDisplay(const core::rect<s32>& rectangle,
		IGUIElement* parent=0, s32 id=-1) _IRR_OVERRIDE_;

	//! sets the focus to an element
	virtual bool setFocus(IGUIElement* element) _IRR_OVERRIDE_;

	//! removes the focus from an element
	virtual bool removeFocus(IGUIElement* element) _IRR_OVERRIDE_;

	//! Returns if the element has focus
	virtual bool hasFocus(const IGUIElement* element, bool checkSubElements=false) const _IRR_OVERRIDE_;

	//! Returns the element with the focus
	virtual IGUIElement* getFocus() const _IRR_OVERRIDE_;

	//! Returns the element last known to be under the mouse
	virtual IGUIElement* getHovered() const _IRR_OVERRIDE_;

	//! Adds an element for fading in or out.
	virtual IGUIInOutFader* addInOutFader(const core::rect<s32>* rectangle=0, IGUIElement* parent=0, s32 id=-1) _IRR_OVERRIDE_;

	//! Returns the root gui element.
	virtual IGUIElement* getRootGUIElement() _IRR_OVERRIDE_;

	virtual void OnPostRender( u32 time ) _IRR_OVERRIDE_;

	//! Returns the default element factory which can create all built in elements
	virtual IGUIElementFactory* getDefaultGUIElementFactory() const _IRR_OVERRIDE_;

	//! Adds an element factory to the gui environment.
	/** Use this to extend the gui environment with new element types which it should be
	able to create automatically, for example when loading data from xml files. */
	virtual void registerGUIElementFactory(IGUIElementFactory* factoryToAdd) _IRR_OVERRIDE_;

	//! Returns amount of registered scene node factories.
	virtual u32 getRegisteredGUIElementFactoryCount() const _IRR_OVERRIDE_;

	//! Returns a scene node factory by index
	virtual IGUIElementFactory* getGUIElementFactory(u32 index) const _IRR_OVERRIDE_;

	//! Adds a GUI Element by its name
	virtual IGUIElement* addGUIElement(const c8* elementName, IGUIElement* parent=0) _IRR_OVERRIDE_;

	//! Saves the current gui into a file.
	/** \param filename: Name of the file.
	\param start: The element to start saving from.
	if not specified, the root element will be used */
	virtual bool saveGUI( const io::path& filename, IGUIElement* start=0) _IRR_OVERRIDE_;

	//! Saves the current gui into a file.
	/** \param file: The file to save the GUI to.
	\param start: The element to start saving from.
	if not specified, the root element will be used */
	virtual bool saveGUI(io::IWriteFile* file, IGUIElement* start=0) _IRR_OVERRIDE_;

	//! Loads the gui. Note that the current gui is not cleared before.
	/** \param filename: Name of the file.
	\param parent: The parent of all loaded GUI elements,
	if not specified, the root element will be used */
	virtual bool loadGUI(const io::path& filename, IGUIElement* parent=0) _IRR_OVERRIDE_;

	//! Loads the gui. Note that the current gui is not cleared before.
	/** \param file: IReadFile to load the GUI from
	\param parent: The parent of all loaded GUI elements,
	if not specified, the root element will be used */
	virtual bool loadGUI(io::IReadFile* file, IGUIElement* parent=0) _IRR_OVERRIDE_;

	//! Writes attributes of the environment
	virtual void serializeAttributes(io::IAttributes* out, io::SAttributeReadWriteOptions* options=0) const _IRR_OVERRIDE_;

	//! Reads attributes of the environment.
	virtual void deserializeAttributes(io::IAttributes* in, io::SAttributeReadWriteOptions* options=0) _IRR_OVERRIDE_;

	//! writes an element
	virtual void writeGUIElement(io::IXMLWriter* writer, IGUIElement* node) _IRR_OVERRIDE_;

	//! reads an element
	virtual void readGUIElement(io::IXMLReader* reader, IGUIElement* node) _IRR_OVERRIDE_;

	//! Find the next element which would be selected when pressing the tab-key
	virtual IGUIElement* getNextElement(bool reverse=false, bool group=false) _IRR_OVERRIDE_;

	//! Set the way the gui will handle focus changes
	virtual void setFocusBehavior(u32 flags) _IRR_OVERRIDE_;

	//! Get the way the gui does handle focus changes
	virtual u32 getFocusBehavior() const _IRR_OVERRIDE_;

private:

	void updateHoveredElement(core::position2d<s32> mousePos);

	void loadBuiltInFont();

	struct SFont
	{
		io::SNamedPath NamedPath;
		IGUIFont* Font;

		bool operator < (const SFont& other) const
		{
			return (NamedPath < other.NamedPath);
		}
	};

	struct SSpriteBank
	{
		io::SNamedPath NamedPath;
		IGUISpriteBank* Bank;

		bool operator < (const SSpriteBank& other) const
		{
			return (NamedPath < other.NamedPath);
		}
	};

	struct SToolTip
	{
		IGUIStaticText* Element;
		u32 LastTime;
		u32 EnterTime;
		u32 LaunchTime;
		u32 RelaunchTime;
	};

	SToolTip ToolTip;

	core::array<IGUIElementFactory*> GUIElementFactoryList;

	core::array<SFont> Fonts;
	core::array<SSpriteBank> Banks;
	video::IVideoDriver* Driver;
	IGUIElement* Hovered;
	IGUIElement* HoveredNoSubelement;	// subelements replaced by their parent, so you only have 'real' elements here
	IGUIElement* Focus;
	core::position2d<s32> LastHoveredMousePos;
	IGUISkin* CurrentSkin;
	io::IFileSystem* FileSystem;
	IEventReceiver* UserReceiver;
	IOSOperator* Operator;
	u32 FocusFlags;
	static const io::path DefaultFontName;
};

} // end namespace gui
} // end namespace irr

#endif // _IRR_COMPILE_WITH_GUI_

#endif // __C_GUI_ENVIRONMENT_H_INCLUDED__


