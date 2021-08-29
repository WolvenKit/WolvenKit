using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MetaQuestLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _metaQuestHint;
		private inkTextWidgetReference _metaQuestHintText;
		private inkWidgetReference _metaQuest1;
		private inkWidgetReference _metaQuest2;
		private inkWidgetReference _metaQuest3;
		private inkTextWidgetReference _metaQuest1Value;
		private inkTextWidgetReference _metaQuest2Value;
		private inkTextWidgetReference _metaQuest3Value;
		private CString _metaQuest1Description;
		private CString _metaQuest2Description;
		private CString _metaQuest3Description;
		private CHandle<inkanimProxy> _animMeta1;
		private CHandle<inkanimProxy> _animMeta2;
		private CHandle<inkanimProxy> _animMeta3;
		private CHandle<inkanimProxy> _animTooltip;

		[Ordinal(1)] 
		[RED("MetaQuestHint")] 
		public inkWidgetReference MetaQuestHint
		{
			get => GetProperty(ref _metaQuestHint);
			set => SetProperty(ref _metaQuestHint, value);
		}

		[Ordinal(2)] 
		[RED("MetaQuestHintText")] 
		public inkTextWidgetReference MetaQuestHintText
		{
			get => GetProperty(ref _metaQuestHintText);
			set => SetProperty(ref _metaQuestHintText, value);
		}

		[Ordinal(3)] 
		[RED("MetaQuest1")] 
		public inkWidgetReference MetaQuest1
		{
			get => GetProperty(ref _metaQuest1);
			set => SetProperty(ref _metaQuest1, value);
		}

		[Ordinal(4)] 
		[RED("MetaQuest2")] 
		public inkWidgetReference MetaQuest2
		{
			get => GetProperty(ref _metaQuest2);
			set => SetProperty(ref _metaQuest2, value);
		}

		[Ordinal(5)] 
		[RED("MetaQuest3")] 
		public inkWidgetReference MetaQuest3
		{
			get => GetProperty(ref _metaQuest3);
			set => SetProperty(ref _metaQuest3, value);
		}

		[Ordinal(6)] 
		[RED("MetaQuest1Value")] 
		public inkTextWidgetReference MetaQuest1Value
		{
			get => GetProperty(ref _metaQuest1Value);
			set => SetProperty(ref _metaQuest1Value, value);
		}

		[Ordinal(7)] 
		[RED("MetaQuest2Value")] 
		public inkTextWidgetReference MetaQuest2Value
		{
			get => GetProperty(ref _metaQuest2Value);
			set => SetProperty(ref _metaQuest2Value, value);
		}

		[Ordinal(8)] 
		[RED("MetaQuest3Value")] 
		public inkTextWidgetReference MetaQuest3Value
		{
			get => GetProperty(ref _metaQuest3Value);
			set => SetProperty(ref _metaQuest3Value, value);
		}

		[Ordinal(9)] 
		[RED("metaQuest1Description")] 
		public CString MetaQuest1Description
		{
			get => GetProperty(ref _metaQuest1Description);
			set => SetProperty(ref _metaQuest1Description, value);
		}

		[Ordinal(10)] 
		[RED("metaQuest2Description")] 
		public CString MetaQuest2Description
		{
			get => GetProperty(ref _metaQuest2Description);
			set => SetProperty(ref _metaQuest2Description, value);
		}

		[Ordinal(11)] 
		[RED("metaQuest3Description")] 
		public CString MetaQuest3Description
		{
			get => GetProperty(ref _metaQuest3Description);
			set => SetProperty(ref _metaQuest3Description, value);
		}

		[Ordinal(12)] 
		[RED("animMeta1")] 
		public CHandle<inkanimProxy> AnimMeta1
		{
			get => GetProperty(ref _animMeta1);
			set => SetProperty(ref _animMeta1, value);
		}

		[Ordinal(13)] 
		[RED("animMeta2")] 
		public CHandle<inkanimProxy> AnimMeta2
		{
			get => GetProperty(ref _animMeta2);
			set => SetProperty(ref _animMeta2, value);
		}

		[Ordinal(14)] 
		[RED("animMeta3")] 
		public CHandle<inkanimProxy> AnimMeta3
		{
			get => GetProperty(ref _animMeta3);
			set => SetProperty(ref _animMeta3, value);
		}

		[Ordinal(15)] 
		[RED("animTooltip")] 
		public CHandle<inkanimProxy> AnimTooltip
		{
			get => GetProperty(ref _animTooltip);
			set => SetProperty(ref _animTooltip, value);
		}
	}
}
