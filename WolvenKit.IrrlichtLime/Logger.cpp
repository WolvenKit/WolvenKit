#include "stdafx.h"
#include "Logger.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {

Logger^ Logger::Wrap(irr::ILogger* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew Logger(ref);
}

Logger::Logger(irr::ILogger* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_Logger = ref;
}

void Logger::Log(String^ text, String^ hint, IrrlichtLime::LogLevel level)
{
	m_Logger->log(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(hint),
		(irr::ELOG_LEVEL)level);
}

void Logger::Log(String^ text, IrrlichtLime::LogLevel level)
{
	m_Logger->log(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		(irr::ELOG_LEVEL)level);
}

void Logger::Log(String^ text)
{
	m_Logger->log(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text));
}

IrrlichtLime::LogLevel Logger::LogLevel::get()
{
	return (IrrlichtLime::LogLevel)m_Logger->getLogLevel();
}

void Logger::LogLevel::set(IrrlichtLime::LogLevel value)
{
	m_Logger->setLogLevel((irr::ELOG_LEVEL)value);
}

String^ Logger::ToString()
{
	return String::Format("Logger: LogLevel={0}", LogLevel);
}

} // end namespace IrrlichtLime