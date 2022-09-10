using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetIconSelectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("IconID")] 
		public TweakDBID IconID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public SetIconSelectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
