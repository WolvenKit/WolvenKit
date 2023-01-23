using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetQuestTargetWasSeen : redEvent
	{
		[Ordinal(0)] 
		[RED("wasSeen")] 
		public CBool WasSeen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetQuestTargetWasSeen()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
