using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleBaseObject : gameObject
	{
		private rRef<AIArchetype> _archetype;
		private wCHandle<VehicleComponent> _vehicleComponent;
		private wCHandle<WorldWidgetComponent> _uiComponent;
		private CHandle<CrowdMemberBaseComponent> _crowdMemberComponent;
		private CFloat _hitTimestamp;
		private CName _drivingTrafficPattern;
		private CBool _onPavement;
		private CBool _inTrafficLane;
		private CInt32 _timesSentReactionEvent;
		private CBool _vehicleUpsideDown;

		[Ordinal(40)] 
		[RED("archetype")] 
		public rRef<AIArchetype> Archetype
		{
			get
			{
				if (_archetype == null)
				{
					_archetype = (rRef<AIArchetype>) CR2WTypeManager.Create("rRef:AIArchetype", "archetype", cr2w, this);
				}
				return _archetype;
			}
			set
			{
				if (_archetype == value)
				{
					return;
				}
				_archetype = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("vehicleComponent")] 
		public wCHandle<VehicleComponent> VehicleComponent
		{
			get
			{
				if (_vehicleComponent == null)
				{
					_vehicleComponent = (wCHandle<VehicleComponent>) CR2WTypeManager.Create("whandle:VehicleComponent", "vehicleComponent", cr2w, this);
				}
				return _vehicleComponent;
			}
			set
			{
				if (_vehicleComponent == value)
				{
					return;
				}
				_vehicleComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("uiComponent")] 
		public wCHandle<WorldWidgetComponent> UiComponent
		{
			get
			{
				if (_uiComponent == null)
				{
					_uiComponent = (wCHandle<WorldWidgetComponent>) CR2WTypeManager.Create("whandle:WorldWidgetComponent", "uiComponent", cr2w, this);
				}
				return _uiComponent;
			}
			set
			{
				if (_uiComponent == value)
				{
					return;
				}
				_uiComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("crowdMemberComponent")] 
		public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent
		{
			get
			{
				if (_crowdMemberComponent == null)
				{
					_crowdMemberComponent = (CHandle<CrowdMemberBaseComponent>) CR2WTypeManager.Create("handle:CrowdMemberBaseComponent", "crowdMemberComponent", cr2w, this);
				}
				return _crowdMemberComponent;
			}
			set
			{
				if (_crowdMemberComponent == value)
				{
					return;
				}
				_crowdMemberComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("hitTimestamp")] 
		public CFloat HitTimestamp
		{
			get
			{
				if (_hitTimestamp == null)
				{
					_hitTimestamp = (CFloat) CR2WTypeManager.Create("Float", "hitTimestamp", cr2w, this);
				}
				return _hitTimestamp;
			}
			set
			{
				if (_hitTimestamp == value)
				{
					return;
				}
				_hitTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("drivingTrafficPattern")] 
		public CName DrivingTrafficPattern
		{
			get
			{
				if (_drivingTrafficPattern == null)
				{
					_drivingTrafficPattern = (CName) CR2WTypeManager.Create("CName", "drivingTrafficPattern", cr2w, this);
				}
				return _drivingTrafficPattern;
			}
			set
			{
				if (_drivingTrafficPattern == value)
				{
					return;
				}
				_drivingTrafficPattern = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("onPavement")] 
		public CBool OnPavement
		{
			get
			{
				if (_onPavement == null)
				{
					_onPavement = (CBool) CR2WTypeManager.Create("Bool", "onPavement", cr2w, this);
				}
				return _onPavement;
			}
			set
			{
				if (_onPavement == value)
				{
					return;
				}
				_onPavement = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("inTrafficLane")] 
		public CBool InTrafficLane
		{
			get
			{
				if (_inTrafficLane == null)
				{
					_inTrafficLane = (CBool) CR2WTypeManager.Create("Bool", "inTrafficLane", cr2w, this);
				}
				return _inTrafficLane;
			}
			set
			{
				if (_inTrafficLane == value)
				{
					return;
				}
				_inTrafficLane = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("timesSentReactionEvent")] 
		public CInt32 TimesSentReactionEvent
		{
			get
			{
				if (_timesSentReactionEvent == null)
				{
					_timesSentReactionEvent = (CInt32) CR2WTypeManager.Create("Int32", "timesSentReactionEvent", cr2w, this);
				}
				return _timesSentReactionEvent;
			}
			set
			{
				if (_timesSentReactionEvent == value)
				{
					return;
				}
				_timesSentReactionEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("vehicleUpsideDown")] 
		public CBool VehicleUpsideDown
		{
			get
			{
				if (_vehicleUpsideDown == null)
				{
					_vehicleUpsideDown = (CBool) CR2WTypeManager.Create("Bool", "vehicleUpsideDown", cr2w, this);
				}
				return _vehicleUpsideDown;
			}
			set
			{
				if (_vehicleUpsideDown == value)
				{
					return;
				}
				_vehicleUpsideDown = value;
				PropertySet(this);
			}
		}

		public vehicleBaseObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
