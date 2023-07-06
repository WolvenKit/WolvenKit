using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MetaQuestLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("MetaQuestHint")] 
		public inkWidgetReference MetaQuestHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("MetaQuestHintText")] 
		public inkTextWidgetReference MetaQuestHintText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("MetaQuest1")] 
		public inkWidgetReference MetaQuest1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("MetaQuest2")] 
		public inkWidgetReference MetaQuest2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("MetaQuest3")] 
		public inkWidgetReference MetaQuest3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("MetaQuest1Value")] 
		public inkTextWidgetReference MetaQuest1Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("MetaQuest2Value")] 
		public inkTextWidgetReference MetaQuest2Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("MetaQuest3Value")] 
		public inkTextWidgetReference MetaQuest3Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("metaQuest1Description")] 
		public CString MetaQuest1Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("metaQuest2Description")] 
		public CString MetaQuest2Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("metaQuest3Description")] 
		public CString MetaQuest3Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(12)] 
		[RED("animMeta1")] 
		public CHandle<inkanimProxy> AnimMeta1
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(13)] 
		[RED("animMeta2")] 
		public CHandle<inkanimProxy> AnimMeta2
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(14)] 
		[RED("animMeta3")] 
		public CHandle<inkanimProxy> AnimMeta3
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(15)] 
		[RED("animTooltip")] 
		public CHandle<inkanimProxy> AnimTooltip
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public MetaQuestLogicController()
		{
			MetaQuestHint = new inkWidgetReference();
			MetaQuestHintText = new inkTextWidgetReference();
			MetaQuest1 = new inkWidgetReference();
			MetaQuest2 = new inkWidgetReference();
			MetaQuest3 = new inkWidgetReference();
			MetaQuest1Value = new inkTextWidgetReference();
			MetaQuest2Value = new inkTextWidgetReference();
			MetaQuest3Value = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
