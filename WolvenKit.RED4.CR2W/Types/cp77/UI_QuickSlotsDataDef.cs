using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_QuickSlotsDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _uIRadialContextRequest;
		private gamebbScriptID_Float _uIRadialContextRightStickAngle;
		private gamebbScriptID_Vector4 _leftStick;
		private gamebbScriptID_Variant _dPadCommand;
		private gamebbScriptID_Variant _keyboardCommand;
		private gamebbScriptID_Variant _wheelInteractionStarted;
		private gamebbScriptID_Variant _wheelInteractionEnded;
		private gamebbScriptID_Bool _cyberwareAssignmentComplete;
		private gamebbScriptID_Bool _wheelAssignmentComplete;
		private gamebbScriptID_Variant _quickSlotsStructure;
		private gamebbScriptID_Variant _activeQuickSlotItem;
		private gamebbScriptID_Int32 _quickSlotsActiveWeaponIndex;
		private gamebbScriptID_Bool _quickhackPanelOpen;
		private gamebbScriptID_Bool _quickHackDescritpionVisible;
		private gamebbScriptID_Variant _quickHackDataSelected;
		private gamebbScriptID_Bool _dpadHintRefresh;
		private gamebbScriptID_Variant _containerConsumable;
		private gamebbScriptID_Variant _consumableBeingUsed;

		[Ordinal(0)] 
		[RED("UIRadialContextRequest")] 
		public gamebbScriptID_Bool UIRadialContextRequest
		{
			get => GetProperty(ref _uIRadialContextRequest);
			set => SetProperty(ref _uIRadialContextRequest, value);
		}

		[Ordinal(1)] 
		[RED("UIRadialContextRightStickAngle")] 
		public gamebbScriptID_Float UIRadialContextRightStickAngle
		{
			get => GetProperty(ref _uIRadialContextRightStickAngle);
			set => SetProperty(ref _uIRadialContextRightStickAngle, value);
		}

		[Ordinal(2)] 
		[RED("leftStick")] 
		public gamebbScriptID_Vector4 LeftStick
		{
			get => GetProperty(ref _leftStick);
			set => SetProperty(ref _leftStick, value);
		}

		[Ordinal(3)] 
		[RED("DPadCommand")] 
		public gamebbScriptID_Variant DPadCommand
		{
			get => GetProperty(ref _dPadCommand);
			set => SetProperty(ref _dPadCommand, value);
		}

		[Ordinal(4)] 
		[RED("KeyboardCommand")] 
		public gamebbScriptID_Variant KeyboardCommand
		{
			get => GetProperty(ref _keyboardCommand);
			set => SetProperty(ref _keyboardCommand, value);
		}

		[Ordinal(5)] 
		[RED("WheelInteractionStarted")] 
		public gamebbScriptID_Variant WheelInteractionStarted
		{
			get => GetProperty(ref _wheelInteractionStarted);
			set => SetProperty(ref _wheelInteractionStarted, value);
		}

		[Ordinal(6)] 
		[RED("WheelInteractionEnded")] 
		public gamebbScriptID_Variant WheelInteractionEnded
		{
			get => GetProperty(ref _wheelInteractionEnded);
			set => SetProperty(ref _wheelInteractionEnded, value);
		}

		[Ordinal(7)] 
		[RED("CyberwareAssignmentComplete")] 
		public gamebbScriptID_Bool CyberwareAssignmentComplete
		{
			get => GetProperty(ref _cyberwareAssignmentComplete);
			set => SetProperty(ref _cyberwareAssignmentComplete, value);
		}

		[Ordinal(8)] 
		[RED("WheelAssignmentComplete")] 
		public gamebbScriptID_Bool WheelAssignmentComplete
		{
			get => GetProperty(ref _wheelAssignmentComplete);
			set => SetProperty(ref _wheelAssignmentComplete, value);
		}

		[Ordinal(9)] 
		[RED("quickSlotsStructure")] 
		public gamebbScriptID_Variant QuickSlotsStructure
		{
			get => GetProperty(ref _quickSlotsStructure);
			set => SetProperty(ref _quickSlotsStructure, value);
		}

		[Ordinal(10)] 
		[RED("activeQuickSlotItem")] 
		public gamebbScriptID_Variant ActiveQuickSlotItem
		{
			get => GetProperty(ref _activeQuickSlotItem);
			set => SetProperty(ref _activeQuickSlotItem, value);
		}

		[Ordinal(11)] 
		[RED("quickSlotsActiveWeaponIndex")] 
		public gamebbScriptID_Int32 QuickSlotsActiveWeaponIndex
		{
			get => GetProperty(ref _quickSlotsActiveWeaponIndex);
			set => SetProperty(ref _quickSlotsActiveWeaponIndex, value);
		}

		[Ordinal(12)] 
		[RED("quickhackPanelOpen")] 
		public gamebbScriptID_Bool QuickhackPanelOpen
		{
			get => GetProperty(ref _quickhackPanelOpen);
			set => SetProperty(ref _quickhackPanelOpen, value);
		}

		[Ordinal(13)] 
		[RED("quickHackDescritpionVisible")] 
		public gamebbScriptID_Bool QuickHackDescritpionVisible
		{
			get => GetProperty(ref _quickHackDescritpionVisible);
			set => SetProperty(ref _quickHackDescritpionVisible, value);
		}

		[Ordinal(14)] 
		[RED("quickHackDataSelected")] 
		public gamebbScriptID_Variant QuickHackDataSelected
		{
			get => GetProperty(ref _quickHackDataSelected);
			set => SetProperty(ref _quickHackDataSelected, value);
		}

		[Ordinal(15)] 
		[RED("dpadHintRefresh")] 
		public gamebbScriptID_Bool DpadHintRefresh
		{
			get => GetProperty(ref _dpadHintRefresh);
			set => SetProperty(ref _dpadHintRefresh, value);
		}

		[Ordinal(16)] 
		[RED("containerConsumable")] 
		public gamebbScriptID_Variant ContainerConsumable
		{
			get => GetProperty(ref _containerConsumable);
			set => SetProperty(ref _containerConsumable, value);
		}

		[Ordinal(17)] 
		[RED("consumableBeingUsed")] 
		public gamebbScriptID_Variant ConsumableBeingUsed
		{
			get => GetProperty(ref _consumableBeingUsed);
			set => SetProperty(ref _consumableBeingUsed, value);
		}

		public UI_QuickSlotsDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
