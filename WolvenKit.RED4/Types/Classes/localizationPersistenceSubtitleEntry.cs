using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class localizationPersistenceSubtitleEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(1)] 
		[RED("femaleVariant")] 
		public CString FemaleVariant
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("maleVariant")] 
		public CString MaleVariant
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public localizationPersistenceSubtitleEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
