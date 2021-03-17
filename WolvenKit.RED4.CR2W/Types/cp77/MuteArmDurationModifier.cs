using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MuteArmDurationModifier : gameEffectDurationModifier_Scripted
	{
		private CFloat _initialDuration;

		[Ordinal(0)] 
		[RED("initialDuration")] 
		public CFloat InitialDuration
		{
			get => GetProperty(ref _initialDuration);
			set => SetProperty(ref _initialDuration, value);
		}

		public MuteArmDurationModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
