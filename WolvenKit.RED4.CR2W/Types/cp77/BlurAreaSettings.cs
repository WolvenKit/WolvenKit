using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlurAreaSettings : IAreaSettings
	{
		private CFloat _circularBlurRadius;

		[Ordinal(2)] 
		[RED("circularBlurRadius")] 
		public CFloat CircularBlurRadius
		{
			get => GetProperty(ref _circularBlurRadius);
			set => SetProperty(ref _circularBlurRadius, value);
		}

		public BlurAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
