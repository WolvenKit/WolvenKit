using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CombatGadgetDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("throwUnequip")] 
		public gamebbScriptID_Bool ThrowUnequip
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("lastThrowAngle")] 
		public gamebbScriptID_Float LastThrowAngle
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(2)] 
		[RED("lastThrowPosition")] 
		public gamebbScriptID_Vector4 LastThrowPosition
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("lastThrowStartType")] 
		public gamebbScriptID_Variant LastThrowStartType
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public CombatGadgetDataDef()
		{
			ThrowUnequip = new();
			LastThrowAngle = new();
			LastThrowPosition = new();
			LastThrowStartType = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
