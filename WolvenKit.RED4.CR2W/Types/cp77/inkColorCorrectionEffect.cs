using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkColorCorrectionEffect : inkIEffect
	{
		private CFloat _brightness;
		private CFloat _contrast;
		private CFloat _saturation;

		[Ordinal(2)] 
		[RED("brightness")] 
		public CFloat Brightness
		{
			get
			{
				if (_brightness == null)
				{
					_brightness = (CFloat) CR2WTypeManager.Create("Float", "brightness", cr2w, this);
				}
				return _brightness;
			}
			set
			{
				if (_brightness == value)
				{
					return;
				}
				_brightness = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("contrast")] 
		public CFloat Contrast
		{
			get
			{
				if (_contrast == null)
				{
					_contrast = (CFloat) CR2WTypeManager.Create("Float", "contrast", cr2w, this);
				}
				return _contrast;
			}
			set
			{
				if (_contrast == value)
				{
					return;
				}
				_contrast = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("saturation")] 
		public CFloat Saturation
		{
			get
			{
				if (_saturation == null)
				{
					_saturation = (CFloat) CR2WTypeManager.Create("Float", "saturation", cr2w, this);
				}
				return _saturation;
			}
			set
			{
				if (_saturation == value)
				{
					return;
				}
				_saturation = value;
				PropertySet(this);
			}
		}

		public inkColorCorrectionEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
