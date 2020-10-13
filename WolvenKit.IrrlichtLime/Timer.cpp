#include "stdafx.h"
#include "ReferenceCounted.h"
#include "Timer.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {

Timer::RealTimeDate::RealTimeDate(const ITimer::RealTimeDate& other)
	: Lime::NativeValue<ITimer::RealTimeDate>(true)
{
	m_NativeValue = new ITimer::RealTimeDate(other);
}

String^ Timer::RealTimeDate::ToString()
{
	return String::Format(
		"{0} {1:0000}-{2:00}-{3:00} {4:00}:{5:00}:{6:00}", // "Monday 2010-10-11 17:04:39"
		DayOfWeek, Year, Month, Day, Hour, Minute, Second);
}

Timer^ Timer::Wrap(irr::ITimer* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew Timer(ref);
}

Timer::Timer(irr::ITimer* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_Timer = ref;
}

void Timer::Start()
{
	m_Timer->start();
}

void Timer::Stop()
{
	m_Timer->stop();
}

void Timer::Tick()
{
	m_Timer->tick();
}

bool Timer::IsStopped::get()
{
	return m_Timer->isStopped();
}

unsigned int Timer::RealTime::get()
{
	return m_Timer->getRealTime();
}

Timer::RealTimeDate^ Timer::RealTimeAndDate::get()
{
	ITimer::RealTimeDate t = m_Timer->getRealTimeAndDate();
	return gcnew Timer::RealTimeDate(t);
}

float Timer::Speed::get()
{
	return m_Timer->getSpeed();
}

void Timer::Speed::set(float value)
{
	m_Timer->setSpeed(value);
}

unsigned int Timer::Time::get()
{
	return m_Timer->getTime();
}

void Timer::Time::set(unsigned int value)
{
	m_Timer->setTime(value);
}

String^ Timer::ToString()
{
	unsigned int t = Time;

	unsigned int millisecs = t % 1000; t /= 1000;
	unsigned int seconds = t % 60; t /= 60;
	unsigned int minutes = t % 60; t /= 60;
	unsigned int hours = t;

	return String::Format("Timer: {0}:{1:00}:{2:00}.{3:000}", hours, minutes, seconds, millisecs);
}

} // end namespace IrrlichtLime