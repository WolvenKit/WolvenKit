using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPreset_EyesHeadWithoutSuppress : animLookAtPreset
	{
		private CFloat _headMobility;
		private CFloat _softLimitAngle;

		[Ordinal(0)] 
		[RED("headMobility")] 
		public CFloat HeadMobility
		{
			get => GetProperty(ref _headMobility);
			set => SetProperty(ref _headMobility, value);
		}

		[Ordinal(1)] 
		[RED("softLimitAngle")] 
		public CFloat SoftLimitAngle
		{
			get => GetProperty(ref _softLimitAngle);
			set => SetProperty(ref _softLimitAngle, value);
		}

		public animLookAtPreset_EyesHeadWithoutSuppress(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
