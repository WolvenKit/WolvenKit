using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIPatrolDef : AIBlackboardDef
	{
		[Ordinal(0)] 
		[RED("patrolPathOverride")] 
		public gamebbScriptID_Variant PatrolPathOverride
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("patrolWithWeapon")] 
		public gamebbScriptID_Bool PatrolWithWeapon
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(2)] 
		[RED("forceAlerted")] 
		public gamebbScriptID_Bool ForceAlerted
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("sprint")] 
		public gamebbScriptID_Bool Sprint
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(4)] 
		[RED("selectedPath")] 
		public gamebbScriptID_Variant SelectedPath
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(5)] 
		[RED("closestPathPoint")] 
		public gamebbScriptID_Vector4 ClosestPathPoint
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("workspotData")] 
		public gamebbScriptID_Variant WorkspotData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(7)] 
		[RED("workspotEntryPosition")] 
		public gamebbScriptID_Vector4 WorkspotEntryPosition
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(8)] 
		[RED("workspotExitPosition")] 
		public gamebbScriptID_Vector4 WorkspotExitPosition
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(9)] 
		[RED("patrolAction")] 
		public gamebbScriptID_Variant PatrolAction
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(10)] 
		[RED("patrolInProgress")] 
		public gamebbScriptID_Bool PatrolInProgress
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public AIPatrolDef()
		{
			PatrolPathOverride = new gamebbScriptID_Variant();
			PatrolWithWeapon = new gamebbScriptID_Bool();
			ForceAlerted = new gamebbScriptID_Bool();
			Sprint = new gamebbScriptID_Bool();
			SelectedPath = new gamebbScriptID_Variant();
			ClosestPathPoint = new gamebbScriptID_Vector4();
			WorkspotData = new gamebbScriptID_Variant();
			WorkspotEntryPosition = new gamebbScriptID_Vector4();
			WorkspotExitPosition = new gamebbScriptID_Vector4();
			PatrolAction = new gamebbScriptID_Variant();
			PatrolInProgress = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
