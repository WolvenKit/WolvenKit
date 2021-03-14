using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PingNetworkGridEvent : redEvent
	{
		private Vector4 _ownerEntityPosition;
		private gameFxResource _fxResource;
		private CFloat _lifetime;
		private CEnum<EPingType> _pingType;
		private CBool _revealSlave;
		private CBool _revealMaster;
		private CBool _ignoreRevealed;

		[Ordinal(0)] 
		[RED("ownerEntityPosition")] 
		public Vector4 OwnerEntityPosition
		{
			get
			{
				if (_ownerEntityPosition == null)
				{
					_ownerEntityPosition = (Vector4) CR2WTypeManager.Create("Vector4", "ownerEntityPosition", cr2w, this);
				}
				return _ownerEntityPosition;
			}
			set
			{
				if (_ownerEntityPosition == value)
				{
					return;
				}
				_ownerEntityPosition = value;
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("ignoreRevealed")] 
		public CBool IgnoreRevealed
		{
			get
			{
				if (_ignoreRevealed == null)
				{
					_ignoreRevealed = (CBool) CR2WTypeManager.Create("Bool", "ignoreRevealed", cr2w, this);
				}
				return _ignoreRevealed;
			}
			set
			{
				if (_ignoreRevealed == value)
				{
					return;
				}
				_ignoreRevealed = value;
				PropertySet(this);
			}
		}

		public PingNetworkGridEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
