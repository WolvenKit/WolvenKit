// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h
// Written by Michael Zeilfelder

#ifndef I_GUI_PROFILER_H_INCLUDED__
#define I_GUI_PROFILER_H_INCLUDED__

#include "IGUIElement.h"

namespace irr
{
class IProfiler;

namespace gui
{
	class IGUIFont;

	//! Element to display profiler information
	class IGUIProfiler : public IGUIElement
	{
	public:
		//! constructor
		/** \param profiler You can pass a custom profiler, but typically you can pass 0 in which cases it takes the global profiler from Irrlicht */
		IGUIProfiler(IGUIEnvironment* environment, IGUIElement* parent, s32 id, core::rect<s32> rectangle, IProfiler* profiler = NULL)
			: IGUIElement(EGUIET_PROFILER, environment, parent, id, rectangle)
		{}

		//! Show first page of profile data
		/** \param includeOverview When true show the group-overview page, when false show the profile data of the first group */
		virtual void firstPage(bool includeOverview=true) = 0;

		//! Show next page of profile data
		/** \param includeOverview Include the group-overview page  */
		virtual void nextPage(bool includeOverview=true) = 0;

		//! Show previous page of profile data
		/** \param includeOverview Include the group-overview page  */
		virtual void previousPage(bool includeOverview=true) = 0;

		//! Try to show as many group-pages together as possible instead of showing at most one group per page.
		/** \param groupsTogether When true show several groups on one page, when false show max. one group per page. Default is false. */
		virtual void setShowGroupsTogether(bool groupsTogether) = 0;

		//! Can several groups be displayed per page?
		virtual bool getShowGroupsTogether() const = 0;

		//! Sets another skin independent font.
		/** If this is set to zero, the button uses the font of the skin.
		\param font: New font to set. */
		virtual void setOverrideFont(IGUIFont* font=0) = 0;

		//! Gets the override font (if any)
		/** \return The override font (may be 0) */
		virtual IGUIFont* getOverrideFont(void) const = 0;

		//! Get the font which is used right now for drawing
		/** Currently this is the override font when one is set and the
		font of the active skin otherwise */
		virtual IGUIFont* getActiveFont() const = 0;

		//! Sets whether to draw the background. By default disabled,
		virtual void setDrawBackground(bool draw) = 0;

		//! Checks if background drawing is enabled
		/** \return true if background drawing is enabled, false otherwise */
		virtual bool isDrawBackgroundEnabled() const = 0;

		//! Allows to freeze updates which makes it easier to read the numbers
		/** Numbers are updated once when you switch pages. */
		virtual void setFrozen(bool freeze) = 0;

		//! Are updates currently frozen
		virtual bool getFrozen() const = 0;

		//! Filters prevents data that doesn't achieve the conditions from being displayed
		virtual void setFilters(irr::u32 minCalls = 0, irr::u32 minTimeSum = 0, irr::f32 minTimeAverage = 0.f, irr::u32 minTimeMax = 0) = 0;
	};

} // end namespace gui
} // end namespace irr

#endif
