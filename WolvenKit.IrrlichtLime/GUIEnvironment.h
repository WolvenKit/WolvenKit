#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime { ref class Event; ref class OSOperator;
namespace IO { ref class Attributes; ref class FileSystem; ref class ReadFile; ref class WriteFile; }
namespace Video { ref class Texture; ref class VideoDriver; }
namespace GUI {

ref class GUIButton;
ref class GUICheckBox;
ref class GUIColorSelectDialog;
ref class GUIComboBox;
ref class GUIContextMenu;
ref class GUIEditBox;
ref class GUIElement;
ref class GUIFileOpenDialog;
ref class GUIFont;
ref class GUIImage;
ref class GUIImageList;
ref class GUIInOutFader;
ref class GUIListBox;
ref class GUIMeshViewer;
ref class GUIScrollBar;
ref class GUISkin;
ref class GUISpinBox;
ref class GUISpriteBank;
ref class GUIStaticText;
ref class GUITab;
ref class GUITabControl;
ref class GUITable;
ref class GUIToolBar;
ref class GUITreeView;
ref class GUIWindow;

public ref class GUIEnvironment : ReferenceCounted
{
public:

	GUIButton^ AddButton(Recti^ rectangle, GUIElement^ parent, int id, String^ text, String^ tooltiptext);
	GUIButton^ AddButton(Recti^ rectangle, GUIElement^ parent, int id, String^ text);
	GUIButton^ AddButton(Recti^ rectangle, GUIElement^ parent, int id);
	GUIButton^ AddButton(Recti^ rectangle, GUIElement^ parent);
	GUIButton^ AddButton(Recti^ rectangle);

	GUICheckBox^ AddCheckBox(bool checkedState, Recti^ rectangle, String^ text, GUIElement^ parent, int id);
	GUICheckBox^ AddCheckBox(bool checkedState, Recti^ rectangle, String^ text, GUIElement^ parent);
	GUICheckBox^ AddCheckBox(bool checkedState, Recti^ rectangle, String^ text);
	GUICheckBox^ AddCheckBox(bool checkedState, Recti^ rectangle);

	GUIColorSelectDialog^ AddColorSelectDialog(String^ title, bool modal, GUIElement^ parent, int id);
	GUIColorSelectDialog^ AddColorSelectDialog(String^ title, bool modal, GUIElement^ parent);
	GUIColorSelectDialog^ AddColorSelectDialog(String^ title, bool modal);
	GUIColorSelectDialog^ AddColorSelectDialog(String^ title);
	GUIColorSelectDialog^ AddColorSelectDialog();

	GUIComboBox^ AddComboBox(Recti^ rectangle, GUIElement^ parent, int id);
	GUIComboBox^ AddComboBox(Recti^ rectangle, GUIElement^ parent);
	GUIComboBox^ AddComboBox(Recti^ rectangle);

	GUIContextMenu^ AddContextMenu(Recti^ rectangle, GUIElement^ parent, int id);
	GUIContextMenu^ AddContextMenu(Recti^ rectangle, GUIElement^ parent);
	GUIContextMenu^ AddContextMenu(Recti^ rectangle);

	GUIEditBox^ AddEditBox(String^ text, Recti^ rectangle, bool border, GUIElement^ parent, int id);
	GUIEditBox^ AddEditBox(String^ text, Recti^ rectangle, bool border, GUIElement^ parent);
	GUIEditBox^ AddEditBox(String^ text, Recti^ rectangle, bool border);
	GUIEditBox^ AddEditBox(String^ text, Recti^ rectangle);

	GUISpriteBank^ AddEmptySpriteBank(String^ name);

	GUIFileOpenDialog^ AddFileOpenDialog(String^ title, bool modal, GUIElement^ parent, int id, bool restoreCurrentWorkingDir, String^ startDir);
	GUIFileOpenDialog^ AddFileOpenDialog(String^ title, bool modal, GUIElement^ parent, int id, bool restoreCurrentWorkingDir);
	GUIFileOpenDialog^ AddFileOpenDialog(String^ title, bool modal, GUIElement^ parent, int id);
	GUIFileOpenDialog^ AddFileOpenDialog(String^ title, bool modal, GUIElement^ parent);
	GUIFileOpenDialog^ AddFileOpenDialog(String^ title, bool modal);
	GUIFileOpenDialog^ AddFileOpenDialog(String^ title);
	GUIFileOpenDialog^ AddFileOpenDialog();

	GUIFont^ AddFont(String^ name, GUIFont^ font);

	GUIElement^ AddGUIElement(String^ elementName, GUIElement^ parent);
	GUIElement^ AddGUIElement(String^ elementName);

	GUIImage^ AddImage(Recti^ rectangle, bool useAlphaChannel, GUIElement^ parent, int id, String^ text);
	GUIImage^ AddImage(Recti^ rectangle, bool useAlphaChannel, GUIElement^ parent, int id);
	GUIImage^ AddImage(Recti^ rectangle, bool useAlphaChannel, GUIElement^ parent);
	GUIImage^ AddImage(Recti^ rectangle, bool useAlphaChannel);
	GUIImage^ AddImage(Recti^ rectangle);
	GUIImage^ AddImage(Video::Texture^ image, Vector2Di^ pos, bool useAlphaChannel, GUIElement^ parent, int id, String^ text);
	GUIImage^ AddImage(Video::Texture^ image, Vector2Di^ pos, bool useAlphaChannel, GUIElement^ parent, int id);
	GUIImage^ AddImage(Video::Texture^ image, Vector2Di^ pos, bool useAlphaChannel, GUIElement^ parent);
	GUIImage^ AddImage(Video::Texture^ image, Vector2Di^ pos, bool useAlphaChannel);
	GUIImage^ AddImage(Video::Texture^ image, Vector2Di^ pos);

	GUIInOutFader^ AddInOutFader(Recti^ rectangle, GUIElement^ parent, int id);
	GUIInOutFader^ AddInOutFader(Recti^ rectangle, GUIElement^ parent);
	GUIInOutFader^ AddInOutFader(Recti^ rectangle);
	GUIInOutFader^ AddInOutFader();

	GUIListBox^ AddListBox(Recti^ rectangle, GUIElement^ parent, int id, bool drawBackground);
	GUIListBox^ AddListBox(Recti^ rectangle, GUIElement^ parent, int id);
	GUIListBox^ AddListBox(Recti^ rectangle, GUIElement^ parent);
	GUIListBox^ AddListBox(Recti^ rectangle);

	GUIContextMenu^ AddMenu(GUIElement^ parent, int id);
	GUIContextMenu^ AddMenu(GUIElement^ parent);
	GUIContextMenu^ AddMenu();

	GUIMeshViewer^ AddMeshViewer(Recti^ rectangle, GUIElement^ parent, int id, String^ text);
	GUIMeshViewer^ AddMeshViewer(Recti^ rectangle, GUIElement^ parent, int id);
	GUIMeshViewer^ AddMeshViewer(Recti^ rectangle, GUIElement^ parent);
	GUIMeshViewer^ AddMeshViewer(Recti^ rectangle);

	GUIWindow^ AddMessageBox(String^ caption, String^ text, bool modal, GUIMessageBoxFlag flags, GUIElement^ parent, int id, Video::Texture^ image);
	GUIWindow^ AddMessageBox(String^ caption, String^ text, bool modal, GUIMessageBoxFlag flags, GUIElement^ parent, int id);
	GUIWindow^ AddMessageBox(String^ caption, String^ text, bool modal, GUIMessageBoxFlag flags, GUIElement^ parent);
	GUIWindow^ AddMessageBox(String^ caption, String^ text, bool modal, GUIMessageBoxFlag flags);
	GUIWindow^ AddMessageBox(String^ caption, String^ text, bool modal);
	GUIWindow^ AddMessageBox(String^ caption, String^ text);

	GUIElement^ AddModalScreen(GUIElement^ parent);

	GUIScrollBar^ AddScrollBar(bool horizontal, Recti^ rectangle, GUIElement^ parent, int id);
	GUIScrollBar^ AddScrollBar(bool horizontal, Recti^ rectangle, GUIElement^ parent);
	GUIScrollBar^ AddScrollBar(bool horizontal, Recti^ rectangle);

	GUISpinBox^ AddSpinBox(String^ text, Recti^ rectangle, bool border, GUIElement^ parent, int id);
	GUISpinBox^ AddSpinBox(String^ text, Recti^ rectangle, bool border, GUIElement^ parent);
	GUISpinBox^ AddSpinBox(String^ text, Recti^ rectangle, bool border);
	GUISpinBox^ AddSpinBox(String^ text, Recti^ rectangle);

	GUIStaticText^ AddStaticText(String^ text, Recti^ rectangle, bool border, bool wordWrap, GUIElement^ parent, int id, bool fillBackground);
	GUIStaticText^ AddStaticText(String^ text, Recti^ rectangle, bool border, bool wordWrap, GUIElement^ parent, int id);
	GUIStaticText^ AddStaticText(String^ text, Recti^ rectangle, bool border, bool wordWrap, GUIElement^ parent);
	GUIStaticText^ AddStaticText(String^ text, Recti^ rectangle, bool border, bool wordWrap);
	GUIStaticText^ AddStaticText(String^ text, Recti^ rectangle, bool border);
	GUIStaticText^ AddStaticText(String^ text, Recti^ rectangle);

	GUITab^ AddTab(Recti^ rectangle, GUIElement^ parent, int id);
	GUITab^ AddTab(Recti^ rectangle, GUIElement^ parent);
	GUITab^ AddTab(Recti^ rectangle);

	GUITabControl^ AddTabControl(Recti^ rectangle, GUIElement^ parent, int id, bool fillBackground, bool border);
	GUITabControl^ AddTabControl(Recti^ rectangle, GUIElement^ parent, int id, bool fillBackground);
	GUITabControl^ AddTabControl(Recti^ rectangle, GUIElement^ parent, int id);
	GUITabControl^ AddTabControl(Recti^ rectangle, GUIElement^ parent);
	GUITabControl^ AddTabControl(Recti^ rectangle);

	GUITable^ AddTable(Recti^ rectangle, GUIElement^ parent, int id, bool drawBackground);
	GUITable^ AddTable(Recti^ rectangle, GUIElement^ parent, int id);
	GUITable^ AddTable(Recti^ rectangle, GUIElement^ parent);
	GUITable^ AddTable(Recti^ rectangle);

	GUIToolBar^ AddToolBar(GUIElement^ parent, int id);
	GUIToolBar^ AddToolBar(GUIElement^ parent);
	GUIToolBar^ AddToolBar();

	GUITreeView^ AddTreeView(Recti^ rectangle, GUIElement^ parent, int id, bool drawBackground, bool scrollBarVertical, bool scrollBarHorizontal);
	GUITreeView^ AddTreeView(Recti^ rectangle, GUIElement^ parent, int id, bool drawBackground);
	GUITreeView^ AddTreeView(Recti^ rectangle, GUIElement^ parent, int id);
	GUITreeView^ AddTreeView(Recti^ rectangle, GUIElement^ parent);
	GUITreeView^ AddTreeView(Recti^ rectangle);

	GUIWindow^ AddWindow(Recti^ rectangle, bool modal, String^ text, GUIElement^ parent, int id);
	GUIWindow^ AddWindow(Recti^ rectangle, bool modal, String^ text, GUIElement^ parent);
	GUIWindow^ AddWindow(Recti^ rectangle, bool modal, String^ text);
	GUIWindow^ AddWindow(Recti^ rectangle, bool modal);
	GUIWindow^ AddWindow(Recti^ rectangle);

	void Clear();

	GUIImageList^ CreateImageList(Video::Texture^ texture, Dimension2Di^ imageSize, bool useAlphaChannel);

	GUISkin^ CreateSkin(GUISkinType type);

	void DeserializeAttributes(IO::Attributes^ deserializeFrom, IO::AttributeReadWriteOptions^ options);
	void DeserializeAttributes(IO::Attributes^ deserializeFrom);

	void DrawAll();

	bool Focused(GUIElement^ element, bool checkSubElements);
	bool Focused(GUIElement^ element);

	GUIFont^ GetFont(String^ filename);

	GUISpriteBank^ GetSpriteBank(String^ filename);

	bool LoadGUI(String^ filename, GUIElement^ start);
	bool LoadGUI(String^ filename);
	bool LoadGUI(IO::ReadFile^ file, GUIElement^ start);
	bool LoadGUI(IO::ReadFile^ file);

	bool PostEvent(Event^ e);

	bool RemoveFocus(GUIElement^ element);

	void RemoveFont(GUIFont^ font);

	bool SaveGUI(String^ filename, GUIElement^ start);
	bool SaveGUI(String^ filename);
	bool SaveGUI(IO::WriteFile^ file, GUIElement^ start);
	bool SaveGUI(IO::WriteFile^ file);

	void SerializeAttributes(IO::Attributes^ serializeTo, IO::AttributeReadWriteOptions^ options);
	void SerializeAttributes(IO::Attributes^ serializeTo);

	property GUIFont^ BuiltInFont { GUIFont^ get(); }
	property IrrlichtLime::IO::FileSystem^ FileSystem { IrrlichtLime::IO::FileSystem^ get(); }
	property GUIElement^ Focus { GUIElement^ get(); void set(GUIElement^ value); }
	property GUIElement^ HoveredElement { GUIElement^ get(); }
	property IrrlichtLime::OSOperator^ OSOperator { IrrlichtLime::OSOperator^ get(); }
	property GUIElement^ RootElement { GUIElement^ get(); }
	property GUISkin^ Skin { GUISkin^ get(); void set(GUISkin^ value); }
	property Video::VideoDriver^ VideoDriver { Video::VideoDriver^ get(); }

internal:

	static GUIEnvironment^ Wrap(gui::IGUIEnvironment* ref);
	GUIEnvironment(gui::IGUIEnvironment* ref);

	gui::IGUIEnvironment* m_GUIEnvironment;
};

} // end namespace GUI
} // end namespace IrrlichtLime