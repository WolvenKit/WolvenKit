using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GenericStreetSignSelector : StreetSignSelector
	{
		[Ordinal(1)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public GenericStreetSignSelector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
