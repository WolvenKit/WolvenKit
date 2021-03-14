using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestMappinController : gameuiQuestMappinController
	{
		private inkWidgetReference _arrowCanvas;
		private inkWidgetReference _arrowPart;
		private inkWidgetReference _selector;
		private inkWidgetReference _scanningDiamond;
		private inkWidgetReference _portalIcon;
		private wCHandle<inkWidget> _aboveWidget;
		private wCHandle<inkWidget> _belowWidget;
		private wCHandle<gamemappinsIMappin> _mappin;
		private wCHandle<gamemappinsQuestMappin> _questMappin;
		private wCHandle<gamemappinsRuntimeMappin> _runtimeMappin;
		private wCHandle<inkCompoundWidget> _root;
		private CBool _isMainQuest;
		private CBool _shouldHideWhenClamped;
		private CBool _isCompletedPhase;
		private CHandle<inkanimProxy> _animProxy;
		private inkanimPlaybackOptions _animOptions;
		private EngineTime _vehicleAlreadySummonedTime;
		private CFloat _vehiclePulseTimeSecs;
		private CHandle<VehicleMappinComponent> _vehicleMappinComponent;

		[Ordinal(14)] 
		[RED("arrowCanvas")] 
		public inkWidgetReference ArrowCanvas
		{
			get
			{
				if (_arrowCanvas == null)
				{
					_arrowCanvas = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "arrowCanvas", cr2w, this);
				}
				return _arrowCanvas;
			}
			set
			{
				if (_arrowCanvas == value)
				{
					return;
				}
				_arrowCanvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("arrowPart")] 
		public inkWidgetReference ArrowPart
		{
			get
			{
				if (_arrowPart == null)
				{
					_arrowPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "arrowPart", cr2w, this);
				}
				return _arrowPart;
			}
			set
			{
				if (_arrowPart == value)
				{
					return;
				}
				_arrowPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("selector")] 
		public inkWidgetReference Selector
		{
			get
			{
				if (_selector == null)
				{
					_selector = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selector", cr2w, this);
				}
				return _selector;
			}
			set
			{
				if (_selector == value)
				{
					return;
				}
				_selector = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("scanningDiamond")] 
		public inkWidgetReference ScanningDiamond
		{
			get
			{
				if (_scanningDiamond == null)
				{
					_scanningDiamond = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "scanningDiamond", cr2w, this);
				}
				return _scanningDiamond;
			}
			set
			{
				if (_scanningDiamond == value)
				{
					return;
				}
				_scanningDiamond = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("portalIcon")] 
		public inkWidgetReference PortalIcon
		{
			get
			{
				if (_portalIcon == null)
				{
					_portalIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "portalIcon", cr2w, this);
				}
				return _portalIcon;
			}
			set
			{
				if (_portalIcon == value)
				{
					return;
				}
				_portalIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("aboveWidget")] 
		public wCHandle<inkWidget> AboveWidget
		{
			get
			{
				if (_aboveWidget == null)
				{
					_aboveWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "aboveWidget", cr2w, this);
				}
				return _aboveWidget;
			}
			set
			{
				if (_aboveWidget == value)
				{
					return;
				}
				_aboveWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("belowWidget")] 
		public wCHandle<inkWidget> BelowWidget
		{
			get
			{
				if (_belowWidget == null)
				{
					_belowWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "belowWidget", cr2w, this);
				}
				return _belowWidget;
			}
			set
			{
				if (_belowWidget == value)
				{
					return;
				}
				_belowWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsIMappin> Mappin
		{
			get
			{
				if (_mappin == null)
				{
					_mappin = (wCHandle<gamemappinsIMappin>) CR2WTypeManager.Create("whandle:gamemappinsIMappin", "mappin", cr2w, this);
				}
				return _mappin;
			}
			set
			{
				if (_mappin == value)
				{
					return;
				}
				_mappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("questMappin")] 
		public wCHandle<gamemappinsQuestMappin> QuestMappin
		{
			get
			{
				if (_questMappin == null)
				{
					_questMappin = (wCHandle<gamemappinsQuestMappin>) CR2WTypeManager.Create("whandle:gamemappinsQuestMappin", "questMappin", cr2w, this);
				}
				return _questMappin;
			}
			set
			{
				if (_questMappin == value)
				{
					return;
				}
				_questMappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("runtimeMappin")] 
		public wCHandle<gamemappinsRuntimeMappin> RuntimeMappin
		{
			get
			{
				if (_runtimeMappin == null)
				{
					_runtimeMappin = (wCHandle<gamemappinsRuntimeMappin>) CR2WTypeManager.Create("whandle:gamemappinsRuntimeMappin", "runtimeMappin", cr2w, this);
				}
				return _runtimeMappin;
			}
			set
			{
				if (_runtimeMappin == value)
				{
					return;
				}
				_runtimeMappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("isMainQuest")] 
		public CBool IsMainQuest
		{
			get
			{
				if (_isMainQuest == null)
				{
					_isMainQuest = (CBool) CR2WTypeManager.Create("Bool", "isMainQuest", cr2w, this);
				}
				return _isMainQuest;
			}
			set
			{
				if (_isMainQuest == value)
				{
					return;
				}
				_isMainQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("shouldHideWhenClamped")] 
		public CBool ShouldHideWhenClamped
		{
			get
			{
				if (_shouldHideWhenClamped == null)
				{
					_shouldHideWhenClamped = (CBool) CR2WTypeManager.Create("Bool", "shouldHideWhenClamped", cr2w, this);
				}
				return _shouldHideWhenClamped;
			}
			set
			{
				if (_shouldHideWhenClamped == value)
				{
					return;
				}
				_shouldHideWhenClamped = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("isCompletedPhase")] 
		public CBool IsCompletedPhase
		{
			get
			{
				if (_isCompletedPhase == null)
				{
					_isCompletedPhase = (CBool) CR2WTypeManager.Create("Bool", "isCompletedPhase", cr2w, this);
				}
				return _isCompletedPhase;
			}
			set
			{
				if (_isCompletedPhase == value)
				{
					return;
				}
				_isCompletedPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("animOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get
			{
				if (_animOptions == null)
				{
					_animOptions = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "animOptions", cr2w, this);
				}
				return _animOptions;
			}
			set
			{
				if (_animOptions == value)
				{
					return;
				}
				_animOptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("vehicleAlreadySummonedTime")] 
		public EngineTime VehicleAlreadySummonedTime
		{
			get
			{
				if (_vehicleAlreadySummonedTime == null)
				{
					_vehicleAlreadySummonedTime = (EngineTime) CR2WTypeManager.Create("EngineTime", "vehicleAlreadySummonedTime", cr2w, this);
				}
				return _vehicleAlreadySummonedTime;
			}
			set
			{
				if (_vehicleAlreadySummonedTime == value)
				{
					return;
				}
				_vehicleAlreadySummonedTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("vehiclePulseTimeSecs")] 
		public CFloat VehiclePulseTimeSecs
		{
			get
			{
				if (_vehiclePulseTimeSecs == null)
				{
					_vehiclePulseTimeSecs = (CFloat) CR2WTypeManager.Create("Float", "vehiclePulseTimeSecs", cr2w, this);
				}
				return _vehiclePulseTimeSecs;
			}
			set
			{
				if (_vehiclePulseTimeSecs == value)
				{
					return;
				}
				_vehiclePulseTimeSecs = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("vehicleMappinComponent")] 
		public CHandle<VehicleMappinComponent> VehicleMappinComponent
		{
			get
			{
				if (_vehicleMappinComponent == null)
				{
					_vehicleMappinComponent = (CHandle<VehicleMappinComponent>) CR2WTypeManager.Create("handle:VehicleMappinComponent", "vehicleMappinComponent", cr2w, this);
				}
				return _vehicleMappinComponent;
			}
			set
			{
				if (_vehicleMappinComponent == value)
				{
					return;
				}
				_vehicleMappinComponent = value;
				PropertySet(this);
			}
		}

		public QuestMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
