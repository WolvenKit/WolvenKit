using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDeviceMappinData : CVariable
	{
		private CName _mappinName;
		private TweakDBID _mappinType;
		private CEnum<gamedataMappinVariant> _mappinVariant;
		private CBool _enabled;
		private CFloat _range;
		private CString _caption;
		private Vector4 _offset;
		private Vector4 _position;
		private CBool _permanent;
		private CBool _checkIfIsTarget;
		private gameNewMappinID _id;
		private CBool _active;
		private CEnum<EGameplayRole> _gameplayRole;
		private CHandle<GameplayRoleMappinData> _visualStateData;

		[Ordinal(0)] 
		[RED("mappinName")] 
		public CName MappinName
		{
			get
			{
				if (_mappinName == null)
				{
					_mappinName = (CName) CR2WTypeManager.Create("CName", "mappinName", cr2w, this);
				}
				return _mappinName;
			}
			set
			{
				if (_mappinName == value)
				{
					return;
				}
				_mappinName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mappinType")] 
		public TweakDBID MappinType
		{
			get
			{
				if (_mappinType == null)
				{
					_mappinType = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "mappinType", cr2w, this);
				}
				return _mappinType;
			}
			set
			{
				if (_mappinType == value)
				{
					return;
				}
				_mappinType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mappinVariant")] 
		public CEnum<gamedataMappinVariant> MappinVariant
		{
			get
			{
				if (_mappinVariant == null)
				{
					_mappinVariant = (CEnum<gamedataMappinVariant>) CR2WTypeManager.Create("gamedataMappinVariant", "mappinVariant", cr2w, this);
				}
				return _mappinVariant;
			}
			set
			{
				if (_mappinVariant == value)
				{
					return;
				}
				_mappinVariant = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("range")] 
		public CFloat Range
		{
			get
			{
				if (_range == null)
				{
					_range = (CFloat) CR2WTypeManager.Create("Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("caption")] 
		public CString Caption
		{
			get
			{
				if (_caption == null)
				{
					_caption = (CString) CR2WTypeManager.Create("String", "caption", cr2w, this);
				}
				return _caption;
			}
			set
			{
				if (_caption == value)
				{
					return;
				}
				_caption = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public Vector4 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector4) CR2WTypeManager.Create("Vector4", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("checkIfIsTarget")] 
		public CBool CheckIfIsTarget
		{
			get
			{
				if (_checkIfIsTarget == null)
				{
					_checkIfIsTarget = (CBool) CR2WTypeManager.Create("Bool", "checkIfIsTarget", cr2w, this);
				}
				return _checkIfIsTarget;
			}
			set
			{
				if (_checkIfIsTarget == value)
				{
					return;
				}
				_checkIfIsTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("id")] 
		public gameNewMappinID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (gameNewMappinID) CR2WTypeManager.Create("gameNewMappinID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("gameplayRole")] 
		public CEnum<EGameplayRole> GameplayRole
		{
			get
			{
				if (_gameplayRole == null)
				{
					_gameplayRole = (CEnum<EGameplayRole>) CR2WTypeManager.Create("EGameplayRole", "gameplayRole", cr2w, this);
				}
				return _gameplayRole;
			}
			set
			{
				if (_gameplayRole == value)
				{
					return;
				}
				_gameplayRole = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("visualStateData")] 
		public CHandle<GameplayRoleMappinData> VisualStateData
		{
			get
			{
				if (_visualStateData == null)
				{
					_visualStateData = (CHandle<GameplayRoleMappinData>) CR2WTypeManager.Create("handle:GameplayRoleMappinData", "visualStateData", cr2w, this);
				}
				return _visualStateData;
			}
			set
			{
				if (_visualStateData == value)
				{
					return;
				}
				_visualStateData = value;
				PropertySet(this);
			}
		}

		public SDeviceMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
