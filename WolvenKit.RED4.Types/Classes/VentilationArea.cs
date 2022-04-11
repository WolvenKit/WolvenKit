using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VentilationArea : InteractiveMasterDevice
	{
		[Ordinal(94)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(95)] 
		[RED("RestartGameEffectOnAttach")] 
		public CBool RestartGameEffectOnAttach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(96)] 
		[RED("AttackRecord")] 
		public CString AttackRecord
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(97)] 
		[RED("gameEffectRef")] 
		public gameEffectRef GameEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(98)] 
		[RED("gameEffect")] 
		public CHandle<gameEffectInstance> GameEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(99)] 
		[RED("highLightActive")] 
		public CBool HighLightActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VentilationArea()
		{
			ControllerTypeName = "VentilationAreaController";
			AttackRecord = "Attacks.FragGrenade";
			GameEffectRef = new();
		}
	}
}
