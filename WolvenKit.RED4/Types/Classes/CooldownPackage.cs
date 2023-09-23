using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CooldownPackage : IScriptable
	{
		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("addressees")] 
		public CArray<PSOwnerData> Addressees
		{
			get => GetPropertyValue<CArray<PSOwnerData>>();
			set => SetPropertyValue<CArray<PSOwnerData>>(value);
		}

		[Ordinal(2)] 
		[RED("initialCooldown")] 
		public CFloat InitialCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("label")] 
		public CooldownStorageID Label
		{
			get => GetPropertyValue<CooldownStorageID>();
			set => SetPropertyValue<CooldownStorageID>(value);
		}

		[Ordinal(4)] 
		[RED("packageStatus")] 
		public CEnum<PackageStatus> PackageStatus
		{
			get => GetPropertyValue<CEnum<PackageStatus>>();
			set => SetPropertyValue<CEnum<PackageStatus>>(value);
		}

		public CooldownPackage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
