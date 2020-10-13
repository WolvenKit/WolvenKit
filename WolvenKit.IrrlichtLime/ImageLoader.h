#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO { ref class ReadFile; }
namespace Video {

ref class Image;

public ref class ImageLoader : ReferenceCounted
{
public:

	bool IsLoadableFileExtension(String^ filename);
	bool IsLoadableFileFormat(IO::ReadFile^ file);
	Image^ LoadImage(IO::ReadFile^ file);

internal:

	static ImageLoader^ Wrap(video::IImageLoader* ref);
	ImageLoader(video::IImageLoader* ref);

	video::IImageLoader* m_ImageLoader;
};

} // end namespace Video
} // end namespace IrrlichtLime