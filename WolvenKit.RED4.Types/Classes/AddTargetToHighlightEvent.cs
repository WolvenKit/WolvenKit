using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddTargetToHighlightEvent : redEvent
	{
		private CombatTarget _target;

		[Ordinal(0)] 
		[RED("target")] 
		public CombatTarget Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}
	}
}
