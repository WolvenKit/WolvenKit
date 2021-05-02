using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIPatrolDef : AIBlackboardDef
	{
		private gamebbScriptID_Variant _patrolPathOverride;
		private gamebbScriptID_Bool _patrolWithWeapon;
		private gamebbScriptID_Bool _forceAlerted;
		private gamebbScriptID_Bool _sprint;
		private gamebbScriptID_Variant _selectedPath;
		private gamebbScriptID_Vector4 _closestPathPoint;
		private gamebbScriptID_Variant _workspotData;
		private gamebbScriptID_Vector4 _workspotEntryPosition;
		private gamebbScriptID_Vector4 _workspotExitPosition;
		private gamebbScriptID_Variant _patrolAction;
		private gamebbScriptID_Bool _patrolInProgress;

		[Ordinal(0)] 
		[RED("patrolPathOverride")] 
		public gamebbScriptID_Variant PatrolPathOverride
		{
			get => GetProperty(ref _patrolPathOverride);
			set => SetProperty(ref _patrolPathOverride, value);
		}

		[Ordinal(1)] 
		[RED("patrolWithWeapon")] 
		public gamebbScriptID_Bool PatrolWithWeapon
		{
			get => GetProperty(ref _patrolWithWeapon);
			set => SetProperty(ref _patrolWithWeapon, value);
		}

		[Ordinal(2)] 
		[RED("forceAlerted")] 
		public gamebbScriptID_Bool ForceAlerted
		{
			get => GetProperty(ref _forceAlerted);
			set => SetProperty(ref _forceAlerted, value);
		}

		[Ordinal(3)] 
		[RED("sprint")] 
		public gamebbScriptID_Bool Sprint
		{
			get => GetProperty(ref _sprint);
			set => SetProperty(ref _sprint, value);
		}

		[Ordinal(4)] 
		[RED("selectedPath")] 
		public gamebbScriptID_Variant SelectedPath
		{
			get => GetProperty(ref _selectedPath);
			set => SetProperty(ref _selectedPath, value);
		}

		[Ordinal(5)] 
		[RED("closestPathPoint")] 
		public gamebbScriptID_Vector4 ClosestPathPoint
		{
			get => GetProperty(ref _closestPathPoint);
			set => SetProperty(ref _closestPathPoint, value);
		}

		[Ordinal(6)] 
		[RED("workspotData")] 
		public gamebbScriptID_Variant WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		[Ordinal(7)] 
		[RED("workspotEntryPosition")] 
		public gamebbScriptID_Vector4 WorkspotEntryPosition
		{
			get => GetProperty(ref _workspotEntryPosition);
			set => SetProperty(ref _workspotEntryPosition, value);
		}

		[Ordinal(8)] 
		[RED("workspotExitPosition")] 
		public gamebbScriptID_Vector4 WorkspotExitPosition
		{
			get => GetProperty(ref _workspotExitPosition);
			set => SetProperty(ref _workspotExitPosition, value);
		}

		[Ordinal(9)] 
		[RED("patrolAction")] 
		public gamebbScriptID_Variant PatrolAction
		{
			get => GetProperty(ref _patrolAction);
			set => SetProperty(ref _patrolAction, value);
		}

		[Ordinal(10)] 
		[RED("patrolInProgress")] 
		public gamebbScriptID_Bool PatrolInProgress
		{
			get => GetProperty(ref _patrolInProgress);
			set => SetProperty(ref _patrolInProgress, value);
		}

		public AIPatrolDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
