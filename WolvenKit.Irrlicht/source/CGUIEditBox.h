// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_GUI_EDIT_BOX_H_INCLUDED__
#define __C_GUI_EDIT_BOX_H_INCLUDED__

#include "IrrCompileConfig.h"
#ifdef _IRR_COMPILE_WITH_GUI_

#include "IGUIEditBox.h"
#include "irrArray.h"
#include "IOSOperator.h"

namespace irr
{
namespace gui
{
	class CGUIEditBox : public IGUIEditBox
	{
	public:

		//! constructor
		CGUIEditBox(const wchar_t* text, bool border, IGUIEnvironment* environment,
			IGUIElement* parent, s32 id, const core::rect<s32>& rectangle);

		//! destructor
		virtual ~CGUIEditBox();

		//! Sets another skin independent font.
		virtual void setOverrideFont(IGUIFont* font=0) _IRR_OVERRIDE_;

		//! Gets the override font (if any)
		/** \return The override font (may be 0) */
		virtual IGUIFont* getOverrideFont() const _IRR_OVERRIDE_;

		//! Get the font which is used right now for drawing
		/** Currently this is the override font when one is set and the
		font of the active skin otherwise */
		virtual IGUIFont* getActiveFont() const _IRR_OVERRIDE_;

		//! Sets another color for the text.
		virtual void setOverrideColor(video::SColor color) _IRR_OVERRIDE_;

		//! Gets the override color
		virtual video::SColor getOverrideColor() const _IRR_OVERRIDE_;

		//! Sets if the text should use the override color or the
		//! color in the gui skin.
		virtual void enableOverrideColor(bool enable) _IRR_OVERRIDE_;

		//! Checks if an override color is enabled
		/** \return true if the override color is enabled, false otherwise */
		virtual bool isOverrideColorEnabled(void) const _IRR_OVERRIDE_;

		//! Sets whether to draw the background
		virtual void setDrawBackground(bool draw) _IRR_OVERRIDE_;

		//! Checks if background drawing is enabled
		virtual bool isDrawBackgroundEnabled() const _IRR_OVERRIDE_;

		//! Turns the border on or off
		virtual void setDrawBorder(bool border) _IRR_OVERRIDE_;

		//! Checks if border drawing is enabled
		virtual bool isDrawBorderEnabled() const _IRR_OVERRIDE_;

		//! Enables or disables word wrap for using the edit box as multiline text editor.
		virtual void setWordWrap(bool enable) _IRR_OVERRIDE_;

		//! Checks if word wrap is enabled
		//! \return true if word wrap is enabled, false otherwise
		virtual bool isWordWrapEnabled() const _IRR_OVERRIDE_;

		//! Enables or disables newlines.
		/** \param enable: If set to true, the EGET_EDITBOX_ENTER event will not be fired,
		instead a newline character will be inserted. */
		virtual void setMultiLine(bool enable) _IRR_OVERRIDE_;

		//! Checks if multi line editing is enabled
		//! \return true if mult-line is enabled, false otherwise
		virtual bool isMultiLineEnabled() const _IRR_OVERRIDE_;

		//! Enables or disables automatic scrolling with cursor position
		//! \param enable: If set to true, the text will move around with the cursor position
		virtual void setAutoScroll(bool enable) _IRR_OVERRIDE_;

		//! Checks to see if automatic scrolling is enabled
		//! \return true if automatic scrolling is enabled, false if not
		virtual bool isAutoScrollEnabled() const _IRR_OVERRIDE_;

		//! Gets the size area of the text in the edit box
		//! \return Returns the size in pixels of the text
		virtual core::dimension2du getTextDimension() _IRR_OVERRIDE_;

		//! Sets text justification
		virtual void setTextAlignment(EGUI_ALIGNMENT horizontal, EGUI_ALIGNMENT vertical) _IRR_OVERRIDE_;

		//! called if an event happened.
		virtual bool OnEvent(const SEvent& event) _IRR_OVERRIDE_;

		//! draws the element and its children
		virtual void draw() _IRR_OVERRIDE_;

