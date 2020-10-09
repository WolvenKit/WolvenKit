// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h
// Written by Michael Zeilfelder

#include "CGUIProfiler.h"
#ifdef _IRR_COMPILE_WITH_GUI_

#include "IGUITable.h"
#include "IGUIScrollBar.h"
#include "IGUIEnvironment.h"
#include "CProfiler.h"

namespace irr
{
namespace gui
{

//! constructor
CGUIProfiler::CGUIProfiler(IGUIEnvironment* environment, IGUIElement* parent, s32 id, core::rect<s32> rectangle, IProfiler* profiler)
	: IGUIProfiler(environment, parent, id, rectangle, profiler)
	, Profiler(profiler)
	, DisplayTable(0), CurrentGroupIdx(0), CurrentGroupPage(0), NumGroupPages(1)
	, DrawBackground(false), Frozen(false), UnfreezeOnce(false), ShowGroupsTogether(false)
	, MinCalls(0), MinTimeSum(0), MinTimeAverage(0.f), MinTimeMax(0)
{
	if ( !Profiler )
		Profiler = &getProfiler();

	core::recti r(0, 0, rectangle.getWidth(), rectangle.getHeight());

	// Really just too lazy to code a complete new element for this.
    // If anyone can do this nicer he's welcome.
	DisplayTable = Environment->addTable(r, this, -1, DrawBackground);
	DisplayTable->setAlignment(EGUIA_UPPERLEFT, EGUIA_LOWERRIGHT, EGUIA_UPPERLEFT, EGUIA_LOWERRIGHT);
	DisplayTable->setSubElement(true);
	rebuildColumns();
}

void CGUIProfiler::fillRow(u32 rowIndex, const SProfileData& data, bool overviewTitle, bool groupTitle)
{
	DisplayTable->setCellText(rowIndex, 0, data.getName());

	if ( !overviewTitle )
		DisplayTable->setCellText(rowIndex, 1, core::stringw(data.getCallsCounter()));
	if ( data.getCallsCounter() > 0 )
	{
		DisplayTable->setCellText(rowIndex, 2, core::stringw(data.getTimeSum()));
		DisplayTable->setCellText(rowIndex, 3, core::stringw((u32)((f32)data.getTimeSum()/(f32)data.getCallsCounter())));
		DisplayTable->setCellText(rowIndex, 4, core::stringw(data.getLongestTime()));
	}

	if ( overviewTitle || groupTitle )
	{
		const video::SColor titleColor(255, 0, 0, 255);
		DisplayTable->setCellColor(rowIndex, 0, titleColor);
	}
}

void CGUIProfiler::rebuildColumns()
{
	if ( DisplayTable )
	{
		DisplayTable->clear();
		DisplayTable->addColumn(L"name           ");
		DisplayTable->addColumn(L"count calls");
		DisplayTable->addColumn(L"time(sum)");
		DisplayTable->addColumn(L"time(avg)");
		DisplayTable->addColumn(L"time(max)      ");
		DisplayTable->setActiveColumn(-1);
	}
}

u32 CGUIProfiler::addDataToTable(u32 rowIndex, u32 dataIndex, u32 groupIndex)
{
	const SProfileData& data = Profiler->getProfileDataByIndex(dataIndex);
	if ( data.getGroupIndex() == groupIndex
		&& data.getCallsCounter() >= MinCalls
		&& ( data.getCallsCounter() == 0 ||
			(data.getTimeSum() >= MinTimeSum &&
			 (f32)data.getTimeSum()/(f32)data.getCallsCounter() >= MinTimeAverage &&
			 data.getLongestTime() >= MinTimeMax))
		 )
	{
		rowIndex = DisplayTable->addRow(rowIndex);
		fillRow(rowIndex, data, false, false);
		++rowIndex;
	}
	return rowIndex;
}

void CGUIProfiler::updateDisplay()
{
	if ( DisplayTable )
	{
		DisplayTable->clearRows();

		if ( CurrentGroupIdx < Profiler->getGroupCount() )
		{
			bool overview = CurrentGroupIdx == 0;
			u32 rowIndex = 0;

			// show description row (overview or name of the following group)
			const SProfileData& groupData = Profiler->getGroupData(CurrentGroupIdx);
			if ( !ShowGroupsTogether && (overview || groupData.getCallsCounter() >= MinCalls) )
			{
				rowIndex = DisplayTable->addRow(rowIndex);
				fillRow(rowIndex, groupData, overview, true);
				++rowIndex;
			}

			// show overview over all groups?
			if ( overview )
			{
				for ( u32 i=1; i<Profiler->getGroupCount(); ++i )
				{
					const SProfileData& groupData = Profiler->getGroupData(i);
					if ( groupData.getCallsCounter() >= MinCalls )
					{
						rowIndex = DisplayTable->addRow(rowIndex);
						fillRow(rowIndex, groupData, false, false);
						++rowIndex;
					}
				}
			}
			// show data for all elements in current group
			else
			{
				for ( u32 i=0; i < Profiler->getProfileDataCount(); ++i )
				{
					rowIndex = addDataToTable(rowIndex, i, CurrentGroupIdx);
				}
			}
			// Show the rest of the groups
			if (ShowGroupsTogether)
			{
				for ( u32 groupIdx = CurrentGroupIdx+1; groupIdx < Profiler->getGroupCount(); ++groupIdx)
				{
					for ( u32 i=0; i < Profiler->getProfileDataCount(); ++i )
					{
						rowIndex = addDataToTable(rowIndex, i, groupIdx);
					}
				}
			}
		}

		// IGUITable has no page-wise scrolling yet. The following code can be replaced when we add that.
		// For now we use some CGUITable implementation info to figure this out.
		// (If you wonder why I didn't code page-scrolling directly in CGUITable ... because then it needs to be a
		// public interface and I don't have enough time currently to design & implement that well)
		s32 itemsTotalHeight = DisplayTable->getRowCount() * DisplayTable->getItemHeight();
		s32 tableHeight = DisplayTable->getAbsolutePosition().getHeight();
		s32 heightTitleRow = DisplayTable->getItemHeight()+1;
		if ( itemsTotalHeight+heightTitleRow < tableHeight )
		{
			NumGroupPages = 1;
		}
		else
		{
			s32 heightHScrollBar = DisplayTable->getHorizontalScrollBar() ? DisplayTable->getHorizontalScrollBar()->getAbsolutePosition().getHeight() : 0;
			s32 pageHeight = tableHeight - (heightTitleRow+heightHScrollBar);
			if ( pageHeight > 0 )
			{
				NumGroupPages = (itemsTotalHeight/pageHeight);
				if ( itemsTotalHeight % pageHeight )
					++NumGroupPages;
			}
			else // won't see anything, but that's up to the user
			{
				NumGroupPages = DisplayTable->getRowCount();
			}
			if ( NumGroupPages < 1 )
				NumGroupPages = 1;
		}
		if ( CurrentGroupPage < 0 )
			CurrentGroupPage = (s32)NumGroupPages-1;

		IGUIScrollBar* vScrollBar = DisplayTable->getVerticalScrollBar();
		if ( vScrollBar )
		{
			if ( NumGroupPages < 2 )
				vScrollBar->setPos(0);
			else
			{
				f32 factor = (f32)CurrentGroupPage/(f32)(NumGroupPages-1);
				vScrollBar->setPos( s32(factor * (f32)vScrollBar->getMax()) );
			}
		}
	}
}

void CGUIProfiler::draw()
{
	if ( isVisible() )
	{
		if (!Frozen || UnfreezeOnce)
		{
			UnfreezeOnce = false;
			updateDisplay();
		}
	}

	IGUIElement::draw();
}

void CGUIProfiler::nextPage(bool includeOverview)
{
	UnfreezeOnce = true;
	if ( CurrentGroupPage < NumGroupPages-1 )
		++CurrentGroupPage;
	else
	{
		CurrentGroupPage = 0;
		if ( ++CurrentGroupIdx >= Profiler->getGroupCount() )
		{
			if ( includeOverview )
				CurrentGroupIdx = 0;
			else
				CurrentGroupIdx = 1;	// can be invalid
		}
	}
}

void CGUIProfiler::previousPage(bool includeOverview)
{
	UnfreezeOnce = true;
	if ( CurrentGroupPage > 0 )
	{
		--CurrentGroupPage;
	}
	else
	{
		CurrentGroupPage = -1; // unknown because NumGroupPages has to be re-calculated first
		if ( CurrentGroupIdx > 0 )
			--CurrentGroupIdx;
		else
			CurrentGroupIdx = Profiler->getGroupCount()-1;
		if ( CurrentGroupIdx == 0 && !includeOverview )
		{
			if ( Profiler->getGroupCount() )
				CurrentGroupIdx = Profiler->getGroupCount()-1;
			if ( CurrentGroupIdx == 0 )
				CurrentGroupIdx = 1;	// invalid to avoid showing the overview
		}
	}
}

void CGUIProfiler::setShowGroupsTogether(bool groupsTogether)
{
	ShowGroupsTogether = groupsTogether;
}

bool CGUIProfiler::getShowGroupsTogether() const
{
	return ShowGroupsTogether;
}

void CGUIProfiler::firstPage(bool includeOverview)
{
	UnfreezeOnce = true;
	if ( includeOverview )
		CurrentGroupIdx = 0;
    else
		CurrentGroupIdx = 1; // can be invalid
	CurrentGroupPage = 0;
}

//! Sets another skin independent font.
void CGUIProfiler::setOverrideFont(IGUIFont* font)
{
	if ( DisplayTable )
	{
		DisplayTable->setOverrideFont(font);
		rebuildColumns();
	}
}

//! Gets the override font (if any)
IGUIFont * CGUIProfiler::getOverrideFont() const
{
	if ( DisplayTable )
		return DisplayTable->getOverrideFont();
	return 0;
}

//! Get the font which is used right now for drawing
IGUIFont* CGUIProfiler::getActiveFont() const
{
	if ( DisplayTable )
		return DisplayTable->getActiveFont();
	return 0;
}

//! Sets whether to draw the background. By default disabled,
void CGUIProfiler::setDrawBackground(bool draw)
{
	DrawBackground = draw;
	if ( DisplayTable )
		DisplayTable->setDrawBackground(draw);
}

//! Checks if background drawing is enabled
bool CGUIProfiler::isDrawBackgroundEnabled() const
{
	return DrawBackground;
}

//! Allows to freeze updates which makes it easier to read the numbers
void CGUIProfiler::setFrozen(bool freeze)
{
	Frozen = freeze;
}

//! Are updates currently frozen
bool CGUIProfiler::getFrozen() const
{
	return Frozen;
}

void CGUIProfiler::setFilters(irr::u32 minCalls, irr::u32 minTimeSum, irr::f32 minTimeAverage, irr::u32 minTimeMax)
{
	MinCalls = minCalls;
	MinTimeSum = minTimeSum;
	MinTimeAverage = minTimeAverage;
	MinTimeMax = minTimeMax;
}

} // end namespace gui
} // end namespace irr


#endif // _IRR_COMPILE_WITH_GUI_
