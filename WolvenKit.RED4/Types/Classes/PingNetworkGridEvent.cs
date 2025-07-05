using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PingNetworkGridEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ownerEntityPosition")] 
		public Vector4 OwnerEntityPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(2)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("pingType")] 
		public CEnum<EPingType> PingType
		{
			get => GetPropertyValue<CEnum<EPingType>>();
			set => SetPropertyValue<CEnum<EPingType>>(value);
		}

		[Ordinal(4)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("ignoreRevealed")] 
		public CBool IgnoreRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PingNetworkGridEvent()
		{
			OwnerEntityPosition = new Vector4();
			FxResource = new gameFxResource();
			Lifetime = -1.000000F;
			RevealMaster = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
