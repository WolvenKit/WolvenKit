using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SNetworkLinkData : CVariable
	{
		private CHandle<gameFxInstance> _beam;
		private gameFxResource _fxResource;
		private entEntityID _slaveID;
		private entEntityID _masterID;
		private Vector4 _slavePos;
		private Vector4 _masterPos;
		private CBool _drawLink;
		private CBool _isActive;
		private CBool _isDynamic;
		private CBool _revealMaster;
		private CBool _revealSlave;
		private CBool _permanent;
		private CBool _isPing;
		private CBool _isNetrunner;
		private CEnum<ELinkType> _linkType;
		private CEnum<EPriority> _priority;
		private CFloat _lifetime;
		private gameDelayID _delayID;
		private CBool _weakLink;

		[Ordinal(0)] 
		[RED("beam")] 
		public CHandle<gameFxInstance> Beam
		{
			get
			{
				if (_beam == null)
				{
					_beam = (CHandle<gameFxInstance>) CR2WTypeManager.Create("handle:gameFxInstance", "beam", cr2w, this);
				}
				return _beam;
			}
			set
			{
				if (_beam == value)
				{
					return;
				}
				_beam = value;
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
		[RED("slaveID")] 
		public entEntityID SlaveID
		{
			get
			{
				if (_slaveID == null)
				{
					_slaveID = (entEntityID) CR2WTypeManager.Create("entEntityID", "slaveID", cr2w, this);
				}
				return _slaveID;
			}
			set
			{
				if (_slaveID == value)
				{
					return;
				}
				_slaveID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("masterID")] 
		public entEntityID MasterID
		{
			get
			{
				if (_masterID == null)
				{
					_masterID = (entEntityID) CR2WTypeManager.Create("entEntityID", "masterID", cr2w, this);
				}
				return _masterID;
			}
			set
			{
				if (_masterID == value)
				{
					return;
				}
				_masterID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("slavePos")] 
		public Vector4 SlavePos
		{
			get
			{
				if (_slavePos == null)
				{
					_slavePos = (Vector4) CR2WTypeManager.Create("Vector4", "slavePos", cr2w, this);
				}
				return _slavePos;
			}
			set
			{
				if (_slavePos == value)
				{
					return;
				}
				_slavePos = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("masterPos")] 
		public Vector4 MasterPos
		{
			get
			{
				if (_masterPos == null)
				{
					_masterPos = (Vector4) CR2WTypeManager.Create("Vector4", "masterPos", cr2w, this);
				}
				return _masterPos;
			}
			set
			{
				if (_masterPos == value)
				{
					return;
				}
				_masterPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("drawLink")] 
		public CBool DrawLink
		{
			get
			{
				if (_drawLink == null)
				{
					_drawLink = (CBool) CR2WTypeManager.Create("Bool", "drawLink", cr2w, this);
				}
				return _drawLink;
			}
			set
			{
				if (_drawLink == value)
				{
					return;
				}
				_drawLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get
			{
				if (_isDynamic == null)
				{
					_isDynamic = (CBool) CR2WTypeManager.Create("Bool", "isDynamic", cr2w, this);
				}
				return _isDynamic;
			}
			set
			{
				if (_isDynamic == value)
				{
					return;
				}
				_isDynamic = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get
			{
				if (_revealMaster == null)
				{
					_revealMaster = (CBool) CR2WTypeManager.Create("Bool", "revealMaster", cr2w, this);
				}
				return _revealMaster;
			}
			set
			{
				if (_revealMaster == value)
				{
					return;
				}
				_revealMaster = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get
			{
				if (_revealSlave == null)
				{
					_revealSlave = (CBool) CR2WTypeManager.Create("Bool", "revealSlave", cr2w, this);
				}
				return _revealSlave;
			}
			set
			{
				if (_revealSlave == value)
				{
					return;
				}
				_revealSlave = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("permanent")] 
		public CBool Permanent
		{
			get
			{
				if (_permanent == null)
				{
					_permanent = (CBool) CR2WTypeManager.Create("Bool", "permanent", cr2w, this);
				}
				return _permanent;
			}
			set
			{
				if (_permanent == value)
				{
					return;
				}
				_permanent = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isPing")] 
		public CBool IsPing
		{
			get
			{
				if (_isPing == null)
				{
					_isPing = (CBool) CR2WTypeManager.Create("Bool", "isPing", cr2w, this);
				}
				return _isPing;
			}
			set
			{
				if (_isPing == value)
				{
					return;
				}
				_isPing = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isNetrunner")] 
		public CBool IsNetrunner
		{
			get
			{
				if (_isNetrunner == null)
				{
					_isNetrunner = (CBool) CR2WTypeManager.Create("Bool", "isNetrunner", cr2w, this);
				}
				return _isNetrunner;
			}
			set
			{
				if (_isNetrunner == value)
				{
					return;
				}
				_isNetrunner = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CEnum<EPriority>) CR2WTypeManager.Create("EPriority", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get
			{
				if (_lifetime == null)
				{
					_lifetime = (CFloat) CR2WTypeManager.Create("Float", "lifetime", cr2w, this);
				}
				return _lifetime;
			}
			set
			{
				if (_lifetime == value)
				{
					return;
				}
				_lifetime = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
		[RED("weakLink")] 
		public CBool WeakLink
		{
			get
			{
				if (_weakLink == null)
				{
					_weakLink = (CBool) CR2WTypeManager.Create("Bool", "weakLink", cr2w, this);
				}
				return _weakLink;
			}
			set
			{
				if (_weakLink == value)
				{
					return;
				}
				_weakLink = value;
				PropertySet(this);
			}
		}

		public SNetworkLinkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
