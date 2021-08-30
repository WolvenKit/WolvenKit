using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerkMenuTooltipController : AGenericTooltipController
	{
		private inkWidgetReference _titleContainer;
		private inkTextWidgetReference _titleText;
		private inkWidgetReference _typeContainer;
		private inkTextWidgetReference _typeText;
		private inkWidgetReference _desc1Container;
		private inkTextWidgetReference _desc1Text;
		private inkWidgetReference _desc2Container;
		private inkTextWidgetReference _desc2Text;
		private inkTextWidgetReference _desc2TextNextLevel;
		private inkTextWidgetReference _desc2TextNextLevelDesc;
		private inkWidgetReference _holdToUpgrade;
		private inkWidgetReference _openPerkScreen;
		private inkWidgetReference _videoContainerWidget;
		private inkVideoWidgetReference _videoWidget;
		private CHandle<BasePerksMenuTooltipData> _data;
		private CInt32 _maxProficiencyLevel;

		[Ordinal(2)] 
		[RED("titleContainer")] 
		public inkWidgetReference TitleContainer
		{
			get => GetProperty(ref _titleContainer);
			set => SetProperty(ref _titleContainer, value);
		}

		[Ordinal(3)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetProperty(ref _titleText);
			set => SetProperty(ref _titleText, value);
		}

		[Ordinal(4)] 
		[RED("typeContainer")] 
		public inkWidgetReference TypeContainer
		{
			get => GetProperty(ref _typeContainer);
			set => SetProperty(ref _typeContainer, value);
		}

		[Ordinal(5)] 
		[RED("typeText")] 
		public inkTextWidgetReference TypeText
		{
			get => GetProperty(ref _typeText);
			set => SetProperty(ref _typeText, value);
		}

		[Ordinal(6)] 
		[RED("desc1Container")] 
		public inkWidgetReference Desc1Container
		{
			get => GetProperty(ref _desc1Container);
			set => SetProperty(ref _desc1Container, value);
		}

		[Ordinal(7)] 
		[RED("desc1Text")] 
		public inkTextWidgetReference Desc1Text
		{
			get => GetProperty(ref _desc1Text);
			set => SetProperty(ref _desc1Text, value);
		}

		[Ordinal(8)] 
		[RED("desc2Container")] 
		public inkWidgetReference Desc2Container
		{
			get => GetProperty(ref _desc2Container);
			set => SetProperty(ref _desc2Container, value);
		}

		[Ordinal(9)] 
		[RED("desc2Text")] 
		public inkTextWidgetReference Desc2Text
		{
			get => GetProperty(ref _desc2Text);
			set => SetProperty(ref _desc2Text, value);
		}

		[Ordinal(10)] 
		[RED("desc2TextNextLevel")] 
		public inkTextWidgetReference Desc2TextNextLevel
		{
			get => GetProperty(ref _desc2TextNextLevel);
			set => SetProperty(ref _desc2TextNextLevel, value);
		}

		[Ordinal(11)] 
		[RED("desc2TextNextLevelDesc")] 
		public inkTextWidgetReference Desc2TextNextLevelDesc
		{
			get => GetProperty(ref _desc2TextNextLevelDesc);
			set => SetProperty(ref _desc2TextNextLevelDesc, value);
		}

		[Ordinal(12)] 
		[RED("holdToUpgrade")] 
		public inkWidgetReference HoldToUpgrade
		{
			get => GetProperty(ref _holdToUpgrade);
			set => SetProperty(ref _holdToUpgrade, value);
		}

		[Ordinal(13)] 
		[RED("openPerkScreen")] 
		public inkWidgetReference OpenPerkScreen
		{
			get => GetProperty(ref _openPerkScreen);
			set => SetProperty(ref _openPerkScreen, value);
		}

		[Ordinal(14)] 
		[RED("videoContainerWidget")] 
		public inkWidgetReference VideoContainerWidget
		{
			get => GetProperty(ref _videoContainerWidget);
			set => SetProperty(ref _videoContainerWidget, value);
		}

		[Ordinal(15)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetProperty(ref _videoWidget);
			set => SetProperty(ref _videoWidget, value);
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<BasePerksMenuTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(17)] 
		[RED("maxProficiencyLevel")] 
		public CInt32 MaxProficiencyLevel
		{
			get => GetProperty(ref _maxProficiencyLevel);
			set => SetProperty(ref _maxProficiencyLevel, value);
		}

		public PerkMenuTooltipController()
		{
			_maxProficiencyLevel = 20;
		}
	}
}
