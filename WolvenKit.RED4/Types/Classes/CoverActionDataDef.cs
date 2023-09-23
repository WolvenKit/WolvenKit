using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CoverActionDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("coverActionStateId")] 
		public gamebbScriptID_Int32 CoverActionStateId
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("playerNearValidEdge")] 
		public gamebbScriptID_Bool PlayerNearValidEdge
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(2)] 
		[RED("debugLeaning")] 
		public gamebbScriptID_Bool DebugLeaning
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("debugAutoLeaning")] 
		public gamebbScriptID_Bool DebugAutoLeaning
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(4)] 
		[RED("debugDpadLeaning")] 
		public gamebbScriptID_Bool DebugDpadLeaning
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(5)] 
		[RED("debugLsLeaning")] 
		public gamebbScriptID_Bool DebugLsLeaning
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(6)] 
		[RED("debugStagesLeaning")] 
		public gamebbScriptID_Bool DebugStagesLeaning
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(7)] 
		[RED("debugAdsLeaning")] 
		public gamebbScriptID_Bool DebugAdsLeaning
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public CoverActionDataDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
