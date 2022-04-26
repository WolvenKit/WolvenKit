using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class localizationPersistenceCLNumberDateContainer : ISerializable
	{
		[Ordinal(0)] 
		[RED("clNumber")] 
		public CName ClNumber
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("clTimestamp")] 
		public CName ClTimestamp
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public localizationPersistenceCLNumberDateContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
