// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h
// Written by Michael Zeilfelder

#ifndef __I_PROFILER_H_INCLUDED__
#define __I_PROFILER_H_INCLUDED__

#include "IrrCompileConfig.h"
#include "irrString.h"
#include "irrArray.h"
#include "ITimer.h"
#include <limits.h>	// for INT_MAX (we should have a S32_MAX...)

namespace irr
{

class ITimer;

//! Used to store the profile data (and also used for profile group data).
struct SProfileData
{
	friend class IProfiler;

    SProfileData()
	{
		GroupIndex = 0;
		reset();
	}

	bool operator<(const SProfileData& pd) const
	{
		return Id < pd.Id;
	}

	bool operator==(const SProfileData& pd) const
	{
		return Id == pd.Id;
	}

	u32 getGroupIndex() const
	{
		return GroupIndex;
	}

	const core::stringw& getName() const
	{
		return Name;
	}

	//! Each time profiling for this data is stopped it increases the counter by 1.
	u32 getCallsCounter() const
	{
		return CountCalls;
	}

	//! Longest time a profile call for this id took from start until it was stopped again.
	u32 getLongestTime() const
	{
		return LongestTime;
	}

	//! Time spend between start/stop
	u32 getTimeSum() const
	{
		return TimeSum;
	}

private:

	// just to be used for searching as it does no initialization besides id
	SProfileData(u32 id) : Id(id) {}

	void reset()
	{
		CountCalls = 0;
		LongestTime = 0;
		TimeSum = 0;
		LastTimeStarted = 0;
		StartStopCounter = 0;
	}

	s32 Id;
    u32 GroupIndex;
	core::stringw Name;

	s32 StartStopCounter; // 0 means stopped > 0 means it runs.
    u32 CountCalls;
    u32 LongestTime;
    u32 TimeSum;

    u32 LastTimeStarted;
};

//! Code-profiler. Please check the example in the Irrlicht examples folder about how to use it.
// Implementer notes:
// The design is all about allowing to use the central start/stop mechanism with minimal time overhead.
// This is why the class works without a virtual functions interface contrary to the usual Irrlicht design.
// And also why it works with id's instead of strings in the start/stop functions even if it makes using
// the class slightly harder.
// The class comes without reference-counting because the profiler instance is never released (TBD).
class IProfiler
{
public:
	//! Constructor. You could use this to create a new profiler, but usually getProfiler() is used to access the global instance.
    IProfiler()	: Timer(0), NextAutoId(INT_MAX)
	{}

	virtual ~IProfiler()
	{}

	//! Add an id with given name and group which can be used for profiling with start/stop
	/** After calling this once you can start/stop profiling for the given id.
	\param id: Should be >= 0 as negative id's are reserved for Irrlicht. Also very large numbers (near INT_MAX) might
	have been added automatically by the other add function.
	\param name: Name for displaying profile data.
	\param groupName: Each id belongs into a group - this helps on displaying profile data. */
    inline void add(s32 id, const core::stringw &name, const core::stringw &groupName);

	//! Add an automatically generated for the given name and group which can be used for profiling with start/stop.
	/** After calling this once you can start/stop profiling with the returned id.
	\param name: Name for displaying profile data.
	\param groupName: Each id belongs into a group - this helps on displaying profile data.
	\return Automatic id's start at INT_MAX and count down for each new id. If the name already has an id then that id will be returned. */
    inline s32 add(const core::stringw &name, const core::stringw &groupName);

	//! Return the number of profile data blocks. There is one for each id.
    u32 getProfileDataCount() const
    {
		return ProfileDatas.size();
    }

	//! Search for the index of the profile data by name
	/** \param result Receives the resulting data index when one was found.
	\param name String with name to search for
	\return true when found, false when not found */
	inline bool findDataIndex(u32 & result, const core::stringw &name) const;

	//! Get the profile data
	/** \param index A value between 0 and getProfileDataCount()-1.	Indices can change when new id's are added.*/
    const SProfileData& getProfileDataByIndex(u32 index) const
    {
		return ProfileDatas[index];
    }

	//! Get the profile data
	/** \param id Same value as used in ::add
	\return Profile data for the given id or 0 when it does not exist.	*/
    inline const SProfileData* getProfileDataById(u32 id);

	//! Get the number of profile groups. Will be at least 1.
	/** NOTE: The first groups is always L"overview" which is an overview for all existing groups */
    inline u32 getGroupCount() const
    {
		return ProfileGroups.size();
    }

    //! Get profile data for a group.
    /** NOTE: The first groups is always L"overview" which is an overview for all existing groups */
    inline const SProfileData& getGroupData(u32 index) const
    {
		return ProfileGroups[index];
    }

    //! Find the group index by the group-name
    /** \param result Receives the resulting group index when one was found.
	\param name String with name to search for
	\return true when found, false when not found */
	inline bool findGroupIndex(u32 & result, const core::stringw &name) const;


