// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_GUI_WINDOW_H_INCLUDED__
#define __C_GUI_WINDOW_H_INCLUDED__

#include "IrrCompileConfig.h"
#ifdef _IRR_COMPILE_WITH_GUI_

#include "IGUIWindow.h"

namespace irr
{
namespace gui
{
	class IGUIButton;

	class CGUIWindow : public IGUIWindow
	{
	public:

		//! constructor
		CGUIWindow(IGUIEnvironment* environment, IGUIElement* parent, s32 id, core::rect<s32> rectangle);

		//! destructor
		~CGUIWindow();

		//! called if an event happened.
		bool OnEvent(const SEvent& event) _IRR_OVERRIDE_;

		//! update absolute position
		void updateAbsolutePosition() _IRR_OVERRIDE_;

		//! draws the element and its children
		void draw() _IRR_OVERRIDE_;

		//! Returns pointer to the close button
		IGUIButton* getCloseButton() const _IRR_OVERRIDE_;

		//! Returns pointer to the minimize button
		IGUIButton* getMinimizeButton() const _IRR_OVERRIDE_;

		//! Returns pointer to the maximize button
		IGUIButton* getMaximizeButton() const _IRR_OVERRIDE_;

		//! Returns true if the window is draggable, false if not
		bool isDraggable() const _IRR_OVERRIDE_;

		//! Sets whether the window is draggable
		void setDraggable(bool draggable) _IRR_OVERRIDE_;

		//! Set if the window background will be drawn
		void setDrawBackground(bool draw) _IRR_OVERRIDE_;

		//! Get if the window background will be drawn
		bool getDrawBackground() const _IRR_OVERRIDE_;

		//! Set if the window titlebar will be drawn
		//! Note: If the background is not drawn, then the titlebar is automatically also not drawn
		void setDrawTitlebar(bool draw) _IRR_OVERRIDE_;

		//! Get if the window titlebar will be drawn
		bool getDrawTitlebar() const _IRR_OVERRIDE_;

		//! Returns the rectangle of the drawable area (without border and without titlebar)
		core::rect<s32> getClientRect() const _IRR_OVERRIDE_;

		//! Writes attributes of the element.
		void serializeAttributes(io::IAttributes* out, io::SAttributeReadWriteOptions* options) const _IRR_OVERRIDE_;

		//! Reads attributes of the element
		void deserializeAttributes(io::IAttributes* in, io::SAttributeReadWriteOptions* options) _IRR_OVERRIDE_;

	protected:

		void updateClientRect();
		void refreshSprites();

		IGUIButton* CloseButton;
		IGUIButton* MinButton;
		IGUIButton* RestoreButton;
		core::rect<s32> ClientRect;
		video::SColor CurrentIconColor;

		core::position2d<s32> DragStart;
		bool Dragging, IsDraggable;
		bool DrawBackground;
		bool DrawTitlebar;
		bool IsActive;
	};

} // end namespace gui
} // end namespace irr

#endif // _IRR_COMPILE_WITH_GUI_

#endif

