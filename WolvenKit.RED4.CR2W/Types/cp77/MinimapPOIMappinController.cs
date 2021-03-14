using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimapPOIMappinController : gameuiBaseMinimapMappinController
	{
		private inkWidgetReference _pulseWidget;
		private CBool _pingAnimationOnStateChange;
		private wCHandle<gamemappinsPointOfInterestMappin> _poiMappin;
		private CBool _isCompletedPhase;
		private CEnum<gamedataMappinPhase> _mappinPhase;
		private CHandle<inkanimProxy> _pingAnim;
		private CUInt32 _c_pingAnimCount;
		private CHandle<VehicleMinimapMappinComponent> _vehicleMinimapMappinComponent;
		private CBool _keepIconOnClamping;

		[Ordinal(14)] 
		[RED("pulseWidget")] 
		public inkWidgetReference PulseWidget
		{
			get
			{
				if (_pulseWidget == null)
				{
					_pulseWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "pulseWidget", cr2w, this);
				}
				return _pulseWidget;
			}
			set
			{
				if (_pulseWidget == value)
				{
					return;
				}
				_pulseWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("pingAnimationOnStateChange")] 
		public CBool PingAnimationOnStateChange
		{
			get
			{
				if (_pingAnimationOnStateChange == null)
				{
					_pingAnimationOnStateChange = (CBool) CR2WTypeManager.Create("Bool", "pingAnimationOnStateChange", cr2w, this);
				}
				return _pingAnimationOnStateChange;
			}
			set
			{
				if (_pingAnimationOnStateChange == value)
				{
					return;
				}
				_pingAnimationOnStateChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("poiMappin")] 
		public wCHandle<gamemappinsPointOfInterestMappin> PoiMappin
		{
			get
			{
				if (_poiMappin == null)
				{
					_poiMappin = (wCHandle<gamemappinsPointOfInterestMappin>) CR2WTypeManager.Create("whandle:gamemappinsPointOfInterestMappin", "poiMappin", cr2w, this);
				}
				return _poiMappin;
			}
			set
			{
				if (_poiMappin == value)
				{
					return;
				}
				_poiMappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
		[RED("mappinPhase")] 
		public CEnum<gamedataMappinPhase> MappinPhase
		{
			get
			{
				if (_mappinPhase == null)
				{
					_mappinPhase = (CEnum<gamedataMappinPhase>) CR2WTypeManager.Create("gamedataMappinPhase", "mappinPhase", cr2w, this);
				}
				return _mappinPhase;
			}
			set
			{
				if (_mappinPhase == value)
				{
					return;
				}
				_mappinPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("pingAnim")] 
		public CHandle<inkanimProxy> PingAnim
		{
			get
			{
				if (_pingAnim == null)
				{
					_pingAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "pingAnim", cr2w, this);
				}
				return _pingAnim;
			}
			set
			{
				if (_pingAnim == value)
				{
					return;
				}
				_pingAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("c_pingAnimCount")] 
		public CUInt32 C_pingAnimCount
		{
			get
			{
				if (_c_pingAnimCount == null)
				{
					_c_pingAnimCount = (CUInt32) CR2WTypeManager.Create("Uint32", "c_pingAnimCount", cr2w, this);
				}
				return _c_pingAnimCount;
			}
			set
			{
				if (_c_pingAnimCount == value)
				{
					return;
				}
				_c_pingAnimCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("vehicleMinimapMappinComponent")] 
		public CHandle<VehicleMinimapMappinComponent> VehicleMinimapMappinComponent
		{
			get
			{
				if (_vehicleMinimapMappinComponent == null)
				{
					_vehicleMinimapMappinComponent = (CHandle<VehicleMinimapMappinComponent>) CR2WTypeManager.Create("handle:VehicleMinimapMappinComponent", "vehicleMinimapMappinComponent", cr2w, this);
				}
				return _vehicleMinimapMappinComponent;
			}
			set
			{
				if (_vehicleMinimapMappinComponent == value)
				{
					return;
				}
				_vehicleMinimapMappinComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("keepIconOnClamping")] 
		public CBool KeepIconOnClamping
		{
			get
			{
				if (_keepIconOnClamping == null)
				{
					_keepIconOnClamping = (CBool) CR2WTypeManager.Create("Bool", "keepIconOnClamping", cr2w, this);
				}
				return _keepIconOnClamping;
			}
			set
			{
				if (_keepIconOnClamping == value)
				{
					return;
				}
				_keepIconOnClamping = value;
				PropertySet(this);
			}
		}

		public MinimapPOIMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
