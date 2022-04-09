using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddForceHighlightTargetEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("effecName")] 
		public CName EffecName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AddForceHighlightTargetEvent()
		{
			TargetID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
