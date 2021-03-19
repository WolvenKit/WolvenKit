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
			get => GetProperty(ref _samples);
			set => SetProperty(ref _samples, value);
		}

		[Ordinal(3)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		[Ordinal(4)] 
		[RED("blurDimension")] 
		public CEnum<inkEBlurDimension> BlurDimension
		{
			get => GetProperty(ref _blurDimension);
			set => SetProperty(ref _blurDimension, value);
		}

		public inkBoxBlurEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
