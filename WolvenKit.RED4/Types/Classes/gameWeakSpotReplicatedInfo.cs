using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameWeakSpotReplicatedInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("weakSpotRecordID")] 
		public CUInt64 WeakSpotRecordID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("wsHealthValue")] 
		public CFloat WsHealthValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("LastDamageInstigator")] 
		public CWeakHandle<gamePuppet> LastDamageInstigator
		{
			get => GetPropertyValue<CWeakHandle<gamePuppet>>();
			set => SetPropertyValue<CWeakHandle<gamePuppet>>(value);
		}

		public gameWeakSpotReplicatedInfo()
		{
			WsHealthValue = 100.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
