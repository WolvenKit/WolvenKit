using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestAddTransition : redEvent
	{
		private AreaTypeTransition _transition;

		[Ordinal(0)] 
		[RED("transition")] 
		public AreaTypeTransition Transition
		{
			get => GetProperty(ref _transition);
			set => SetProperty(ref _transition, value);
		}
	}
}
