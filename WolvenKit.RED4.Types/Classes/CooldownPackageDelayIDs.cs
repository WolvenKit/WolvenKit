using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CooldownPackageDelayIDs : RedBaseClass
	{
		private CooldownStorageID _packageID;
		private CArray<gameDelayID> _delayIDs;

		[Ordinal(0)] 
		[RED("packageID")] 
		public CooldownStorageID PackageID
		{
			get => GetProperty(ref _packageID);
			set => SetProperty(ref _packageID, value);
		}

		[Ordinal(1)] 
		[RED("delayIDs")] 
		public CArray<gameDelayID> DelayIDs
		{
			get => GetProperty(ref _delayIDs);
			set => SetProperty(ref _delayIDs, value);
		}
	}
}
