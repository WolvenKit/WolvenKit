using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTopThreatToCombatTarget : AIbehaviortaskScript
	{
		private CFloat _refreshTimer;
		private CFloat _previousChecktime;
		private CHandle<TargetTrackingExtension> _targetTrackerComponent;
		private CHandle<movePoliciesComponent> _movePoliciesComponent;
		private CFloat _targetChangeTime;

		[Ordinal(0)] 
		[RED("refreshTimer")] 
		public CFloat RefreshTimer
		{
			get
			{
				if (_refreshTimer == null)
				{
					_refreshTimer = (CFloat) CR2WTypeManager.Create("Float", "refreshTimer", cr2w, this);
				}
				return _refreshTimer;
			}
			set
			{
				if (_refreshTimer == value)
				{
					return;
				}
				_refreshTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("previousChecktime")] 
		public CFloat PreviousChecktime
		{
			get
			{
				if (_previousChecktime == null)
				{
					_previousChecktime = (CFloat) CR2WTypeManager.Create("Float", "previousChecktime", cr2w, this);
				}
				return _previousChecktime;
			}
			set
			{
				if (_previousChecktime == value)
				{
					return;
				}
				_previousChecktime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetTrackerComponent")] 
		public CHandle<TargetTrackingExtension> TargetTrackerComponent
		{
			get
			{
				if (_targetTrackerComponent == null)
				{
					_targetTrackerComponent = (CHandle<TargetTrackingExtension>) CR2WTypeManager.Create("handle:TargetTrackingExtension", "targetTrackerComponent", cr2w, this);
				}
				return _targetTrackerComponent;
			}
			set
			{
				if (_targetTrackerComponent == value)
				{
					return;
				}
				_targetTrackerComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("movePoliciesComponent")] 
		public CHandle<movePoliciesComponent> MovePoliciesComponent
		{
			get
			{
				if (_movePoliciesComponent == null)
				{
					_movePoliciesComponent = (CHandle<movePoliciesComponent>) CR2WTypeManager.Create("handle:movePoliciesComponent", "movePoliciesComponent", cr2w, this);
				}
				return _movePoliciesComponent;
			}
			set
			{
				if (_movePoliciesComponent == value)
				{
					return;
				}
				_movePoliciesComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("targetChangeTime")] 
		public CFloat TargetChangeTime
		{
			get
			{
				if (_targetChangeTime == null)
				{
					_targetChangeTime = (CFloat) CR2WTypeManager.Create("Float", "targetChangeTime", cr2w, this);
				}
				return _targetChangeTime;
			}
			set
			{
				if (_targetChangeTime == value)
				{
					return;
				}
				_targetChangeTime = value;
				PropertySet(this);
			}
		}

		public SetTopThreatToCombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
