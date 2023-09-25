using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_TargetingInfoDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("CurrentVisibleTarget")] 
		public gamebbScriptID_EntityID CurrentVisibleTarget
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(1)] 
		[RED("CrosshairRaycastTarget")] 
		public gamebbScriptID_EntityID CrosshairRaycastTarget
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(2)] 
		[RED("VisibleTargetDistance")] 
		public gamebbScriptID_Float VisibleTargetDistance
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(3)] 
		[RED("VisibleTargetAttitude")] 
		public gamebbScriptID_Int32 VisibleTargetAttitude
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(4)] 
		[RED("CurrentObstructedTarget")] 
		public gamebbScriptID_EntityID CurrentObstructedTarget
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(5)] 
		[RED("ObstructedTargetDistance")] 
		public gamebbScriptID_Float ObstructedTargetDistance
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(6)] 
		[RED("ObstructedTargetAttitude")] 
		public gamebbScriptID_Int32 ObstructedTargetAttitude
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public UI_TargetingInfoDef()
		{
			CurrentVisibleTarget = new gamebbScriptID_EntityID();
			CrosshairRaycastTarget = new gamebbScriptID_EntityID();
			VisibleTargetDistance = new gamebbScriptID_Float();
			VisibleTargetAttitude = new gamebbScriptID_Int32();
			CurrentObstructedTarget = new gamebbScriptID_EntityID();
			ObstructedTargetDistance = new gamebbScriptID_Float();
			ObstructedTargetAttitude = new gamebbScriptID_Int32();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
