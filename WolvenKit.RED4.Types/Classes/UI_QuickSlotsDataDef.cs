using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_QuickSlotsDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("UIRadialContextRequest")] 
		public gamebbScriptID_Bool UIRadialContextRequest
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("UIRadialContextRightStickAngle")] 
		public gamebbScriptID_Float UIRadialContextRightStickAngle
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(2)] 
		[RED("leftStick")] 
		public gamebbScriptID_Vector4 LeftStick
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("DPadCommand")] 
		public gamebbScriptID_Variant DPadCommand
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(4)] 
		[RED("KeyboardCommand")] 
		public gamebbScriptID_Variant KeyboardCommand
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(5)] 
		[RED("WheelInteractionStarted")] 
		public gamebbScriptID_Variant WheelInteractionStarted
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(6)] 
		[RED("WheelInteractionEnded")] 
		public gamebbScriptID_Variant WheelInteractionEnded
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(7)] 
		[RED("CyberwareAssignmentComplete")] 
		public gamebbScriptID_Bool CyberwareAssignmentComplete
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(8)] 
		[RED("WheelAssignmentComplete")] 
		public gamebbScriptID_Bool WheelAssignmentComplete
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(9)] 
		[RED("quickSlotsStructure")] 
		public gamebbScriptID_Variant QuickSlotsStructure
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(10)] 
		[RED("activeQuickSlotItem")] 
		public gamebbScriptID_Variant ActiveQuickSlotItem
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(11)] 
		[RED("quickSlotsActiveWeaponIndex")] 
		public gamebbScriptID_Int32 QuickSlotsActiveWeaponIndex
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(12)] 
		[RED("quickhackPanelOpen")] 
		public gamebbScriptID_Bool QuickhackPanelOpen
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(13)] 
		[RED("quickHackDescritpionVisible")] 
		public gamebbScriptID_Bool QuickHackDescritpionVisible
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(14)] 
		[RED("quickHackDataSelected")] 
		public gamebbScriptID_Variant QuickHackDataSelected
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(15)] 
		[RED("dpadHintRefresh")] 
		public gamebbScriptID_Bool DpadHintRefresh
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(16)] 
		[RED("containerConsumable")] 
		public gamebbScriptID_Variant ContainerConsumable
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(17)] 
		[RED("consumableBeingUsed")] 
		public gamebbScriptID_Variant ConsumableBeingUsed
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_QuickSlotsDataDef()
		{
			UIRadialContextRequest = new();
			UIRadialContextRightStickAngle = new();
			LeftStick = new();
			DPadCommand = new();
			KeyboardCommand = new();
			WheelInteractionStarted = new();
			WheelInteractionEnded = new();
			CyberwareAssignmentComplete = new();
			WheelAssignmentComplete = new();
			QuickSlotsStructure = new();
			ActiveQuickSlotItem = new();
			QuickSlotsActiveWeaponIndex = new();
			QuickhackPanelOpen = new();
			QuickHackDescritpionVisible = new();
			QuickHackDataSelected = new();
			DpadHintRefresh = new();
			ContainerConsumable = new();
			ConsumableBeingUsed = new();
		}
	}
}
