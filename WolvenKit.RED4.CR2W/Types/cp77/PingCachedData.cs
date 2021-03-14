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
			get
			{
				if (_sourceID == null)
				{
					_sourceID = (entEntityID) CR2WTypeManager.Create("entEntityID", "sourceID", cr2w, this);
				}
				return _sourceID;
			}
			set
			{
				if (_sourceID == value)
				{
					return;
				}
				_sourceID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pingType")] 
		public CEnum<EPingType> PingType
		{
			get
			{
				if (_pingType == null)
				{
					_pingType = (CEnum<EPingType>) CR2WTypeManager.Create("EPingType", "pingType", cr2w, this);
				}
				return _pingType;
			}
			set
			{
				if (_pingType == value)
				{
					return;
				}
				_pingType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pingNetworkEffect")] 
		public CHandle<gameEffectInstance> PingNetworkEffect
		{
			get
			{
				if (_pingNetworkEffect == null)
				{
					_pingNetworkEffect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "pingNetworkEffect", cr2w, this);
				}
				return _pingNetworkEffect;
			}
			set
			{
				if (_pingNetworkEffect == value)
				{
					return;
				}
				_pingNetworkEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get
			{
				if (_timeout == null)
				{
					_timeout = (CFloat) CR2WTypeManager.Create("Float", "timeout", cr2w, this);
				}
				return _timeout;
			}
			set
			{
				if (_timeout == value)
				{
					return;
				}
				_timeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ammountOfIntervals")] 
		public CInt32 AmmountOfIntervals
		{
			get
			{
				if (_ammountOfIntervals == null)
				{
					_ammountOfIntervals = (CInt32) CR2WTypeManager.Create("Int32", "ammountOfIntervals", cr2w, this);
				}
				return _ammountOfIntervals;
			}
			set
			{
				if (_ammountOfIntervals == value)
				{
					return;
				}
				_ammountOfIntervals = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("linksCount")] 
		public CInt32 LinksCount
		{
			get
			{
				if (_linksCount == null)
				{
					_linksCount = (CInt32) CR2WTypeManager.Create("Int32", "linksCount", cr2w, this);
				}
				return _linksCount;
			}
			set
			{
				if (_linksCount == value)
				{
					return;
				}
				_linksCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("currentInterval")] 
		public CInt32 CurrentInterval
		{
			get
			{
				if (_currentInterval == null)
				{
					_currentInterval = (CInt32) CR2WTypeManager.Create("Int32", "currentInterval", cr2w, this);
				}
				return _currentInterval;
			}
			set
			{
				if (_currentInterval == value)
				{
					return;
				}
				_currentInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get
			{
				if (_delayID == null)
				{
					_delayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayID", cr2w, this);
				}
				return _delayID;
			}
			set
			{
				if (_delayID == value)
				{
					return;
				}
				_delayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("linkType")] 
		public CEnum<ELinkType> LinkType
		{
			get
			{
				if (_linkType == null)
				{
					_linkType = (CEnum<ELinkType>) CR2WTypeManager.Create("ELinkType", "linkType", cr2w, this);
				}
				return _linkType;
			}
			set
			{
				if (_linkType == value)
				{
					return;
				}
				_linkType = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("revealNetwork")] 
		public CBool RevealNetwork
		{
			get
			{
				if (_revealNetwork == null)
				{
					_revealNetwork = (CBool) CR2WTypeManager.Create("Bool", "revealNetwork", cr2w, this);
				}
				return _revealNetwork;
			}
			set
			{
				if (_revealNetwork == value)
				{
					return;
				}
				_revealNetwork = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("linkFXresource")] 
		public gameFxResource LinkFXresource
		{
			get
			{
				if (_linkFXresource == null)
				{
					_linkFXresource = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "linkFXresource", cr2w, this);
				}
				return _linkFXresource;
			}
			set
			{
				if (_linkFXresource == value)
				{
					return;
				}
				_linkFXresource = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("sourcePosition")] 
		public Vector4 SourcePosition
		{
			get
			{
				if (_sourcePosition == null)
				{
					_sourcePosition = (Vector4) CR2WTypeManager.Create("Vector4", "sourcePosition", cr2w, this);
				}
				return _sourcePosition;
			}
			set
			{
				if (_sourcePosition == value)
				{
					return;
				}
				_sourcePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("hasActiveVirtualNetwork")] 
		public CBool HasActiveVirtualNetwork
		{
			get
			{
				if (_hasActiveVirtualNetwork == null)
				{
					_hasActiveVirtualNetwork = (CBool) CR2WTypeManager.Create("Bool", "hasActiveVirtualNetwork", cr2w, this);
				}
				return _hasActiveVirtualNetwork;
			}
			set
			{
				if (_hasActiveVirtualNetwork == value)
				{
					return;
				}
				_hasActiveVirtualNetwork = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("virtualNetworkShape")] 
		public wCHandle<gamedataVirtualNetwork_Record> VirtualNetworkShape
		{
			get
			{
				if (_virtualNetworkShape == null)
				{
					_virtualNetworkShape = (wCHandle<gamedataVirtualNetwork_Record>) CR2WTypeManager.Create("whandle:gamedataVirtualNetwork_Record", "virtualNetworkShape", cr2w, this);
				}
				return _virtualNetworkShape;
			}
			set
			{
				if (_virtualNetworkShape == value)
				{
					return;
				}
				_virtualNetworkShape = value;
				PropertySet(this);
			}
		}

		public PingCachedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
