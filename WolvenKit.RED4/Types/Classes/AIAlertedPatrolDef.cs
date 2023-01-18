using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIAlertedPatrolDef : AIBlackboardDef
	{
		[Ordinal(0)] 
		[RED("patrolPathOverride")] 
		public gamebbScriptID_Variant PatrolPathOverride
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("sprint")] 
		public gamebbScriptID_Bool Sprint
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(2)] 
		[RED("selectedPath")] 
		public gamebbScriptID_Variant SelectedPath
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(3)] 
		[RED("closestPathPoint")] 
		public gamebbScriptID_Vector4 ClosestPathPoint
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("workspotData")] 
		public gamebbScriptID_Variant WorkspotData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(5)] 
		[RED("workspotEntryPosition")] 
		public gamebbScriptID_Vector4 WorkspotEntryPosition
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("workspotExitPosition")] 
		public gamebbScriptID_Vector4 WorkspotExitPosition
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(7)] 
		[RED("patrolAction")] 
		public gamebbScriptID_Variant PatrolAction
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(8)] 
		[RED("forceAlerted")] 
		public gamebbScriptID_Bool ForceAlerted
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(9)] 
		[RED("patrolInProgress")] 
		public gamebbScriptID_Bool PatrolInProgress
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public AIAlertedPatrolDef()
		{
			PatrolPathOverride = new();
			Sprint = new();
			SelectedPath = new();
			ClosestPathPoint = new();
			WorkspotData = new();
			WorkspotEntryPosition = new();
			WorkspotExitPosition = new();
			PatrolAction = new();
			ForceAlerted = new();
			PatrolInProgress = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
