using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCrowdTemplateEntry : RedBaseClass
	{
		private CName _entryName;
		private CArray<CName> _markings;
		private CArray<gameCrowdTemplateEntryPhase> _phases;
		private CEnum<gameCrowdEntryType> _type;

		[Ordinal(0)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetProperty(ref _entryName);
			set => SetProperty(ref _entryName, value);
		}

		[Ordinal(1)] 
		[RED("markings")] 
		public CArray<CName> Markings
		{
			get => GetProperty(ref _markings);
			set => SetProperty(ref _markings, value);
		}

		[Ordinal(2)] 
		[RED("phases")] 
		public CArray<gameCrowdTemplateEntryPhase> Phases
		{
			get => GetProperty(ref _phases);
			set => SetProperty(ref _phases, value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gameCrowdEntryType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
