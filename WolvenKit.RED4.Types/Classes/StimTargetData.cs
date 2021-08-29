using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StimTargetData : RedBaseClass
	{
		private NodeRef _spawnerRef;
		private CName _entryID;

		[Ordinal(0)] 
		[RED("spawnerRef")] 
		public NodeRef SpawnerRef
		{
			get => GetProperty(ref _spawnerRef);
			set => SetProperty(ref _spawnerRef, value);
		}

		[Ordinal(1)] 
		[RED("entryID")] 
		public CName EntryID
		{
			get => GetProperty(ref _entryID);
			set => SetProperty(ref _entryID, value);
		}
	}
}
