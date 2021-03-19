using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetQuickThrowEvents : CombatGadgetTransitions
	{
		private CBool _grenadeThrown;
		private CBool _event;

		[Ordinal(0)] 
		[RED("grenadeThrown")] 
		public CBool GrenadeThrown
		{
			get => GetProperty(ref _grenadeThrown);
			set => SetProperty(ref _grenadeThrown, value);
		}

		[Ordinal(1)] 
		[RED("event")] 
		public CBool Event
		{
			get => GetProperty(ref _event);
			set => SetProperty(ref _event, value);
		}

		public CombatGadgetQuickThrowEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
