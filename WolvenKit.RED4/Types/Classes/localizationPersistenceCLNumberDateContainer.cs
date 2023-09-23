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

		[Ordinal(2)] 
		[RED("clGeneratedIds")] 
		public CArray<CString> ClGeneratedIds
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public localizationPersistenceCLNumberDateContainer()
		{
			ClGeneratedIds = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
