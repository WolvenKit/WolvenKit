using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdTemplateEntry : CVariable
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

		public gameCrowdTemplateEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
