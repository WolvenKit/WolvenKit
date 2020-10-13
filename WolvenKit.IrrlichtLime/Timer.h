#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {

public ref class Timer : ReferenceCounted
{
public:

	enum class WeekDay
	{
		Sunday = ITimer::EWD_SUNDAY,
		Monday = ITimer::EWD_MONDAY,
		Tuesday = ITimer::EWD_TUESDAY,
		Wednesday = ITimer::EWD_WEDNESDAY,
		Thursday = ITimer::EWD_THURSDAY,
		Friday = ITimer::EWD_FRIDAY,
		Saturday = ITimer::EWD_SATURDAY
	};

	ref class RealTimeDate : Lime::NativeValue<ITimer::RealTimeDate>
	{
	public:
		
		property int Hour { int get() { return m_NativeValue->Hour; } }
		property int Minute { int get() { return m_NativeValue->Minute; } }
		property int Second { int get() { return m_NativeValue->Second; } }

		property int Year { int get() { return m_NativeValue->Year; } }
		property int Month { int get() { return m_NativeValue->Month; } }
		property int Day { int get() { return m_NativeValue->Day; } }

		property WeekDay DayOfWeek { WeekDay get() { return (WeekDay)m_NativeValue->Weekday; } }
		property int DayOfYear { int get() { return m_NativeValue->Yearday; } }
		property bool IsDST { bool get() { return m_NativeValue->IsDST; } }

		virtual String^ ToString() override;

	internal:

		RealTimeDate(const ITimer::RealTimeDate& other);
	};

	void Start();
	void Stop();
	void Tick();

	property bool IsStopped { bool get(); }
	property unsigned int RealTime { unsigned int get(); }
	property RealTimeDate^ RealTimeAndDate { RealTimeDate^ get(); }
	property float Speed { float get(); void set(float value); }
	property unsigned int Time { unsigned int get(); void set(unsigned int value); }

	virtual String^ ToString() override;

internal:

	static Timer^ Wrap(irr::ITimer* ref);
	Timer(irr::ITimer* ref);

	irr::ITimer* m_Timer;
};

} // end namespace IrrlichtLime