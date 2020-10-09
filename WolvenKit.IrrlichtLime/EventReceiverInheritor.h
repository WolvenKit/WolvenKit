#pragma once

#include <vcclr.h> // for gcroot
#include "stdafx.h"
#include "Event.h"
#include "IrrlichtDevice.h"

namespace IrrlichtLime {

class EventReceiverInheritor : public IEventReceiver
{
public:
	gcroot<IrrlichtDevice::EventHandler^> m_EventHandler;
	virtual bool OnEvent(const SEvent& e)
	{
		return m_EventHandler->Invoke(gcnew Event(e));
	}
};

} // end namespace IrrlichtLime