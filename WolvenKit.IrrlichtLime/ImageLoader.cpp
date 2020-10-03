#include "stdafx.h"
#include "Image.h"
#include "ImageLoader.h"
#include "ReadFile.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

ImageLoader^ ImageLoader::Wrap(video::IImageLoader* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ImageLoader(ref);
}

ImageLoader::ImageLoader(video::IImageLoader* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ImageLoader = ref;
}

bool ImageLoader::IsLoadableFileExtension(String^ filename)
{
	LIME_ASSERT(filename != nullptr);
	return m_ImageLoader->isALoadableFileExtension(Lime::StringToPath(filename));
}

bool ImageLoader::IsLoadableFileFormat(IO::ReadFile^ file)
{
	LIME_ASSERT(file != nullptr);
	return m_ImageLoader->isALoadableFileFormat(LIME_SAFEREF(file, m_ReadFile));
}

Image^ ImageLoader::LoadImage(IO::ReadFile^ file)
{
	LIME_ASSERT(file != nullptr);

	video::IImage* i = m_ImageLoader->loadImage(LIME_SAFEREF(file, m_ReadFile));
	return Image::Wrap(i);
}

} // end namespace Video
} // end namespace IrrlichtLime