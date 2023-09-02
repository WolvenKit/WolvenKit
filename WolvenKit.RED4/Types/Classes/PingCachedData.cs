using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PingCachedData : IScriptable
	{
		[Ordinal(0)] 
		[RED("sourceID")] 
		public entEntityID SourceID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("pingType")] 
		public CEnum<EPingType> PingType
		{
			get => GetPropertyValue<CEnum<EPingType>>();
			set => SetPropertyValue<CEnum<EPingType>>(value);
		}

		[Ordinal(2)] 
		[RED("pingNetworkEffect")] 
		public CHandle<gameEffectInstance> PingNetworkEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(3)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("ammountOfIntervals")] 
		public CInt32 AmmountOfIntervals
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("linksCount")] 
		public CInt32 LinksCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("currentInterval")] 
		public CInt32 CurrentInterval
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(8)] 
		[RED("linkType")] 
		public CEnum<ELinkType> LinkType
		{
			get => GetPropertyValue<CEnum<ELinkType>>();
			set => SetPropertyValue<CEnum<ELinkType>>(value);
		}

		[Ordinal(9)] 
		[RED("revealNetwork")] 
		public CBool RevealNetwork
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("linkFXresource")] 
		public gameFxResource LinkFXresource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(11)] 
		[RED("sourcePosition")] 
		public Vector4 SourcePosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(12)] 
		[RED("hasActiveVirtualNetwork")] 
		public CBool HasActiveVirtualNetwork
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("virtualNetworkShape")] 
		public CWeakHandle<gamedataVirtualNetwork_Record> VirtualNetworkShape
		{
			get => GetPropertyValue<CWeakHandle<gamedataVirtualNetwork_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataVirtualNetwork_Record>>(value);
		}

		public PingCachedData()
		{
			SourceID = new entEntityID();
			CurrentInterval = 1;
			DelayID = new gameDelayID();
			LinkType = Enums.ELinkType.FREE;
			LinkFXresource = new gameFxResource();
			SourcePosition = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