	//! Start profile-timing for the given id
	/** This increases an internal run-counter for the given id. It will profile as long as that counter is > 0.
	NOTE: you have to add the id first with one of the ::add functions
	*/
	inline void start(s32 id);

	//! Stop profile-timing for the given id
	/** This increases an internal run-counter for the given id. If it reaches 0 the time since start is recorded.
		You should have the same amount of start and stop calls. If stop is called more often than start
		then the additional stop calls will be ignored (counter never goes below 0)
	*/
    inline void stop(s32 id);

	//! Reset profile data for the given id
    inline void resetDataById(s32 id);

	//! Reset profile data for the given index
    inline void resetDataByIndex(u32 index);

    //! Reset profile data for a whole group
    inline void resetGroup(u32 index);

    //! Reset all profile data
    /** NOTE: This is not deleting id's or groups, just resetting all timers to 0. */
    inline void resetAll();

	//! Write all profile-data into a string
	/** \param result Receives the result string.
	\param includeOverview When true a group-overview is attached first
	\param suppressUncalled When true elements which got never called are not printed */
    virtual void printAll(core::stringw &result, bool includeOverview=false,bool suppressUncalled=true) const = 0;

	//! Write the profile data of one group into a string
	/** \param result Receives the result string.
	\param groupIndex_	*/
    virtual void printGroup(core::stringw &result, u32 groupIndex, bool suppressUncalled) const = 0;

protected:

    inline u32 addGroup(const core::stringw &name);

	// I would prefer using os::Timer, but os.h is not in the public interface so far.
	// Timer must be initialized by the implementation.
    ITimer * Timer;
	core::array<SProfileData> ProfileDatas;
    core::array<SProfileData> ProfileGroups;

private:
    s32 NextAutoId;	// for giving out id's automatically
};

//! Access the Irrlicht profiler object.
/** Profiler is always accessible, except in destruction of global objects.
If you want to get internal profiling information about the engine itself
you will have to re-compile the engine with _IRR_COMPILE_WITH_PROFILING_ enabled.
But you can use the profiler for profiling your own projects without that. */
IRRLICHT_API IProfiler& IRRCALLCONV getProfiler();

//! Class where the objects profile their own life-time.
/** This is a comfort wrapper around the IProfiler start/stop mechanism which is easier to use
when you want to profile a scope. You only have to create an object and it will profile it's own lifetime
for the given id. */
class CProfileScope
{
public:
	//! Construct with an known id.
	/** This is the fastest scope constructor, but the id must have been added before.
	\param id Any id which you did add to the profiler before. */
	CProfileScope(s32 id)
	: Id(id), Profiler(getProfiler())
	{
		Profiler.start(Id);
	}

	//! Object will create the given name, groupName combination for the id if it doesn't exist already
	/** \param id: Should be >= 0 as negative id's are reserved for Irrlicht. Also very large numbers (near INT_MAX) might
	have been created already by the automatic add function of ::IProfiler.
	\param name: Name for displaying profile data.
	\param groupName: Each id belongs into a group - this helps on displaying profile data. */
	CProfileScope(s32 id, const core::stringw &name, const core::stringw &groupName)
	: Id(id), Profiler(getProfiler())
	{
		Profiler.add(Id, name, groupName);
		Profiler.start(Id);
	}

	//! Object will create an id for the given name, groupName combination if they don't exist already
	/** Slowest scope constructor, but usually still fine unless speed is very critical.
	\param name: Name for displaying profile data.
	\param groupName: Each id belongs into a group - this helps on displaying profile data. */
	CProfileScope(const core::stringw &name, const core::stringw &groupName)
	: Profiler(getProfiler())
	{
		Id = Profiler.add(name, groupName);
		Profiler.start(Id);
	}

