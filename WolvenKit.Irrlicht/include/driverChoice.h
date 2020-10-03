// Copyright (C) 2009-2012 Christian Stehno
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __E_DRIVER_CHOICE_H_INCLUDED__
#define __E_DRIVER_CHOICE_H_INCLUDED__

#include <iostream>
#include <cstdio>
#include "EDriverTypes.h"
#include "IrrlichtDevice.h"

namespace irr
{
    
    //! ask user for driver
    static irr::video::E_DRIVER_TYPE driverChoiceConsole(bool allDrivers=false)
    {
#if defined (_IRR_IPHONE_PLATFORM_) || defined (_IRR_ANDROID_PLATFORM_)
        return irr::video::EDT_OGLES2;
#else
        printf("Please select the driver you want:\n");
        irr::u32 i=0;
        char c  = 'a';
        
        for (i=irr::video::EDT_COUNT; i>0; --i)
        {
            if ( allDrivers || irr::IrrlichtDevice::isDriverSupported(irr::video::E_DRIVER_TYPE(i-1)) )
            {
                printf(" (%c) %s\n", c, irr::video::DRIVER_TYPE_NAMES[i-1]);
				++c;
            }
        }

		char userSelection;
        std::cin >> userSelection;
        c = 'a';
        
        for (i=irr::video::EDT_COUNT; i>0; --i)
        {
			if ( allDrivers || irr::IrrlichtDevice::isDriverSupported(irr::video::E_DRIVER_TYPE(i-1)) )
			{
				if (userSelection == c)
					return irr::video::E_DRIVER_TYPE(i-1);
				++c;
			}
        }

        return irr::video::EDT_COUNT;
#endif
    }
    
} // end namespace irr

#endif
