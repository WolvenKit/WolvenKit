using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CityFluffScreenSelector : LCDScreenSelector
	{
		[Ordinal(4)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public CityFluffScreenSelector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
