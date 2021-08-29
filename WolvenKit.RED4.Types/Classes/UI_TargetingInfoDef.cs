using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_TargetingInfoDef : gamebbScriptDefinition
	{
		private gamebbScriptID_EntityID _currentVisibleTarget;
		private gamebbScriptID_Float _visibleTargetDistance;
		private gamebbScriptID_Int32 _visibleTargetAttitude;
		private gamebbScriptID_EntityID _currentObstructedTarget;
		private gamebbScriptID_Float _obstructedTargetDistance;
		private gamebbScriptID_Int32 _obstructedTargetAttitude;

		[Ordinal(0)] 
		[RED("CurrentVisibleTarget")] 
		public gamebbScriptID_EntityID CurrentVisibleTarget
		{
			get => GetProperty(ref _currentVisibleTarget);
			set => SetProperty(ref _currentVisibleTarget, value);
		}

		[Ordinal(1)] 
		[RED("VisibleTargetDistance")] 
		public gamebbScriptID_Float VisibleTargetDistance
		{
			get => GetProperty(ref _visibleTargetDistance);
			set => SetProperty(ref _visibleTargetDistance, value);
		}

		[Ordinal(2)] 
		[RED("VisibleTargetAttitude")] 
		public gamebbScriptID_Int32 VisibleTargetAttitude
		{
			get => GetProperty(ref _visibleTargetAttitude);
			set => SetProperty(ref _visibleTargetAttitude, value);
		}

		[Ordinal(3)] 
		[RED("CurrentObstructedTarget")] 
		public gamebbScriptID_EntityID CurrentObstructedTarget
		{
			get => GetProperty(ref _currentObstructedTarget);
			set => SetProperty(ref _currentObstructedTarget, value);
		}

		[Ordinal(4)] 
		[RED("ObstructedTargetDistance")] 
		public gamebbScriptID_Float ObstructedTargetDistance
		{
			get => GetProperty(ref _obstructedTargetDistance);
			set => SetProperty(ref _obstructedTargetDistance, value);
		}

		[Ordinal(5)] 
		[RED("ObstructedTargetAttitude")] 
		public gamebbScriptID_Int32 ObstructedTargetAttitude
		{
			get => GetProperty(ref _obstructedTargetAttitude);
			set => SetProperty(ref _obstructedTargetAttitude, value);
		}
	}
}
