using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StartPingingNetworkRequest : gameScriptableSystemRequest
	{
		private CWeakHandle<gameObject> _source;
		private gameFxResource _fxResource;
		private CFloat _duration;
		private CEnum<EPingType> _pingType;
		private CEnum<ELinkType> _fakeLinkType;
		private CBool _revealNetworkAtEnd;
		private TweakDBID _virtualNetworkShapeID;

		[Ordinal(0)] 
		[RED("source")] 
		public CWeakHandle<gameObject> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get => GetProperty(ref _fxResource);
			set => SetProperty(ref _fxResource, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("pingType")] 
		public CEnum<EPingType> PingType
		{
			get => GetProperty(ref _pingType);
			set => SetProperty(ref _pingType, value);
		}

		[Ordinal(4)] 
		[RED("fakeLinkType")] 
		public CEnum<ELinkType> FakeLinkType
		{
			get => GetProperty(ref _fakeLinkType);
			set => SetProperty(ref _fakeLinkType, value);
		}

		[Ordinal(5)] 
		[RED("revealNetworkAtEnd")] 
		public CBool RevealNetworkAtEnd
		{
			get => GetProperty(ref _revealNetworkAtEnd);
			set => SetProperty(ref _revealNetworkAtEnd, value);
		}

		[Ordinal(6)] 
		[RED("virtualNetworkShapeID")] 
		public TweakDBID VirtualNetworkShapeID
		{
			get => GetProperty(ref _virtualNetworkShapeID);
			set => SetProperty(ref _virtualNetworkShapeID, value);
		}
	}
}
