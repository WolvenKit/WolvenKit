using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtAdditionalPreset_BothArms : animLookAtAdditionalPreset
	{
		private CBool _rightHanded;
		private CFloat _softLimitAngle;

		[Ordinal(0)] 
		[RED("rightHanded")] 
		public CBool RightHanded
		{
			get => GetProperty(ref _rightHanded);
			set => SetProperty(ref _rightHanded, value);
		}

		[Ordinal(1)] 
		[RED("softLimitAngle")] 
		public CFloat SoftLimitAngle
		{
			get => GetProperty(ref _softLimitAngle);
			set => SetProperty(ref _softLimitAngle, value);
		}

		public animLookAtAdditionalPreset_BothArms(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
