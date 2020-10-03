#include "stdafx.h"
#include "ReferenceCounted.h"
#include "VideoModeList.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

VideoModeList^ VideoModeList::Wrap(video::IVideoModeList* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew VideoModeList(ref);
}

VideoModeList::VideoModeList(video::IVideoModeList* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_VideoModeList = ref;
}

Dimension2Di^ VideoModeList::GetResolution(Dimension2Di^ minSize, Dimension2Di^ maxSize)
{
	LIME_ASSERT(minSize != nullptr);
	LIME_ASSERT(minSize->Width >= 0);
	LIME_ASSERT(minSize->Height >= 0);
	LIME_ASSERT(maxSize != nullptr);
	LIME_ASSERT(maxSize->Width >= 0);
	LIME_ASSERT(maxSize->Height >= 0);

	return gcnew Dimension2Di(m_VideoModeList->getVideoModeResolution(
		(core::dimension2du&)*minSize->m_NativeValue,
		(core::dimension2du&)*maxSize->m_NativeValue));
}

VideoMode VideoModeList::Desktop::get()
{
	return VideoMode(
		(core::dimension2di&)m_VideoModeList->getDesktopResolution(),
		m_VideoModeList->getDesktopDepth());
}

List<VideoMode>^ VideoModeList::ModeList::get()
{
	List<VideoMode>^ l = gcnew List<VideoMode>();

	for (int i = 0; i < m_VideoModeList->getVideoModeCount(); i++)
	{
		core::dimension2di r = (core::dimension2di)m_VideoModeList->getVideoModeResolution(i);
		int d = m_VideoModeList->getVideoModeDepth(i);

		l->Add(VideoMode(r, d));
	}

	return l;
}

String^ VideoModeList::ToString()
{
	return String::Format("VideoModeList: Desktop={0}", Desktop);
}

} // end namespace Video
} // end namespace IrrlichtLime