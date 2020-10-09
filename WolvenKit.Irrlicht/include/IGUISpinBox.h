// Copyright (C) 2006-2012 Michael Zeilfelder
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __I_GUI_SPIN_BOX_H_INCLUDED__
#define __I_GUI_SPIN_BOX_H_INCLUDED__

#include "IGUIElement.h"

namespace irr
{
namespace gui
{
	class IGUIEditBox;

	//! Enumeration bitflag for when to validate the text typed into the spinbox
	//! Default used by Irrlicht is: (EGUI_SBV_ENTER|EGUI_SBV_LOSE_FOCUS)
	enum EGUI_SPINBOX_VALIDATION
	{
		//! Does not validate typed text, probably a bad idea setting this usually.
		EGUI_SBV_NEVER  = 0,
		//! Validate on each change. Was default up to Irrlicht 1.8
		EGUI_SBV_CHANGE = 1,
		//! Validate when enter was pressed
		EGUI_SBV_ENTER = 2,
		//! Validate when the editbox loses the focus
		EGUI_SBV_LOSE_FOCUS = 4
	};


	//! Single line edit box + spin buttons
	/** \par This element can create the following events of type EGUI_EVENT_TYPE:
	\li EGET_SPINBOX_CHANGED
	*/
	class IGUISpinBox : public IGUIElement
	{
	public:

		//! constructor
		IGUISpinBox(IGUIEnvironment* environment, IGUIElement* parent,
					s32 id, core::rect<s32> rectangle)
			: IGUIElement(EGUIET_SPIN_BOX, environment, parent, id, rectangle) {}

		//! Access the edit box used in the spin control
		virtual IGUIEditBox* getEditBox() const = 0;

		//! set the current value of the spinbox
		/** \param val: value to be set in the spinbox */
		virtual void setValue(f32 val) = 0;

		//! Get the current value of the spinbox
		virtual f32 getValue() const = 0;

		//! set the range of values which can be used in the spinbox
		/** \param min: minimum value
		\param max: maximum value */
		virtual void setRange(f32 min, f32 max) = 0;

		//! get the minimum value which can be used in the spinbox
		virtual f32 getMin() const = 0;

		//! get the maximum value which can be used in the spinbox
		virtual f32 getMax() const = 0;

		//! Step size by which values are changed when pressing the spinbuttons
		/** The step size also determines the number of decimal places to display
		\param step: stepsize used for value changes when pressing spinbuttons */
		virtual void setStepSize(f32 step=1.f) = 0;

		//! Sets the number of decimal places to display.
		//! Note that this also rounds the range to the same number of decimal places.
		/** \param places: The number of decimal places to display, use -1 to reset */
		virtual void setDecimalPlaces(s32 places) = 0;

		//! get the current step size
		virtual f32 getStepSize() const = 0;

		//! Sets when the spinbox has to validate entered text.
		/** \param validateOn Can be any combination of EGUI_SPINBOX_VALIDATION bit flags */
		virtual void setValidateOn(u32 validateOn) = 0;

		//! Gets when the spinbox has to validate entered text.
		/** \return A combination of EGUI_SPINBOX_VALIDATION bit flags */
		virtual u32 getValidateOn() const = 0;
	};


} // end namespace gui
} // end namespace irr

#endif // __I_GUI_SPIN_BOX_H_INCLUDED__

