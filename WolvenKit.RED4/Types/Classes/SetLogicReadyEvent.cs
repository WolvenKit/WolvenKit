using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetLogicReadyEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetLogicReadyEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
