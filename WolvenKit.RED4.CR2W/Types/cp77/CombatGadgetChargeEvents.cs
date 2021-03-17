using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetChargeEvents : CombatGadgetTransitions
	{
		private CBool _initiated;
		private CBool _itemSwitched;

		[Ordinal(0)] 
		[RED("initiated")] 
		public CBool Initiated
		{
			get => GetProperty(ref _initiated);
			set => SetProperty(ref _initiated, value);
		}

		[Ordinal(1)] 
		[RED("itemSwitched")] 
		public CBool ItemSwitched
		{
			get => GetProperty(ref _itemSwitched);
			set => SetProperty(ref _itemSwitched, value);
		}

		public CombatGadgetChargeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