	~CProfileScope()
	{
		Profiler.stop(Id);
	}

protected:
	s32 Id;
	IProfiler& Profiler;
};


// IMPLEMENTATION for in-line stuff

void IProfiler::start(s32 id)
{
	s32 idx = ProfileDatas.binary_search(SProfileData(id));
	if ( idx >= 0 && Timer )
	{
		++ProfileDatas[idx].StartStopCounter;
		if (ProfileDatas[idx].StartStopCounter == 1 )
			ProfileDatas[idx].LastTimeStarted = Timer->getRealTime();
	}
}

void IProfiler::stop(s32 id)
{
	if ( Timer )
	{
		u32 timeNow = Timer->getRealTime();
		s32 idx = ProfileDatas.binary_search(SProfileData(id));
		if ( idx >= 0 )
		{
			SProfileData &data = ProfileDatas[idx];
			--ProfileDatas[idx].StartStopCounter;
			if ( data.LastTimeStarted != 0 && ProfileDatas[idx].StartStopCounter == 0)
			{
				// update data for this id
				++data.CountCalls;
				u32 diffTime = timeNow - data.LastTimeStarted;
				data.TimeSum += diffTime;
				if ( diffTime > data.LongestTime )
					data.LongestTime = diffTime;
				data.LastTimeStarted = 0;

				// update data of it's group
				SProfileData & group = ProfileGroups[data.GroupIndex];
				++group.CountCalls;
				group.TimeSum += diffTime;
				if ( diffTime > group.LongestTime )
					group.LongestTime = diffTime;
				group.LastTimeStarted = 0;
			}
			else if ( ProfileDatas[idx].StartStopCounter < 0 )
			{
				// ignore additional stop calls
				ProfileDatas[idx].StartStopCounter = 0;
			}
		}
	}
}

s32 IProfiler::add(const core::stringw &name, const core::stringw &groupName)
{
	u32 index;
	if ( findDataIndex(index, name) )
	{
		add( ProfileDatas[index].Id, name, groupName );
		return ProfileDatas[index].Id;
	}
	else
	{
		s32 id = NextAutoId;
		--NextAutoId;
		add( id, name, groupName );
		return id;
	}
}

void IProfiler::add(s32 id, const core::stringw &name, const core::stringw &groupName)
{
	u32 groupIdx;
	if ( !findGroupIndex(groupIdx, groupName) )
	{
		groupIdx = addGroup(groupName);
	}

	SProfileData data(id);
	s32 idx = ProfileDatas.binary_search(data);
	if ( idx < 0 )
	{
		data.reset();
		data.GroupIndex = groupIdx;
		data.Name = name;

		ProfileDatas.push_back(data);
		ProfileDatas.sort();
	}
	else
	{
		// only reset on group changes, otherwise we want to keep the data or coding CProfileScope would become tricky.
		if ( groupIdx != ProfileDatas[idx].GroupIndex )
		{
			resetDataByIndex((u32)idx);
			ProfileDatas[idx].GroupIndex = groupIdx;
		}
		ProfileDatas[idx].Name = name;
	}
}

u32 IProfiler::addGroup(const core::stringw &name)
{
    SProfileData group;
	group.Id = -1;	// Id for groups doesn't matter so far
	group.Name = name;
    ProfileGroups.push_back(group);
    return ProfileGroups.size()-1;
}

bool IProfiler::findDataIndex(u32 & result, const core::stringw &name) const
{
	for ( u32 i=0; i < ProfileDatas.size(); ++i )
	{
		if ( ProfileDatas[i].Name == name )
		{
			result = i;
			return true;
		}
	}

	return false;
}

const SProfileData* IProfiler::getProfileDataById(u32 id)
{
	SProfileData data(id);
    s32 idx = ProfileDatas.binary_search(data);
	if ( idx >= 0 )
		return &ProfileDatas[idx];
	return NULL;
}

bool IProfiler::findGroupIndex(u32 & result, const core::stringw &name) const
{
	for ( u32 i=0; i < ProfileGroups.size(); ++i )
	{
		if ( ProfileGroups[i].Name == name )
		{
			result = i;
			return true;
		}
	}

	return false;
}

void IProfiler::resetDataById(s32 id)
{
	s32 idx = ProfileDatas.binary_search(SProfileData(id));
    if ( idx >= 0 )
    {
		resetDataByIndex((u32)idx);
    }
}

void IProfiler::resetDataByIndex(u32 index)
{
	SProfileData &data = ProfileDatas[index];

	SProfileData & group = ProfileGroups[data.GroupIndex];
	group.CountCalls -= data.CountCalls;
	group.TimeSum -= data.TimeSum;

	data.reset();
}

//! Reset profile data for a whole group
void IProfiler::resetGroup(u32 index)
{
	for ( u32 i=0; i<ProfileDatas.size(); ++i )
    {
		if ( ProfileDatas[i].GroupIndex == index )
			ProfileDatas[i].reset();
    }
    if ( index < ProfileGroups.size() )
		ProfileGroups[index].reset();
}

void IProfiler::resetAll()
{
	for ( u32 i=0; i<ProfileDatas.size(); ++i )
    {
		ProfileDatas[i].reset();
    }

	for ( u32 i=0; i<ProfileGroups.size(); ++i )
    {
		ProfileGroups[i].reset();
    }
}

//! For internal engine use:
//! Code inside IRR_PROFILE is only executed when _IRR_COMPILE_WITH_PROFILING_ is set
//! This allows disabling all profiler code completely by changing that define.
//! It's generally useful to wrap profiler-calls in application code with a similar macro.
#ifdef _IRR_COMPILE_WITH_PROFILING_
	#define IRR_PROFILE(X) X
#else
	#define IRR_PROFILE(X)
#endif // IRR_PROFILE

} // namespace irr

#endif // __I_PROFILER_H_INCLUDED__
