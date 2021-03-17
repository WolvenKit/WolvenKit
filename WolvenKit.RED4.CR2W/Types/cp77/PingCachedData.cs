using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PingCachedData : IScriptable
	{
		private entEntityID _sourceID;
		private CEnum<EPingType> _pingType;
		private CHandle<gameEffectInstance> _pingNetworkEffect;
		private CFloat _timeout;
		private CInt32 _ammountOfIntervals;
		private CInt32 _linksCount;
		private CInt32 _currentInterval;
		private gameDelayID _delayID;
		private CEnum<ELinkType> _linkType;
		private CBool _revealNetwork;
		private gameFxResource _linkFXresource;
		private Vector4 _sourcePosition;
		private CBool _hasActiveVirtualNetwork;
		private wCHandle<gamedataVirtualNetwork_Record> _virtualNetworkShape;

		[Ordinal(0)] 
		[RED("sourceID")] 
		public entEntityID SourceID
		{
			get => GetProperty(ref _sourceID);
			set => SetProperty(ref _sourceID, value);
		}

		[Ordinal(1)] 
		[RED("pingType")] 
		public CEnum<EPingType> PingType
		{
			get => GetProperty(ref _pingType);
			set => SetProperty(ref _pingType, value);
		}

		[Ordinal(2)] 
		[RED("pingNetworkEffect")] 
		public CHandle<gameEffectInstance> PingNetworkEffect
		{
			get => GetProperty(ref _pingNetworkEffect);
			set => SetProperty(ref _pingNetworkEffect, value);
		}

		[Ordinal(3)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetProperty(ref _timeout);
			set => SetProperty(ref _timeout, value);
		}

		[Ordinal(4)] 
		[RED("ammountOfIntervals")] 
		public CInt32 AmmountOfIntervals
		{
			get => GetProperty(ref _ammountOfIntervals);
			set => SetProperty(ref _ammountOfIntervals, value);
		}

		[Ordinal(5)] 
		[RED("linksCount")] 
		public CInt32 LinksCount
		{
			get => GetProperty(ref _linksCount);
			set => SetProperty(ref _linksCount, value);
		}

		[Ordinal(6)] 
		[RED("currentInterval")] 
		public CInt32 CurrentInterval
		{
			get => GetProperty(ref _currentInterval);
			set => SetProperty(ref _currentInterval, value);
		}

		[Ordinal(7)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetProperty(ref _delayID);
			set => SetProperty(ref _delayID, value);
		}

		[Ordinal(8)] 
		[RED("linkType")] 
		public CEnum<ELinkType> LinkType
		{
			get => GetProperty(ref _linkType);
			set => SetProperty(ref _linkType, value);
		}

		[Ordinal(9)] 
		[RED("revealNetwork")] 
		public CBool RevealNetwork
		{
			get => GetProperty(ref _revealNetwork);
			set => SetProperty(ref _revealNetwork, value);
		}

		[Ordinal(10)] 
		[RED("linkFXresource")] 
		public gameFxResource LinkFXresource
		{
			get => GetProperty(ref _linkFXresource);
			set => SetProperty(ref _linkFXresource, value);
		}

		[Ordinal(11)] 
		[RED("sourcePosition")] 
		public Vector4 SourcePosition
		{
			get => GetProperty(ref _sourcePosition);
			set => SetProperty(ref _sourcePosition, value);
		}

		[Ordinal(12)] 
		[RED("hasActiveVirtualNetwork")] 
		public CBool HasActiveVirtualNetwork
		{
			get => GetProperty(ref _hasActiveVirtualNetwork);
			set => SetProperty(ref _hasActiveVirtualNetwork, value);
		}

		[Ordinal(13)] 
		[RED("virtualNetworkShape")] 
		public wCHandle<gamedataVirtualNetwork_Record> VirtualNetworkShape
		{
			get => GetProperty(ref _virtualNetworkShape);
			set => SetProperty(ref _virtualNetworkShape, value);
		}

		public PingCachedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
