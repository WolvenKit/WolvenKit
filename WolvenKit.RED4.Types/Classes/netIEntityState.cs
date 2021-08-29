using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netIEntityState : RedBaseClass
	{
		private TweakDBID _recordID;
		private CUInt64 _persistentID;

		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(1)] 
		[RED("persistentID")] 
		public CUInt64 PersistentID
		{
			get => GetProperty(ref _persistentID);
			set => SetProperty(ref _persistentID, value);
		}
	}
}
