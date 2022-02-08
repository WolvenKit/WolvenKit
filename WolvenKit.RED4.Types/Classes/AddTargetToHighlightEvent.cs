using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddTargetToHighlightEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("target")] 
		public CombatTarget Target
		{
			get => GetPropertyValue<CombatTarget>();
			set => SetPropertyValue<CombatTarget>(value);
		}

		public AddTargetToHighlightEvent()
		{
			Target = new();
		}
	}
}
