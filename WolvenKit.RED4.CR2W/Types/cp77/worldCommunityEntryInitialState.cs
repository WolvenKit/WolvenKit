using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCommunityEntryInitialState : CVariable
	{
		private CName _entryName;
		private CName _initialPhaseName;
		private CBool _entryActiveOnStart;

		[Ordinal(0)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetProperty(ref _entryName);
			set => SetProperty(ref _entryName, value);
		}

		[Ordinal(1)] 
		[RED("initialPhaseName")] 
		public CName InitialPhaseName
		{
			get => GetProperty(ref _initialPhaseName);
			set => SetProperty(ref _initialPhaseName, value);
		}

		[Ordinal(2)] 
		[RED("entryActiveOnStart")] 
		public CBool EntryActiveOnStart
		{
			get => GetProperty(ref _entryActiveOnStart);
			set => SetProperty(ref _entryActiveOnStart, value);
		}

		public worldCommunityEntryInitialState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
