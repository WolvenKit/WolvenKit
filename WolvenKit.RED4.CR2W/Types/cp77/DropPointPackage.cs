using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointPackage : IScriptable
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

		public DropPointPackage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
