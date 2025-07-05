using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDeviceActionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("hasUI")] 
		public CBool HasUI
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isQuickHack")] 
		public CBool IsQuickHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isSpiderbotAction")] 
		public CBool IsSpiderbotAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("spiderbotLocationOverrideReference")] 
		public NodeRef SpiderbotLocationOverrideReference
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(5)] 
		[RED("attachedToSkillCheck")] 
		public CEnum<EDeviceChallengeSkill> AttachedToSkillCheck
		{
			get => GetPropertyValue<CEnum<EDeviceChallengeSkill>>();
			set => SetPropertyValue<CEnum<EDeviceChallengeSkill>>(value);
		}

		[Ordinal(6)] 
		[RED("widgetRecord")] 
		public TweakDBID WidgetRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(7)] 
		[RED("objectActionRecord")] 
		public TweakDBID ObjectActionRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(8)] 
		[RED("currentDisplayName")] 
		public CName CurrentDisplayName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("interactionRecord")] 
		public CString InteractionRecord
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public SDeviceActionData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
