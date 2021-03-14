using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAISpotNode : worldSocketNode
	{
		private CHandle<AISpot> _spot;
		private CBool _isWorkspotInfinite;
		private CBool _isWorkspotStatic;
		private CArray<CName> _markings;
		private CHandle<worldTrafficSpotDefinition> _spotDef;
		private CBool _disableBumps;
		private NodeRef _lookAtTarget;
		private worldGlobalNodeID _nearTrafficSrc;
		private CBool _useCrowdWhitelist;
		private CBool _useCrowdBlacklist;
		private redTagList _crowdWhitelist;
		private redTagList _crowdBlacklist;

		[Ordinal(4)] 
		[RED("spot")] 
		public CHandle<AISpot> Spot
		{
			get
			{
				if (_spot == null)
				{
					_spot = (CHandle<AISpot>) CR2WTypeManager.Create("handle:AISpot", "spot", cr2w, this);
				}
				return _spot;
			}
			set
			{
				if (_spot == value)
				{
					return;
				}
				_spot = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isWorkspotInfinite")] 
		public CBool IsWorkspotInfinite
		{
			get
			{
				if (_isWorkspotInfinite == null)
				{
					_isWorkspotInfinite = (CBool) CR2WTypeManager.Create("Bool", "isWorkspotInfinite", cr2w, this);
				}
				return _isWorkspotInfinite;
			}
			set
			{
				if (_isWorkspotInfinite == value)
				{
					return;
				}
				_isWorkspotInfinite = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isWorkspotStatic")] 
		public CBool IsWorkspotStatic
		{
			get
			{
				if (_isWorkspotStatic == null)
				{
					_isWorkspotStatic = (CBool) CR2WTypeManager.Create("Bool", "isWorkspotStatic", cr2w, this);
				}
				return _isWorkspotStatic;
			}
			set
			{
				if (_isWorkspotStatic == value)
				{
					return;
				}
				_isWorkspotStatic = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("markings")] 
		public CArray<CName> Markings
		{
			get
			{
				if (_markings == null)
				{
					_markings = (CArray<CName>) CR2WTypeManager.Create("array:CName", "markings", cr2w, this);
				}
				return _markings;
			}
			set
			{
				if (_markings == value)
				{
					return;
				}
				_markings = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("spotDef")] 
		public CHandle<worldTrafficSpotDefinition> SpotDef
		{
			get
			{
				if (_spotDef == null)
				{
					_spotDef = (CHandle<worldTrafficSpotDefinition>) CR2WTypeManager.Create("handle:worldTrafficSpotDefinition", "spotDef", cr2w, this);
				}
				return _spotDef;
			}
			set
			{
				if (_spotDef == value)
				{
					return;
				}
				_spotDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("disableBumps")] 
		public CBool DisableBumps
		{
			get
			{
				if (_disableBumps == null)
				{
					_disableBumps = (CBool) CR2WTypeManager.Create("Bool", "disableBumps", cr2w, this);
				}
				return _disableBumps;
			}
			set
			{
				if (_disableBumps == value)
				{
					return;
				}
				_disableBumps = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("lookAtTarget")] 
		public NodeRef LookAtTarget
		{
			get
			{
				if (_lookAtTarget == null)
				{
					_lookAtTarget = (NodeRef) CR2WTypeManager.Create("NodeRef", "lookAtTarget", cr2w, this);
				}
				return _lookAtTarget;
			}
			set
			{
				if (_lookAtTarget == value)
				{
					return;
				}
				_lookAtTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("nearTrafficSrc")] 
		public worldGlobalNodeID NearTrafficSrc
		{
			get
			{
				if (_nearTrafficSrc == null)
				{
					_nearTrafficSrc = (worldGlobalNodeID) CR2WTypeManager.Create("worldGlobalNodeID", "nearTrafficSrc", cr2w, this);
				}
				return _nearTrafficSrc;
			}
			set
			{
				if (_nearTrafficSrc == value)
				{
					return;
				}
				_nearTrafficSrc = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("useCrowdWhitelist")] 
		public CBool UseCrowdWhitelist
		{
			get
			{
				if (_useCrowdWhitelist == null)
				{
					_useCrowdWhitelist = (CBool) CR2WTypeManager.Create("Bool", "useCrowdWhitelist", cr2w, this);
				}
				return _useCrowdWhitelist;
			}
			set
			{
				if (_useCrowdWhitelist == value)
				{
					return;
				}
				_useCrowdWhitelist = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("useCrowdBlacklist")] 
		public CBool UseCrowdBlacklist
		{
			get
			{
				if (_useCrowdBlacklist == null)
				{
					_useCrowdBlacklist = (CBool) CR2WTypeManager.Create("Bool", "useCrowdBlacklist", cr2w, this);
				}
				return _useCrowdBlacklist;
			}
			set
			{
				if (_useCrowdBlacklist == value)
				{
					return;
				}
				_useCrowdBlacklist = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("crowdWhitelist")] 
		public redTagList CrowdWhitelist
		{
			get
			{
				if (_crowdWhitelist == null)
				{
					_crowdWhitelist = (redTagList) CR2WTypeManager.Create("redTagList", "crowdWhitelist", cr2w, this);
				}
				return _crowdWhitelist;
			}
			set
			{
				if (_crowdWhitelist == value)
				{
					return;
				}
				_crowdWhitelist = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("crowdBlacklist")] 
		public redTagList CrowdBlacklist
		{
			get
			{
				if (_crowdBlacklist == null)
				{
					_crowdBlacklist = (redTagList) CR2WTypeManager.Create("redTagList", "crowdBlacklist", cr2w, this);
				}
				return _crowdBlacklist;
			}
			set
			{
				if (_crowdBlacklist == value)
				{
					return;
				}
				_crowdBlacklist = value;
				PropertySet(this);
			}
		}

		public worldAISpotNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
