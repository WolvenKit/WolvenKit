using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StartPingingNetworkRequest : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _source;
		private gameFxResource _fxResource;
		private CFloat _duration;
		private CEnum<EPingType> _pingType;
		private CEnum<ELinkType> _fakeLinkType;
		private CBool _revealNetworkAtEnd;
		private TweakDBID _virtualNetworkShapeID;

		[Ordinal(0)] 
		[RED("source")] 
		public wCHandle<gameObject> Source
		{
			get
			{
				if (_source == null)
				{
					_source = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get
			{
				if (_fxResource == null)
				{
					_fxResource = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "fxResource", cr2w, this);
				}
				return _fxResource;
			}
			set
			{
				if (_fxResource == value)
				{
					return;
				}
				_fxResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("fakeLinkType")] 
		public CEnum<ELinkType> FakeLinkType
		{
			get
			{
				if (_fakeLinkType == null)
				{
					_fakeLinkType = (CEnum<ELinkType>) CR2WTypeManager.Create("ELinkType", "fakeLinkType", cr2w, this);
				}
				return _fakeLinkType;
			}
			set
			{
				if (_fakeLinkType == value)
				{
					return;
				}
				_fakeLinkType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("revealNetworkAtEnd")] 
		public CBool RevealNetworkAtEnd
		{
			get
			{
				if (_revealNetworkAtEnd == null)
				{
					_revealNetworkAtEnd = (CBool) CR2WTypeManager.Create("Bool", "revealNetworkAtEnd", cr2w, this);
				}
				return _revealNetworkAtEnd;
			}
			set
			{
				if (_revealNetworkAtEnd == value)
				{
					return;
				}
				_revealNetworkAtEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("virtualNetworkShapeID")] 
		public TweakDBID VirtualNetworkShapeID
		{
			get
			{
				if (_virtualNetworkShapeID == null)
				{
					_virtualNetworkShapeID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "virtualNetworkShapeID", cr2w, this);
				}
				return _virtualNetworkShapeID;
			}
			set
			{
				if (_virtualNetworkShapeID == value)
				{
					return;
				}
				_virtualNetworkShapeID = value;
				PropertySet(this);
			}
		}

		public StartPingingNetworkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
