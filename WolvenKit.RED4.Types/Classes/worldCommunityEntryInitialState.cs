using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCommunityEntryInitialState : RedBaseClass
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
	}
}
