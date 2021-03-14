using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkBoxBlurEffect : inkIEffect
	{
		private CUInt8 _samples;
		private CFloat _intensity;
		private CEnum<inkEBlurDimension> _blurDimension;

		[Ordinal(2)] 
		[RED("samples")] 
		public CUInt8 Samples
		{
			get
			{
				if (_samples == null)
				{
					_samples = (CUInt8) CR2WTypeManager.Create("Uint8", "samples", cr2w, this);
				}
				return _samples;
			}
			set
			{
				if (_samples == value)
				{
					return;
				}
				_samples = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get
			{
				if (_intensity == null)
				{
					_intensity = (CFloat) CR2WTypeManager.Create("Float", "intensity", cr2w, this);
				}
				return _intensity;
			}
			set
			{
				if (_intensity == value)
				{
					return;
				}
				_intensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("blurDimension")] 
		public CEnum<inkEBlurDimension> BlurDimension
		{
			get
			{
				if (_blurDimension == null)
				{
					_blurDimension = (CEnum<inkEBlurDimension>) CR2WTypeManager.Create("inkEBlurDimension", "blurDimension", cr2w, this);
				}
				return _blurDimension;
			}
			set
			{
				if (_blurDimension == value)
				{
					return;
				}
				_blurDimension = value;
				PropertySet(this);
			}
		}

		public inkBoxBlurEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
