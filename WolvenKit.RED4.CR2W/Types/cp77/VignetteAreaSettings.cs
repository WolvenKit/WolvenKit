using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VignetteAreaSettings : IAreaSettings
	{
		private CBool _vignetteEnabled;
		private CFloat _vignetteRadius;
		private CFloat _vignetteExp;
		private CColor _vignetteColor;

		[Ordinal(2)] 
		[RED("vignetteEnabled")] 
		public CBool VignetteEnabled
		{
			get => GetProperty(ref _vignetteEnabled);
			set => SetProperty(ref _vignetteEnabled, value);
		}

		[Ordinal(3)] 
		[RED("vignetteRadius")] 
		public CFloat VignetteRadius
		{
			get => GetProperty(ref _vignetteRadius);
			set => SetProperty(ref _vignetteRadius, value);
		}

		[Ordinal(4)] 
		[RED("vignetteExp")] 
		public CFloat VignetteExp
		{
			get => GetProperty(ref _vignetteExp);
			set => SetProperty(ref _vignetteExp, value);
		}

		[Ordinal(5)] 
		[RED("vignetteColor")] 
		public CColor VignetteColor
		{
			get => GetProperty(ref _vignetteColor);
			set => SetProperty(ref _vignetteColor, value);
		}

		public VignetteAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
