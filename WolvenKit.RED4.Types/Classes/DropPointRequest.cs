using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DropPointRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("record")] 
		public TweakDBID Record
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
		[RED("holder")] 
		public gamePersistentID Holder
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		public DropPointRequest()
		{
			Holder = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
