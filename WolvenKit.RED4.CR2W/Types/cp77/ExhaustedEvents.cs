using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExhaustedEvents : StaminaEventsTransition
	{
		private CHandle<worldEffectBlackboard> _staminaVfxBlackboard;

		[Ordinal(1)] 
		[RED("staminaVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> StaminaVfxBlackboard
		{
			get => GetProperty(ref _staminaVfxBlackboard);
			set => SetProperty(ref _staminaVfxBlackboard, value);
		}

		public ExhaustedEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
