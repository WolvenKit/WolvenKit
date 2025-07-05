using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class ScriptableDeviceAction : BaseScriptableAction
	{
		[Ordinal(23)] 
		[RED("prop")] 
		public CHandle<gamedeviceActionProperty> Prop
		{
			get => GetPropertyValue<CHandle<gamedeviceActionProperty>>();
			set => SetPropertyValue<CHandle<gamedeviceActionProperty>>(value);
		}

		[Ordinal(24)] 
		[RED("actionWidgetPackage")] 
		public SActionWidgetPackage ActionWidgetPackage
		{
			get => GetPropertyValue<SActionWidgetPackage>();
			set => SetPropertyValue<SActionWidgetPackage>(value);
		}

		[Ordinal(25)] 
		[RED("spiderbotActionLocationOverride")] 
		public NodeRef SpiderbotActionLocationOverride
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(26)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("canTriggerStim")] 
		public CBool CanTriggerStim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("wasPerformedOnOwner")] 
		public CBool WasPerformedOnOwner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("shouldActivateDevice")] 
		public CBool ShouldActivateDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("disableSpread")] 
		public CBool DisableSpread
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("isQuickHack")] 
		public CBool IsQuickHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("isSpiderbotAction")] 
		public CBool IsSpiderbotAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("attachedProgram")] 
		public TweakDBID AttachedProgram
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(34)] 
		[RED("activeStatusEffect")] 
		public TweakDBID ActiveStatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(35)] 
		[RED("interactionIconType")] 
		public TweakDBID InteractionIconType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(36)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("inactiveReason")] 
		public CString InactiveReason
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(38)] 
		[RED("widgetStyle")] 
		public CEnum<gamedataComputerUIStyle> WidgetStyle
		{
			get => GetPropertyValue<CEnum<gamedataComputerUIStyle>>();
			set => SetPropertyValue<CEnum<gamedataComputerUIStyle>>(value);
		}

		public ScriptableDeviceAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
