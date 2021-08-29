using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatGadgetDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _throwUnequip;
		private gamebbScriptID_Float _lastThrowAngle;
		private gamebbScriptID_Vector4 _lastThrowPosition;
		private gamebbScriptID_Variant _lastThrowStartType;

		[Ordinal(0)] 
		[RED("throwUnequip")] 
		public gamebbScriptID_Bool ThrowUnequip
		{
			get => GetProperty(ref _throwUnequip);
			set => SetProperty(ref _throwUnequip, value);
		}

		[Ordinal(1)] 
		[RED("lastThrowAngle")] 
		public gamebbScriptID_Float LastThrowAngle
		{
			get => GetProperty(ref _lastThrowAngle);
			set => SetProperty(ref _lastThrowAngle, value);
		}

		[Ordinal(2)] 
		[RED("lastThrowPosition")] 
		public gamebbScriptID_Vector4 LastThrowPosition
		{
			get => GetProperty(ref _lastThrowPosition);
			set => SetProperty(ref _lastThrowPosition, value);
		}

		[Ordinal(3)] 
		[RED("lastThrowStartType")] 
		public gamebbScriptID_Variant LastThrowStartType
		{
			get => GetProperty(ref _lastThrowStartType);
			set => SetProperty(ref _lastThrowStartType, value);
		}
	}
}