		//! Sets the new caption of this element.
		virtual void setText(const wchar_t* text) _IRR_OVERRIDE_;

		//! Sets the maximum amount of characters which may be entered in the box.
		//! \param max: Maximum amount of characters. If 0, the character amount is
		//! infinity.
		virtual void setMax(u32 max) _IRR_OVERRIDE_;

		//! Returns maximum amount of characters, previously set by setMax();
		virtual u32 getMax() const _IRR_OVERRIDE_;

		//! Set the character used for the cursor.
		/** By default it's "_" */
		virtual void setCursorChar(const wchar_t cursorChar) _IRR_OVERRIDE_;

		//! Get the character used for the cursor.
		virtual wchar_t getCursorChar() const _IRR_OVERRIDE_;

		//! Set the blinktime for the cursor. 2x blinktime is one full cycle.
		//** \param timeMs Blinktime in milliseconds. When set to 0 the cursor is constantly on without blinking */
		virtual void setCursorBlinkTime(irr::u32 timeMs) _IRR_OVERRIDE_;

		//! Get the cursor blinktime
		virtual irr::u32 getCursorBlinkTime() const _IRR_OVERRIDE_;

		//! Sets whether the edit box is a password box. Setting this to true will
		/** disable MultiLine, WordWrap and the ability to copy with ctrl+c or ctrl+x
		\param passwordBox: true to enable password, false to disable
		\param passwordChar: the character that is displayed instead of letters */
		virtual void setPasswordBox(bool passwordBox, wchar_t passwordChar = L'*') _IRR_OVERRIDE_;

		//! Returns true if the edit box is currently a password box.
		virtual bool isPasswordBox() const _IRR_OVERRIDE_;

		//! Updates the absolute position, splits text if required
		virtual void updateAbsolutePosition() _IRR_OVERRIDE_;

		//! Writes attributes of the element.
		virtual void serializeAttributes(io::IAttributes* out, io::SAttributeReadWriteOptions* options) const _IRR_OVERRIDE_;

		//! Reads attributes of the element
		virtual void deserializeAttributes(io::IAttributes* in, io::SAttributeReadWriteOptions* options) _IRR_OVERRIDE_;

	protected:
		//! Breaks the single text line.
		void breakText();
		//! sets the area of the given line
		void setTextRect(s32 line);
		//! returns the line number that the cursor is on
		s32 getLineFromPos(s32 pos);
		//! adds a letter to the edit box
		void inputChar(wchar_t c);
		//! calculates the current scroll position
		void calculateScrollPos();
		//! calculated the FrameRect
		void calculateFrameRect();
		//! send some gui event to parent
		void sendGuiEvent(EGUI_EVENT_TYPE type);
		//! set text markers
		void setTextMarkers(s32 begin, s32 end);
		//! delete current selection or next char
		bool keyDelete();

		bool processKey(const SEvent& event);
		bool processMouse(const SEvent& event);
		s32 getCursorPos(s32 x, s32 y);

		bool OverwriteMode;
		bool MouseMarking;
		bool Border;
		bool Background;
		bool OverrideColorEnabled;
		s32 MarkBegin;
		s32 MarkEnd;

		video::SColor OverrideColor;
		gui::IGUIFont *OverrideFont, *LastBreakFont;
		IOSOperator* Operator;

		u32 BlinkStartTime;
		irr::u32 CursorBlinkTime;
		core::stringw CursorChar; // IGUIFont::draw needs stringw instead of wchar_t
		s32 CursorPos;
		s32 HScrollPos, VScrollPos; // scroll position in characters
		u32 Max;

		bool WordWrap, MultiLine, AutoScroll, PasswordBox;
		wchar_t PasswordChar;
		EGUI_ALIGNMENT HAlign, VAlign;

		core::array< core::stringw > BrokenText;
		core::array< s32 > BrokenTextPositions;

		core::rect<s32> CurrentTextRect, FrameRect; // temporary values
	};


} // end namespace gui
} // end namespace irr

#endif // _IRR_COMPILE_WITH_GUI_
#endif // __C_GUI_EDIT_BOX_H_INCLUDED__

