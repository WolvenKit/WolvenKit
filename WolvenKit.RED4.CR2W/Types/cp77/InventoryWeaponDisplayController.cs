using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponDisplayController : InventoryItemDisplayController
	{
		private inkCompoundWidgetReference _weaponSpecyficModsRoot;
		private inkWidgetReference _statsWrapper;
		private inkTextWidgetReference _dpsText;
		private inkImageWidgetReference _damageTypeIndicatorImage;
		private inkWidgetReference _dpsWrapper;
		private inkTextWidgetReference _dpsValue;
		private inkWidgetReference _silencerIcon;
		private inkWidgetReference _scopeIcon;
		private inkWidgetReference _dpsArrow;
		private CArray<wCHandle<InventoryItemPartDisplay>> _weaponAttachmentsDisplay;

		[Ordinal(78)] 
		[RED("weaponSpecyficModsRoot")] 
		public inkCompoundWidgetReference WeaponSpecyficModsRoot
		{
			get
			{
				if (_weaponSpecyficModsRoot == null)
				{
					_weaponSpecyficModsRoot = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "weaponSpecyficModsRoot", cr2w, this);
				}
				return _weaponSpecyficModsRoot;
			}
			set
			{
				if (_weaponSpecyficModsRoot == value)
				{
					return;
				}
				_weaponSpecyficModsRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get
			{
				if (_statsWrapper == null)
				{
					_statsWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "statsWrapper", cr2w, this);
				}
				return _statsWrapper;
			}
			set
			{
				if (_statsWrapper == value)
				{
					return;
				}
				_statsWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get
			{
				if (_dpsText == null)
				{
					_dpsText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "dpsText", cr2w, this);
				}
				return _dpsText;
			}
			set
			{
				if (_dpsText == value)
				{
					return;
				}
				_dpsText = value;
				PropertySet(this);
			}
		}

		[Ordinal(81)] 
		[RED("damageTypeIndicatorImage")] 
		public inkImageWidgetReference DamageTypeIndicatorImage
		{
			get
			{
				if (_damageTypeIndicatorImage == null)
				{
					_damageTypeIndicatorImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "damageTypeIndicatorImage", cr2w, this);
				}
				return _damageTypeIndicatorImage;
			}
			set
			{
				if (_damageTypeIndicatorImage == value)
				{
					return;
				}
				_damageTypeIndicatorImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(82)] 
		[RED("dpsWrapper")] 
		public inkWidgetReference DpsWrapper
		{
			get
			{
				if (_dpsWrapper == null)
				{
					_dpsWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "dpsWrapper", cr2w, this);
				}
				return _dpsWrapper;
			}
			set
			{
				if (_dpsWrapper == value)
				{
					return;
				}
				_dpsWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(83)] 
		[RED("dpsValue")] 
		public inkTextWidgetReference DpsValue
		{
			get
			{
				if (_dpsValue == null)
				{
					_dpsValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "dpsValue", cr2w, this);
				}
				return _dpsValue;
			}
			set
			{
				if (_dpsValue == value)
				{
					return;
				}
				_dpsValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(84)] 
		[RED("silencerIcon")] 
		public inkWidgetReference SilencerIcon
		{
			get
			{
				if (_silencerIcon == null)
				{
					_silencerIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "silencerIcon", cr2w, this);
				}
				return _silencerIcon;
			}
			set
			{
				if (_silencerIcon == value)
				{
					return;
				}
				_silencerIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(85)] 
		[RED("scopeIcon")] 
		public inkWidgetReference ScopeIcon
		{
			get
			{
				if (_scopeIcon == null)
				{
					_scopeIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "scopeIcon", cr2w, this);
				}
				return _scopeIcon;
			}
			set
			{
				if (_scopeIcon == value)
				{
					return;
				}
				_scopeIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(86)] 
		[RED("dpsArrow")] 
		public inkWidgetReference DpsArrow
		{
			get
			{
				if (_dpsArrow == null)
				{
					_dpsArrow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "dpsArrow", cr2w, this);
				}
				return _dpsArrow;
			}
			set
			{
				if (_dpsArrow == value)
				{
					return;
				}
				_dpsArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("weaponAttachmentsDisplay")] 
		public CArray<wCHandle<InventoryItemPartDisplay>> WeaponAttachmentsDisplay
		{
			get
			{
				if (_weaponAttachmentsDisplay == null)
				{
					_weaponAttachmentsDisplay = (CArray<wCHandle<InventoryItemPartDisplay>>) CR2WTypeManager.Create("array:whandle:InventoryItemPartDisplay", "weaponAttachmentsDisplay", cr2w, this);
				}
				return _weaponAttachmentsDisplay;
			}
			set
			{
				if (_weaponAttachmentsDisplay == value)
				{
					return;
				}
				_weaponAttachmentsDisplay = value;
				PropertySet(this);
			}
		}

		public InventoryWeaponDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
