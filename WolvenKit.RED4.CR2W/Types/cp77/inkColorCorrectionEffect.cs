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
			get => GetProperty(ref _brightness);
			set => SetProperty(ref _brightness, value);
		}

		[Ordinal(3)] 
		[RED("contrast")] 
		public CFloat Contrast
		{
			get => GetProperty(ref _contrast);
			set => SetProperty(ref _contrast, value);
		}

		[Ordinal(4)] 
		[RED("saturation")] 
		public CFloat Saturation
		{
			get => GetProperty(ref _saturation);
			set => SetProperty(ref _saturation, value);
		}

		public inkColorCorrectionEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
