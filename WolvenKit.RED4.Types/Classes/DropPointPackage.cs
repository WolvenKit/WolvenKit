using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DropPointPackage : IScriptable
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<DropPointPackageStatus> Status
		{
			get => GetPropertyValue<CEnum<DropPointPackageStatus>>();
			set => SetPropertyValue<CEnum<DropPointPackageStatus>>(value);
		}

		[Ordinal(2)] 
		[RED("predefinedDrop")] 
		public gamePersistentID PredefinedDrop
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(3)] 
		[RED("statusHistory")] 
		public CArray<CEnum<DropPointPackageStatus>> StatusHistory
		{
			get => GetPropertyValue<CArray<CEnum<DropPointPackageStatus>>>();
			set => SetPropertyValue<CArray<CEnum<DropPointPackageStatus>>>(value);
		}

		public DropPointPackage()
		{
			PredefinedDrop = new();
			StatusHistory = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
