using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPlayVoiceset_NodeTypeParams : RedBaseClass
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CName _voicesetName;
		private CBool _useVoicesetSystem;
		private CBool _playOnlyGrunt;
		private CEnum<locVoiceoverContext> _overridingVoiceoverContext;
		private CBool _overrideVoiceoverExpression;
		private CEnum<locVoiceoverExpression> _overridingVoiceoverExpression;
		private CBool _overrideVisualStyle;
		private CEnum<scnDialogLineVisualStyle> _overridingVisualStyle;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("voicesetName")] 
		public CName VoicesetName
		{
			get => GetProperty(ref _voicesetName);
			set => SetProperty(ref _voicesetName, value);
		}

		[Ordinal(3)] 
		[RED("useVoicesetSystem")] 
		public CBool UseVoicesetSystem
		{
			get => GetProperty(ref _useVoicesetSystem);
			set => SetProperty(ref _useVoicesetSystem, value);
		}

		[Ordinal(4)] 
		[RED("playOnlyGrunt")] 
		public CBool PlayOnlyGrunt
		{
			get => GetProperty(ref _playOnlyGrunt);
			set => SetProperty(ref _playOnlyGrunt, value);
		}

		[Ordinal(5)] 
		[RED("overridingVoiceoverContext")] 
		public CEnum<locVoiceoverContext> OverridingVoiceoverContext
		{
			get => GetProperty(ref _overridingVoiceoverContext);
			set => SetProperty(ref _overridingVoiceoverContext, value);
		}

		[Ordinal(6)] 
		[RED("overrideVoiceoverExpression")] 
		public CBool OverrideVoiceoverExpression
		{
			get => GetProperty(ref _overrideVoiceoverExpression);
			set => SetProperty(ref _overrideVoiceoverExpression, value);
		}

		[Ordinal(7)] 
		[RED("overridingVoiceoverExpression")] 
		public CEnum<locVoiceoverExpression> OverridingVoiceoverExpression
		{
			get => GetProperty(ref _overridingVoiceoverExpression);
			set => SetProperty(ref _overridingVoiceoverExpression, value);
		}

		[Ordinal(8)] 
		[RED("overrideVisualStyle")] 
		public CBool OverrideVisualStyle
		{
			get => GetProperty(ref _overrideVisualStyle);
			set => SetProperty(ref _overrideVisualStyle, value);
		}

		[Ordinal(9)] 
		[RED("overridingVisualStyle")] 
		public CEnum<scnDialogLineVisualStyle> OverridingVisualStyle
		{
			get => GetProperty(ref _overridingVisualStyle);
			set => SetProperty(ref _overridingVisualStyle, value);
		}

		public questPlayVoiceset_NodeTypeParams()
		{
			_overridingVoiceoverContext = new() { Value = Enums.locVoiceoverContext.Default_Vo_Context };
		}
	}
}
