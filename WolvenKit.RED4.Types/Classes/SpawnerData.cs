using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpawnerData : RedBaseClass
	{
		private entEntityID _spawnerID;
		private CArray<CName> _entryNames;

		[Ordinal(0)] 
		[RED("spawnerID")] 
		public entEntityID SpawnerID
		{
			get => GetProperty(ref _spawnerID);
			set => SetProperty(ref _spawnerID, value);
		}

		[Ordinal(1)] 
		[RED("entryNames")] 
		public CArray<CName> EntryNames
		{
			get => GetProperty(ref _entryNames);
			set => SetProperty(ref _entryNames, value);
		}
	}
}
