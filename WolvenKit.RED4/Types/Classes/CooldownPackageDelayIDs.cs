using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CooldownPackageDelayIDs : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("packageID")] 
		public CooldownStorageID PackageID
		{
			get => GetPropertyValue<CooldownStorageID>();
			set => SetPropertyValue<CooldownStorageID>(value);
		}

		[Ordinal(1)] 
		[RED("delayIDs")] 
		public CArray<gameDelayID> DelayIDs
		{
			get => GetPropertyValue<CArray<gameDelayID>>();
			set => SetPropertyValue<CArray<gameDelayID>>(value);
		}

		public CooldownPackageDelayIDs()
		{
			PackageID = new CooldownStorageID();
			DelayIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
