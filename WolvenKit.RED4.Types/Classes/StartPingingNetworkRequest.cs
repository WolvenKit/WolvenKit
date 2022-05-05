using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StartPingingNetworkRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
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
		[RED("fakeLinkType")] 
		public CEnum<ELinkType> FakeLinkType
		{
			get => GetPropertyValue<CEnum<ELinkType>>();
			set => SetPropertyValue<CEnum<ELinkType>>(value);
		}

		[Ordinal(5)] 
		[RED("revealNetworkAtEnd")] 
		public CBool RevealNetworkAtEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("virtualNetworkShapeID")] 
		public TweakDBID VirtualNetworkShapeID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public StartPingingNetworkRequest()
		{
			FxResource = new();
			Duration = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
