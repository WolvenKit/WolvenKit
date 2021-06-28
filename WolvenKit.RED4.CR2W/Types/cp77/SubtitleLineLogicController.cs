using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SubtitleLineLogicController : BaseSubtitleLineLogicController
	{
		private inkTextWidgetReference _speakerNameWidget;
		private inkTextWidgetReference _subtitleWidget;
		private inkTextWidgetReference _radioSpeaker;
		private inkTextWidgetReference _radioSubtitle;
		private inkWidgetReference _background;
		private inkWidgetReference _backgroundSpeaker;
		private inkWidgetReference _kiroshiAnimationContainer;
		private inkWidgetReference _motherTongueContainter;
		private inkTextWidgetReference _targetTextWidgetRef;
		private scnDialogLineData _lineData;

		[Ordinal(5)] 
		[RED("speakerNameWidget")] 
		public inkTextWidgetReference SpeakerNameWidget
		{
			get => GetProperty(ref _speakerNameWidget);
			set => SetProperty(ref _speakerNameWidget, value);
		}

		[Ordinal(6)] 
		[RED("subtitleWidget")] 
		public inkTextWidgetReference SubtitleWidget
		{
			get => GetProperty(ref _subtitleWidget);
			set => SetProperty(ref _subtitleWidget, value);
		}

		[Ordinal(7)] 
		[RED("radioSpeaker")] 
		public inkTextWidgetReference RadioSpeaker
		{
			get => GetProperty(ref _radioSpeaker);
			set => SetProperty(ref _radioSpeaker, value);
		}

		[Ordinal(8)] 
		[RED("radioSubtitle")] 
		public inkTextWidgetReference RadioSubtitle
		{
			get => GetProperty(ref _radioSubtitle);
			set => SetProperty(ref _radioSubtitle, value);
		}

		[Ordinal(9)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(10)] 
		[RED("backgroundSpeaker")] 
		public inkWidgetReference BackgroundSpeaker
		{
			get => GetProperty(ref _backgroundSpeaker);
			set => SetProperty(ref _backgroundSpeaker, value);
		}

		[Ordinal(11)] 
		[RED("kiroshiAnimationContainer")] 
		public inkWidgetReference KiroshiAnimationContainer
		{
			get => GetProperty(ref _kiroshiAnimationContainer);
			set => SetProperty(ref _kiroshiAnimationContainer, value);
		}

		[Ordinal(12)] 
		[RED("motherTongueContainter")] 
		public inkWidgetReference MotherTongueContainter
		{
			get => GetProperty(ref _motherTongueContainter);
			set => SetProperty(ref _motherTongueContainter, value);
		}

		[Ordinal(13)] 
		[RED("targetTextWidgetRef")] 
		public inkTextWidgetReference TargetTextWidgetRef
		{
			get => GetProperty(ref _targetTextWidgetRef);
			set => SetProperty(ref _targetTextWidgetRef, value);
		}

		[Ordinal(14)] 
		[RED("lineData")] 
		public scnDialogLineData LineData
		{
			get => GetProperty(ref _lineData);
			set => SetProperty(ref _lineData, value);
		}

		public SubtitleLineLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
