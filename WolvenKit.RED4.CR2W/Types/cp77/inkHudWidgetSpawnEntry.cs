using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkHudWidgetSpawnEntry : CVariable
	{
		private CName _hudEntryName;
		private CBool _enabled;
		private CEnum<worlduiContextVisibility> _contextVisibility;
		private CEnum<gameuiContext> _gameContextVisibility;
		private CEnum<inkSpawnMode> _spawnMode;
		private rRef<inkWidgetLibraryResource> _widgetResource;
		private CEnum<inkEAnchor> _anchorPlace;
		private Vector2 _anchorPoint;
		private inkMargin _margins;
		private CBool _attachToSlot;
		private inkWidgetSlotAttachmentParams _slotParams;
		private CBool _useSeparateWindow;
		private CBool _affectedByGlitchEffect;
		private CBool _spawnBeforeSlots;

		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CName HudEntryName
		{
			get
			{
				if (_hudEntryName == null)
				{
					_hudEntryName = (CName) CR2WTypeManager.Create("CName", "hudEntryName", cr2w, this);
				}
				return _hudEntryName;
			}
			set
			{
				if (_hudEntryName == value)
				{
					return;
				}
				_hudEntryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("contextVisibility")] 
		public CEnum<worlduiContextVisibility> ContextVisibility
		{
			get
			{
				if (_contextVisibility == null)
				{
					_contextVisibility = (CEnum<worlduiContextVisibility>) CR2WTypeManager.Create("worlduiContextVisibility", "contextVisibility", cr2w, this);
				}
				return _contextVisibility;
			}
			set
			{
				if (_contextVisibility == value)
				{
					return;
				}
				_contextVisibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("gameContextVisibility")] 
		public CEnum<gameuiContext> GameContextVisibility
		{
			get
			{
				if (_gameContextVisibility == null)
				{
					_gameContextVisibility = (CEnum<gameuiContext>) CR2WTypeManager.Create("gameuiContext", "gameContextVisibility", cr2w, this);
				}
				return _gameContextVisibility;
			}
			set
			{
				if (_gameContextVisibility == value)
				{
					return;
				}
				_gameContextVisibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("spawnMode")] 
		public CEnum<inkSpawnMode> SpawnMode
		{
			get
			{
				if (_spawnMode == null)
				{
					_spawnMode = (CEnum<inkSpawnMode>) CR2WTypeManager.Create("inkSpawnMode", "spawnMode", cr2w, this);
				}
				return _spawnMode;
			}
			set
			{
				if (_spawnMode == value)
				{
					return;
				}
				_spawnMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("widgetResource")] 
		public rRef<inkWidgetLibraryResource> WidgetResource
		{
			get
			{
				if (_widgetResource == null)
				{
					_widgetResource = (rRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("rRef:inkWidgetLibraryResource", "widgetResource", cr2w, this);
				}
				return _widgetResource;
			}
			set
			{
				if (_widgetResource == value)
				{
					return;
				}
				_widgetResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("anchorPlace")] 
		public CEnum<inkEAnchor> AnchorPlace
		{
			get
			{
				if (_anchorPlace == null)
				{
					_anchorPlace = (CEnum<inkEAnchor>) CR2WTypeManager.Create("inkEAnchor", "anchorPlace", cr2w, this);
				}
				return _anchorPlace;
			}
			set
			{
				if (_anchorPlace == value)
				{
					return;
				}
				_anchorPlace = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("anchorPoint")] 
		public Vector2 AnchorPoint
		{
			get
			{
				if (_anchorPoint == null)
				{
					_anchorPoint = (Vector2) CR2WTypeManager.Create("Vector2", "anchorPoint", cr2w, this);
				}
				return _anchorPoint;
			}
			set
			{
				if (_anchorPoint == value)
				{
					return;
				}
				_anchorPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("margins")] 
		public inkMargin Margins
		{
			get
			{
				if (_margins == null)
				{
					_margins = (inkMargin) CR2WTypeManager.Create("inkMargin", "margins", cr2w, this);
				}
				return _margins;
			}
			set
			{
				if (_margins == value)
				{
					return;
				}
				_margins = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("attachToSlot")] 
		public CBool AttachToSlot
		{
			get
			{
				if (_attachToSlot == null)
				{
					_attachToSlot = (CBool) CR2WTypeManager.Create("Bool", "attachToSlot", cr2w, this);
				}
				return _attachToSlot;
			}
			set
			{
				if (_attachToSlot == value)
				{
					return;
				}
				_attachToSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("slotParams")] 
		public inkWidgetSlotAttachmentParams SlotParams
		{
			get
			{
				if (_slotParams == null)
				{
					_slotParams = (inkWidgetSlotAttachmentParams) CR2WTypeManager.Create("inkWidgetSlotAttachmentParams", "slotParams", cr2w, this);
				}
				return _slotParams;
			}
			set
			{
				if (_slotParams == value)
				{
					return;
				}
				_slotParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("useSeparateWindow")] 
		public CBool UseSeparateWindow
		{
			get
			{
				if (_useSeparateWindow == null)
				{
					_useSeparateWindow = (CBool) CR2WTypeManager.Create("Bool", "useSeparateWindow", cr2w, this);
				}
				return _useSeparateWindow;
			}
			set
			{
				if (_useSeparateWindow == value)
				{
					return;
				}
				_useSeparateWindow = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("affectedByGlitchEffect")] 
		public CBool AffectedByGlitchEffect
		{
			get
			{
				if (_affectedByGlitchEffect == null)
				{
					_affectedByGlitchEffect = (CBool) CR2WTypeManager.Create("Bool", "affectedByGlitchEffect", cr2w, this);
				}
				return _affectedByGlitchEffect;
			}
			set
			{
				if (_affectedByGlitchEffect == value)
				{
					return;
				}
				_affectedByGlitchEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("spawnBeforeSlots")] 
		public CBool SpawnBeforeSlots
		{
			get
			{
				if (_spawnBeforeSlots == null)
				{
					_spawnBeforeSlots = (CBool) CR2WTypeManager.Create("Bool", "spawnBeforeSlots", cr2w, this);
				}
				return _spawnBeforeSlots;
			}
			set
			{
				if (_spawnBeforeSlots == value)
				{
					return;
				}
				_spawnBeforeSlots = value;
				PropertySet(this);
			}
		}

		public inkHudWidgetSpawnEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
