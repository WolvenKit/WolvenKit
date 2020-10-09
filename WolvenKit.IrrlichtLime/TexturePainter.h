#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

ref class Texture;

public ref class TexturePainter
{
public:

	Color^ GetPixel(int x, int y);
	
	bool Lock(TextureLockMode lockMode, int mipmapLevel);
	bool Lock(TextureLockMode lockMode);
	bool Lock();

	void SetLine(int x1, int y1, int x2, int y2, Color^ color);
	void SetPixel(int x, int y, Color^ color);

	void Unlock(bool alsoRegenerateMipMapLevels);
	void Unlock();

	property bool Locked { bool get(); }
	property TextureLockMode LockMode { TextureLockMode get(); }
	property int MipMapLevel { int get(); }
	property int MipMapLevelCount { int get(); }
	property int MipMapLevelHeight { int get(); }
	property System::IntPtr MipMapLevelData { System::IntPtr get(); }
	property int MipMapLevelWidth { int get(); }
	property Video::Texture^ Texture { Video::Texture^ get(); }

	virtual String^ ToString() override;

internal:

	TexturePainter(Video::Texture^ texture);

private:

	Video::Texture^ m_texture;
	TextureLockMode m_lockMode;
	void* m_pointer;
	video::ECOLOR_FORMAT m_format;
	int m_rowSize;
	int m_pixelSize;
	int m_mipmapLevel;
	int m_mipmapLevelCount;
	int m_mipmapLevelWidth;
	int m_mipmapLevelHeight;
};

} // end namespace Video
} // end namespace IrrlichtLime