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
			get => GetProperty(ref _refreshTimer);
			set => SetProperty(ref _refreshTimer, value);
		}

		[Ordinal(1)] 
		[RED("previousChecktime")] 
		public CFloat PreviousChecktime
		{
			get => GetProperty(ref _previousChecktime);
			set => SetProperty(ref _previousChecktime, value);
		}

		[Ordinal(2)] 
		[RED("targetTrackerComponent")] 
		public CHandle<TargetTrackingExtension> TargetTrackerComponent
		{
			get => GetProperty(ref _targetTrackerComponent);
			set => SetProperty(ref _targetTrackerComponent, value);
		}

		[Ordinal(3)] 
		[RED("movePoliciesComponent")] 
		public CHandle<movePoliciesComponent> MovePoliciesComponent
		{
			get => GetProperty(ref _movePoliciesComponent);
			set => SetProperty(ref _movePoliciesComponent, value);
		}

		[Ordinal(4)] 
		[RED("targetChangeTime")] 
		public CFloat TargetChangeTime
		{
			get => GetProperty(ref _targetChangeTime);
			set => SetProperty(ref _targetChangeTime, value);
		}

		public SetTopThreatToCombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
