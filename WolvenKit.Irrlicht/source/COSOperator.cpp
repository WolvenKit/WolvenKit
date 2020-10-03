// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "COSOperator.h"

#ifdef _IRR_WINDOWS_API_
#ifndef _IRR_XBOX_PLATFORM_
#include <windows.h>
#endif
#else
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#ifdef _IRR_OSX_PLATFORM_
#include <sys/sysctl.h>
#endif
#endif

#if defined(_IRR_COMPILE_WITH_X11_DEVICE_)
#include "CIrrDeviceLinux.h"
#endif
#if defined(_IRR_COMPILE_WITH_OSX_DEVICE_)
#import <Cocoa/Cocoa.h>
#endif

#include "fast_atof.h"

namespace irr
{

#if defined(_IRR_COMPILE_WITH_X11_DEVICE_)
// constructor  linux
	COSOperator::COSOperator(const core::stringc& osVersion, CIrrDeviceLinux* device)
: OperatingSystem(osVersion), IrrDeviceLinux(device)
{
}
#endif

// constructor
COSOperator::COSOperator(const core::stringc& osVersion) : OperatingSystem(osVersion)
{
	#ifdef _DEBUG
	setDebugName("COSOperator");
	#endif
}


//! returns the current operating system version as string.
const core::stringc& COSOperator::getOperatingSystemVersion() const
{
	return OperatingSystem;
}


//! copies text to the clipboard
void COSOperator::copyToClipboard(const c8* text) const
{
	if (strlen(text)==0)
		return;

// Windows version
#if defined(_IRR_XBOX_PLATFORM_)
#elif defined(_IRR_WINDOWS_API_)
	if (!OpenClipboard(NULL) || text == 0)
		return;

	EmptyClipboard();

	HGLOBAL clipbuffer;
	char * buffer;

	clipbuffer = GlobalAlloc(GMEM_DDESHARE, strlen(text)+1);
	buffer = (char*)GlobalLock(clipbuffer);

	strcpy(buffer, text);

	GlobalUnlock(clipbuffer);
	SetClipboardData(CF_TEXT, clipbuffer);
	CloseClipboard();

#elif defined(_IRR_COMPILE_WITH_OSX_DEVICE_)
    NSString *str = nil;
    NSPasteboard *board = nil;

    if ((text != NULL) && (strlen(text) > 0))
    {
        str = [NSString stringWithCString:text encoding:NSWindowsCP1252StringEncoding];
        board = [NSPasteboard generalPasteboard];
        [board declareTypes:[NSArray arrayWithObject:NSStringPboardType] owner:NSApp];
        [board setString:str forType:NSStringPboardType];
    }

#elif defined(_IRR_COMPILE_WITH_X11_DEVICE_)
    if ( IrrDeviceLinux )
        IrrDeviceLinux->copyToClipboard(text);
#else

#endif
}


//! gets text from the clipboard
//! \return Returns 0 if no string is in there.
const c8* COSOperator::getTextFromClipboard() const
{
#if defined(_IRR_XBOX_PLATFORM_)
		return 0;
#elif defined(_IRR_WINDOWS_API_)
	if (!OpenClipboard(NULL))
		return 0;

	char * buffer = 0;

	HANDLE hData = GetClipboardData( CF_TEXT );
	buffer = (char*)GlobalLock( hData );
	GlobalUnlock( hData );
	CloseClipboard();
	return buffer;

#elif defined(_IRR_COMPILE_WITH_OSX_DEVICE_)
    NSString* str = nil;
    NSPasteboard* board = nil;
    char* result = 0;

    board = [NSPasteboard generalPasteboard];
    str = [board stringForType:NSStringPboardType];

    if (str != nil)
        result = (char*)[str cStringUsingEncoding:NSWindowsCP1252StringEncoding];

    return (result);

#elif defined(_IRR_COMPILE_WITH_X11_DEVICE_)
    if ( IrrDeviceLinux )
        return IrrDeviceLinux->getTextFromClipboard();
    return 0;

#else

	return 0;
#endif
}


bool COSOperator::getProcessorSpeedMHz(u32* MHz) const
{
	if (MHz)
		*MHz=0;
#if defined(_IRR_WINDOWS_API_) && !defined(_WIN32_WCE ) && !defined (_IRR_XBOX_PLATFORM_)
	LONG Error;

	HKEY Key;
	Error = RegOpenKeyEx(HKEY_LOCAL_MACHINE,
			__TEXT("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0"),
			0, KEY_READ, &Key);

	if(Error != ERROR_SUCCESS)
		return false;

	DWORD Speed = 0;
	DWORD Size = sizeof(Speed);
	Error = RegQueryValueEx(Key, __TEXT("~MHz"), NULL, NULL, (LPBYTE)&Speed, &Size);

	RegCloseKey(Key);

	if (Error != ERROR_SUCCESS)
		return false;
	else if (MHz)
		*MHz = Speed;
	return true;

#elif defined(_IRR_OSX_PLATFORM_)
	struct clockinfo CpuClock;
	size_t Size = sizeof(clockinfo);

	if (!sysctlbyname("kern.clockrate", &CpuClock, &Size, NULL, 0))
		return false;
	else if (MHz)
		*MHz = CpuClock.hz;
	return true;
#else
	// read from "/proc/cpuinfo"
	FILE* file = fopen("/proc/cpuinfo", "r");
	if (file)
	{
		char buffer[1024];
		fread(buffer, 1, 1024, file);
		buffer[1023]=0;
		core::stringc str(buffer);
		s32 pos = str.find("cpu MHz");
		if (pos != -1)
		{
			pos = str.findNext(':', pos);
			if (pos != -1)
			{
				while ( str[++pos] == ' ' );
				*MHz = core::fast_atof(str.c_str()+pos);
			}
		}
		fclose(file);
	}
	return (MHz && *MHz != 0);
#endif
}

bool COSOperator::getSystemMemory(u32* Total, u32* Avail) const
{
#if defined(_IRR_WINDOWS_API_) && !defined (_IRR_XBOX_PLATFORM_)

    #if (_WIN32_WINNT >= 0x0500)
	MEMORYSTATUSEX MemoryStatusEx;
 	MemoryStatusEx.dwLength = sizeof(MEMORYSTATUSEX);

	// cannot fail
	GlobalMemoryStatusEx(&MemoryStatusEx);

	if (Total)
		*Total = (u32)(MemoryStatusEx.ullTotalPhys>>10);
	if (Avail)
		*Avail = (u32)(MemoryStatusEx.ullAvailPhys>>10);
	return true;
	#else
	MEMORYSTATUS MemoryStatus;
	MemoryStatus.dwLength = sizeof(MEMORYSTATUS);

 	// cannot fail
	GlobalMemoryStatus(&MemoryStatus);

 	if (Total)
		*Total = (u32)(MemoryStatus.dwTotalPhys>>10);
 	if (Avail)
		*Avail = (u32)(MemoryStatus.dwAvailPhys>>10);
    return true;
	#endif

#elif defined(_IRR_POSIX_API_) && !defined(__FreeBSD__)
#if defined(_SC_PHYS_PAGES) && defined(_SC_AVPHYS_PAGES)
        long ps = sysconf(_SC_PAGESIZE);
        long pp = sysconf(_SC_PHYS_PAGES);
        long ap = sysconf(_SC_AVPHYS_PAGES);

	if ((ps==-1)||(pp==-1)||(ap==-1))
		return false;

	if (Total)
		*Total = (u32)((ps*(long long)pp)>>10);
	if (Avail)
		*Avail = (u32)((ps*(long long)ap)>>10);
	return true;
#else
	// TODO: implement for non-availability of symbols/features
	return false;
#endif
#elif defined(_IRR_OSX_PLATFORM_)
	int mib[2];
	int64_t physical_memory;
	size_t length;

	// Get the Physical memory size
	mib[0] = CTL_HW;
	mib[1] = HW_MEMSIZE;
	length = sizeof(int64_t);
	sysctl(mib, 2, &physical_memory, &length, NULL, 0);
	return true;
#else
	// TODO: implement for others
	return false;
#endif
}


} // end namespace

