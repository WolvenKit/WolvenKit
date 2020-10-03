// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_GUI_IMAGE_H_INCLUDED__
#define __C_GUI_IMAGE_H_INCLUDED__

#include "IrrCompileConfig.h"
#ifdef _IRR_COMPILE_WITH_GUI_

#include "IGUIImage.h"

namespace irr
{
namespace gui
{

	class CGUIImage : public IGUIImage
	{
	public:

		//! constructor
		CGUIImage(IGUIEnvironment* environment, IGUIElement* parent, s32 id, core::rect<s32> rectangle);

		//! destructor
		virtual ~CGUIImage();

		//! sets an image
		virtual void setImage(video::ITexture* image) _IRR_OVERRIDE_;

		//! Gets the image texture
		virtual video::ITexture* getImage() const _IRR_OVERRIDE_;

		//! sets the color of the image
		virtual void setColor(video::SColor color) _IRR_OVERRIDE_;

		//! sets if the image should scale to fit the element
		virtual void setScaleImage(bool scale) _IRR_OVERRIDE_;

		//! draws the element and its children
		virtual void draw() _IRR_OVERRIDE_;

		//! sets if the image should use its alpha channel to draw itself
		virtual void setUseAlphaChannel(bool use) _IRR_OVERRIDE_;

		//! Gets the color of the image
		virtual video::SColor getColor() const _IRR_OVERRIDE_;

		//! Returns true if the image is scaled to fit, false if not
		virtual bool isImageScaled() const _IRR_OVERRIDE_;

		//! Returns true if the image is using the alpha channel, false if not
		virtual bool isAlphaChannelUsed() const _IRR_OVERRIDE_;

		//! Sets the source rectangle of the image. By default the full image is used.
		virtual void setSourceRect(const core::rect<s32>& sourceRect) _IRR_OVERRIDE_;

		//! Returns the customized source rectangle of the image to be used.
		virtual core::rect<s32> getSourceRect() const _IRR_OVERRIDE_;

		//! Restrict drawing-area.
		virtual void setDrawBounds(const core::rect<f32>& drawBoundUVs) _IRR_OVERRIDE_;

		//! Get drawing-area restrictions.
		virtual core::rect<f32> getDrawBounds() const _IRR_OVERRIDE_;

		//! Sets whether to draw a background color (EGDC_3D_DARK_SHADOW) when no texture is set
		virtual void setDrawBackground(bool draw) _IRR_OVERRIDE_
		{
			DrawBackground = draw;
		}

		//! Checks if a background is drawn when no texture is set
		virtual bool isDrawBackgroundEnabled() const  _IRR_OVERRIDE_
		{
			return DrawBackground;
		}

		//! Writes attributes of the element.
		virtual void serializeAttributes(io::IAttributes* out, io::SAttributeReadWriteOptions* options) const _IRR_OVERRIDE_;

		//! Reads attributes of the element
		virtual void deserializeAttributes(io::IAttributes* in, io::SAttributeReadWriteOptions* options) _IRR_OVERRIDE_;

	protected:
		void checkBounds(core::rect<s32>& rect)
		{
			f32 clipWidth = (f32)rect.getWidth();
			f32 clipHeight = (f32)rect.getHeight();

			rect.UpperLeftCorner.X += core::round32(DrawBounds.UpperLeftCorner.X*clipWidth);
			rect.UpperLeftCorner.Y += core::round32(DrawBounds.UpperLeftCorner.Y*clipHeight);
			rect.LowerRightCorner.X -= core::round32((1.f-DrawBounds.LowerRightCorner.X)*clipWidth);
			rect.LowerRightCorner.Y -= core::round32((1.f-DrawBounds.LowerRightCorner.Y)*clipHeight);
		}

	private:
		video::ITexture* Texture;
		video::SColor Color;
		bool UseAlphaChannel;
		bool ScaleImage;
		core::rect<s32> SourceRect;
		core::rect<f32> DrawBounds;
		bool DrawBackground;
	};


} // end namespace gui
} // end namespace irr

#endif // _IRR_COMPILE_WITH_GUI_

#endif // __C_GUI_IMAGE_H_INCLUDED__
