using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class ScriptableDeviceAction : BaseScriptableAction
	{
		[Ordinal(22)] 
		[RED("prop")] 
		public CHandle<gamedeviceActionProperty> Prop
		{
			get => GetPropertyValue<CHandle<gamedeviceActionProperty>>();
			set => SetPropertyValue<CHandle<gamedeviceActionProperty>>(value);
		}

		[Ordinal(23)] 
		[RED("actionWidgetPackage")] 
		public SActionWidgetPackage ActionWidgetPackage
		{
			get => GetPropertyValue<SActionWidgetPackage>();
			set => SetPropertyValue<SActionWidgetPackage>(value);
		}

		[Ordinal(24)] 
		[RED("spiderbotActionLocationOverride")] 
		public NodeRef SpiderbotActionLocationOverride
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(25)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("canTriggerStim")] 
		public CBool CanTriggerStim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("wasPerformedOnOwner")] 
		public CBool WasPerformedOnOwner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("shouldActivateDevice")] 
		public CBool ShouldActivateDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("disableSpread")] 
		public CBool DisableSpread
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("isQuickHack")] 
		public CBool IsQuickHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("isSpiderbotAction")] 
		public CBool IsSpiderbotAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("attachedProgram")] 
		public TweakDBID AttachedProgram
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(33)] 
		[RED("activeStatusEffect")] 
		public TweakDBID ActiveStatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(34)] 
		[RED("interactionIconType")] 
		public TweakDBID InteractionIconType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(35)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("inactiveReason")] 
		public CString InactiveReason
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(37)] 
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
