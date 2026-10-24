using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SubtitleLineLogicController : BaseSubtitleLineLogicController
	{
		[Ordinal(7)] 
		[RED("speakerNameWidget")] 
		public inkTextWidgetReference SpeakerNameWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("radioSpeaker")] 
		public inkTextWidgetReference RadioSpeaker
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("backgroundSpeaker")] 
		public inkWidgetReference BackgroundSpeaker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("kiroshiAnimationContainer")] 
		public inkWidgetReference KiroshiAnimationContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("motherTongueContainter")] 
		public inkWidgetReference MotherTongueContainter
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("targetTextWidgetRef")] 
		public inkTextWidgetReference TargetTextWidgetRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("lineData")] 
		public scnDialogLineData LineData
		{
			get => GetPropertyValue<scnDialogLineData>();
			set => SetPropertyValue<scnDialogLineData>(value);
		}

		[Ordinal(15)] 
		[RED("spekerNameParams")] 
		public CHandle<textTextParameterSet> SpekerNameParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		public SubtitleLineLogicController()
		{
			SpeakerNameWidget = new inkTextWidgetReference();
			RadioSpeaker = new inkTextWidgetReference();
			Background = new inkWidgetReference();
			BackgroundSpeaker = new inkWidgetReference();
			KiroshiAnimationContainer = new inkWidgetReference();
			MotherTongueContainter = new inkWidgetReference();
			TargetTextWidgetRef = new inkTextWidgetReference();
			LineData = new scnDialogLineData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
