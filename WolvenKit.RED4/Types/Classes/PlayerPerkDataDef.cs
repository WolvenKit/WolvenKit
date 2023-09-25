using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerPerkDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("WoundedInstigated")] 
		public gamebbScriptID_Uint32 WoundedInstigated
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(1)] 
		[RED("DismembermentInstigated")] 
		public gamebbScriptID_Variant DismembermentInstigated
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("EntityNoticedPlayer")] 
		public gamebbScriptID_Uint32 EntityNoticedPlayer
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(3)] 
		[RED("CombatStateTime")] 
		public gamebbScriptID_Float CombatStateTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(4)] 
		[RED("LeapedDistance")] 
		public gamebbScriptID_Float LeapedDistance
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(5)] 
		[RED("LeapPosition")] 
		public gamebbScriptID_Vector4 LeapPosition
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("LeapTarget")] 
		public gamebbScriptID_EntityID LeapTarget
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		[Ordinal(7)] 
		[RED("UsedHealingItemOrCyberware")] 
		public gamebbScriptID_Uint32 UsedHealingItemOrCyberware
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(8)] 
		[RED("StartedUsingHealingItemOrCyberware")] 
		public gamebbScriptID_Uint32 StartedUsingHealingItemOrCyberware
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		public PlayerPerkDataDef()
		{
			WoundedInstigated = new gamebbScriptID_Uint32();
			DismembermentInstigated = new gamebbScriptID_Variant();
			EntityNoticedPlayer = new gamebbScriptID_Uint32();
			CombatStateTime = new gamebbScriptID_Float();
			LeapedDistance = new gamebbScriptID_Float();
			LeapPosition = new gamebbScriptID_Vector4();
			LeapTarget = new gamebbScriptID_EntityID();
			UsedHealingItemOrCyberware = new gamebbScriptID_Uint32();
			StartedUsingHealingItemOrCyberware = new gamebbScriptID_Uint32();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
