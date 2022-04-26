using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlayVoiceset_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("voicesetName")] 
		public CName VoicesetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("useVoicesetSystem")] 
		public CBool UseVoicesetSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("playOnlyGrunt")] 
		public CBool PlayOnlyGrunt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("overridingVoiceoverContext")] 
		public CEnum<locVoiceoverContext> OverridingVoiceoverContext
		{
			get => GetPropertyValue<CEnum<locVoiceoverContext>>();
			set => SetPropertyValue<CEnum<locVoiceoverContext>>(value);
		}

		[Ordinal(6)] 
		[RED("overrideVoiceoverExpression")] 
		public CBool OverrideVoiceoverExpression
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("overridingVoiceoverExpression")] 
		public CEnum<locVoiceoverExpression> OverridingVoiceoverExpression
		{
			get => GetPropertyValue<CEnum<locVoiceoverExpression>>();
			set => SetPropertyValue<CEnum<locVoiceoverExpression>>(value);
		}

		[Ordinal(8)] 
		[RED("overrideVisualStyle")] 
		public CBool OverrideVisualStyle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("overridingVisualStyle")] 
		public CEnum<scnDialogLineVisualStyle> OverridingVisualStyle
		{
			get => GetPropertyValue<CEnum<scnDialogLineVisualStyle>>();
			set => SetPropertyValue<CEnum<scnDialogLineVisualStyle>>(value);
		}

		public questPlayVoiceset_NodeTypeParams()
		{
			PuppetRef = new() { Names = new() };
			OverridingVoiceoverContext = Enums.locVoiceoverContext.Default_Vo_Context;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
