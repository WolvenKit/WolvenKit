using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropPointPackage : IScriptable
	{
		private TweakDBID _itemID;
		private CEnum<DropPointPackageStatus> _status;
		private gamePersistentID _predefinedDrop;
		private CArray<CEnum<DropPointPackageStatus>> _statusHistory;

		[Ordinal(0)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<DropPointPackageStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(2)] 
		[RED("predefinedDrop")] 
		public gamePersistentID PredefinedDrop
		{
			get => GetProperty(ref _predefinedDrop);
			set => SetProperty(ref _predefinedDrop, value);
		}

		[Ordinal(3)] 
		[RED("statusHistory")] 
		public CArray<CEnum<DropPointPackageStatus>> StatusHistory
		{
			get => GetProperty(ref _statusHistory);
			set => SetProperty(ref _statusHistory, value);
		}
	}
}
