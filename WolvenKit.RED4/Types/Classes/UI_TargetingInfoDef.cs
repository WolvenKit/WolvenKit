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
		[RED("VisibleTargetDistance")] 
		public gamebbScriptID_Float VisibleTargetDistance
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(2)] 
		[RED("VisibleTargetAttitude")] 
		public gamebbScriptID_Int32 VisibleTargetAttitude
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(3)] 
		[RED("CurrentObstructedTarget")] 
		public gamebbScriptID_EntityID CurrentObstructedTarget
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(4)] 
		[RED("ObstructedTargetDistance")] 
		public gamebbScriptID_Float ObstructedTargetDistance
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(5)] 
		[RED("ObstructedTargetAttitude")] 
		public gamebbScriptID_Int32 ObstructedTargetAttitude
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public UI_TargetingInfoDef()
		{
			CurrentVisibleTarget = new();
			VisibleTargetDistance = new();
			VisibleTargetAttitude = new();
			CurrentObstructedTarget = new();
			ObstructedTargetDistance = new();
			ObstructedTargetAttitude = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
