using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCrowdTemplateEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("markings")] 
		public CArray<CName> Markings
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("phases")] 
		public CArray<gameCrowdTemplateEntryPhase> Phases
		{
			get => GetPropertyValue<CArray<gameCrowdTemplateEntryPhase>>();
			set => SetPropertyValue<CArray<gameCrowdTemplateEntryPhase>>(value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gameCrowdEntryType> Type
		{
			get => GetPropertyValue<CEnum<gameCrowdEntryType>>();
			set => SetPropertyValue<CEnum<gameCrowdEntryType>>(value);
		}

		public gameCrowdTemplateEntry()
		{
			Markings = new();
			Phases = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
