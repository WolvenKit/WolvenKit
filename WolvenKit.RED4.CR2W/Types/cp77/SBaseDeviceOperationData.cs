using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBaseDeviceOperationData : CVariable
	{
		private CFloat _delay;
		private CBool _resetDelay;
		private CBool _executeOnce;
		private CBool _isEnabled;
		private CArray<STransformAnimationData> _transformAnimations;
		private CArray<SVFXOperationData> _vFXs;
		private CArray<SSFXOperationData> _sFXs;
		private CArray<SFactOperationData> _facts;
		private CArray<SComponentOperationData> _components;
		private CArray<SStimOperationData> _stims;
		private CArray<SStatusEffectOperationData> _statusEffects;
		private CArray<SDamageOperationData> _damages;
		private CArray<SInventoryOperationData> _items;
		private STeleportOperationData _teleport;
		private CName _meshesAppearence;
		private SWorkspotData _playerWorkspot;
		private CBool _disableDevice;
		private CArray<SToggleOperationData> _toggleOperations;
		private CInt32 _id;
		private gameDelayID _delayID;
		private CBool _isDelayActive;

		[Ordinal(0)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get
			{
				if (_delay == null)
				{
					_delay = (CFloat) CR2WTypeManager.Create("Float", "delay", cr2w, this);
				}
				return _delay;
			}
			set
			{
				if (_delay == value)
				{
					return;
				}
				_delay = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("resetDelay")] 
		public CBool ResetDelay
		{
			get
			{
				if (_resetDelay == null)
				{
					_resetDelay = (CBool) CR2WTypeManager.Create("Bool", "resetDelay", cr2w, this);
				}
				return _resetDelay;
			}
			set
			{
				if (_resetDelay == value)
				{
					return;
				}
				_resetDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("executeOnce")] 
		public CBool ExecuteOnce
		{
			get
			{
				if (_executeOnce == null)
				{
					_executeOnce = (CBool) CR2WTypeManager.Create("Bool", "executeOnce", cr2w, this);
				}
				return _executeOnce;
			}
			set
			{
				if (_executeOnce == value)
				{
					return;
				}
				_executeOnce = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("transformAnimations")] 
		public CArray<STransformAnimationData> TransformAnimations
		{
			get
			{
				if (_transformAnimations == null)
				{
					_transformAnimations = (CArray<STransformAnimationData>) CR2WTypeManager.Create("array:STransformAnimationData", "transformAnimations", cr2w, this);
				}
				return _transformAnimations;
			}
			set
			{
				if (_transformAnimations == value)
				{
					return;
				}
				_transformAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("VFXs")] 
		public CArray<SVFXOperationData> VFXs
		{
			get
			{
				if (_vFXs == null)
				{
					_vFXs = (CArray<SVFXOperationData>) CR2WTypeManager.Create("array:SVFXOperationData", "VFXs", cr2w, this);
				}
				return _vFXs;
			}
			set
			{
				if (_vFXs == value)
				{
					return;
				}
				_vFXs = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("SFXs")] 
		public CArray<SSFXOperationData> SFXs
		{
			get
			{
				if (_sFXs == null)
				{
					_sFXs = (CArray<SSFXOperationData>) CR2WTypeManager.Create("array:SSFXOperationData", "SFXs", cr2w, this);
				}
				return _sFXs;
			}
			set
			{
				if (_sFXs == value)
				{
					return;
				}
				_sFXs = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get
			{
				if (_facts == null)
				{
					_facts = (CArray<SFactOperationData>) CR2WTypeManager.Create("array:SFactOperationData", "facts", cr2w, this);
				}
				return _facts;
			}
			set
			{
				if (_facts == value)
				{
					return;
				}
				_facts = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("components")] 
		public CArray<SComponentOperationData> Components
		{
			get
			{
				if (_components == null)
				{
					_components = (CArray<SComponentOperationData>) CR2WTypeManager.Create("array:SComponentOperationData", "components", cr2w, this);
				}
				return _components;
			}
			set
			{
				if (_components == value)
				{
					return;
				}
				_components = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("stims")] 
		public CArray<SStimOperationData> Stims
		{
			get
			{
				if (_stims == null)
				{
					_stims = (CArray<SStimOperationData>) CR2WTypeManager.Create("array:SStimOperationData", "stims", cr2w, this);
				}
				return _stims;
			}
			set
			{
				if (_stims == value)
				{
					return;
				}
				_stims = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("statusEffects")] 
		public CArray<SStatusEffectOperationData> StatusEffects
		{
			get
			{
				if (_statusEffects == null)
				{
					_statusEffects = (CArray<SStatusEffectOperationData>) CR2WTypeManager.Create("array:SStatusEffectOperationData", "statusEffects", cr2w, this);
				}
				return _statusEffects;
			}
			set
			{
				if (_statusEffects == value)
				{
					return;
				}
				_statusEffects = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("damages")] 
		public CArray<SDamageOperationData> Damages
		{
			get
			{
				if (_damages == null)
				{
					_damages = (CArray<SDamageOperationData>) CR2WTypeManager.Create("array:SDamageOperationData", "damages", cr2w, this);
				}
				return _damages;
			}
			set
			{
				if (_damages == value)
				{
					return;
				}
				_damages = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("items")] 
		public CArray<SInventoryOperationData> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<SInventoryOperationData>) CR2WTypeManager.Create("array:SInventoryOperationData", "items", cr2w, this);
				}
				return _items;
			}
			set
			{
				if (_items == value)
				{
					return;
				}
				_items = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("teleport")] 
		public STeleportOperationData Teleport
		{
			get
			{
				if (_teleport == null)
				{
					_teleport = (STeleportOperationData) CR2WTypeManager.Create("STeleportOperationData", "teleport", cr2w, this);
				}
				return _teleport;
			}
			set
			{
				if (_teleport == value)
				{
					return;
				}
				_teleport = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("meshesAppearence")] 
		public CName MeshesAppearence
		{
			get
			{
				if (_meshesAppearence == null)
				{
					_meshesAppearence = (CName) CR2WTypeManager.Create("CName", "meshesAppearence", cr2w, this);
				}
				return _meshesAppearence;
			}
			set
			{
				if (_meshesAppearence == value)
				{
					return;
				}
				_meshesAppearence = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("playerWorkspot")] 
		public SWorkspotData PlayerWorkspot
		{
			get
			{
				if (_playerWorkspot == null)
				{
					_playerWorkspot = (SWorkspotData) CR2WTypeManager.Create("SWorkspotData", "playerWorkspot", cr2w, this);
				}
				return _playerWorkspot;
			}
			set
			{
				if (_playerWorkspot == value)
				{
					return;
				}
				_playerWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("disableDevice")] 
		public CBool DisableDevice
		{
			get
			{
				if (_disableDevice == null)
				{
					_disableDevice = (CBool) CR2WTypeManager.Create("Bool", "disableDevice", cr2w, this);
				}
				return _disableDevice;
			}
			set
			{
				if (_disableDevice == value)
				{
					return;
				}
				_disableDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("toggleOperations")] 
		public CArray<SToggleOperationData> ToggleOperations
		{
			get
			{
				if (_toggleOperations == null)
				{
					_toggleOperations = (CArray<SToggleOperationData>) CR2WTypeManager.Create("array:SToggleOperationData", "toggleOperations", cr2w, this);
				}
				return _toggleOperations;
			}
			set
			{
				if (_toggleOperations == value)
				{
					return;
				}
				_toggleOperations = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("id")] 
		public CInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CInt32) CR2WTypeManager.Create("Int32", "id", cr2w, this);
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
		[RED("isDelayActive")] 
		public CBool IsDelayActive
		{
			get
			{
				if (_isDelayActive == null)
				{
					_isDelayActive = (CBool) CR2WTypeManager.Create("Bool", "isDelayActive", cr2w, this);
				}
				return _isDelayActive;
			}
			set
			{
				if (_isDelayActive == value)
				{
					return;
				}
				_isDelayActive = value;
				PropertySet(this);
			}
		}

		public SBaseDeviceOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
