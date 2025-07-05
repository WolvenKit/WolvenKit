using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CityFluffMessageSelector : ScreenMessageSelector
	{
		[Ordinal(3)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public CityFluffMessageSelector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
