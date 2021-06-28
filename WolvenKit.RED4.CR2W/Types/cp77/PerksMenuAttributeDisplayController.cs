using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeDisplayController : BaseButtonView
	{
		private inkWidgetReference _widgetWrapper;
		private inkWidgetReference _foregroundWrapper;
		private inkWidgetReference _johnnyWrapper;
		private inkTextWidgetReference _attributeName;
		private inkImageWidgetReference _attributeIcon;
		private inkTextWidgetReference _attributeLevel;
		private inkWidgetReference _frameHovered;
		private inkWidgetReference _accent1Hovered;
		private inkWidgetReference _accent1BGHovered;
		private inkWidgetReference _accent2Hovered;
		private inkWidgetReference _accent2BGHovered;
		private inkWidgetReference _topConnectionContainer;
		private inkWidgetReference _bottomConnectionContainer;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private CEnum<PerkMenuAttribute> _attribute;
		private CHandle<AttributeData> _attributeData;

		[Ordinal(2)] 
		[RED("widgetWrapper")] 
		public inkWidgetReference WidgetWrapper
		{
			get => GetProperty(ref _widgetWrapper);
			set => SetProperty(ref _widgetWrapper, value);
		}

		[Ordinal(3)] 
		[RED("foregroundWrapper")] 
		public inkWidgetReference ForegroundWrapper
		{
			get => GetProperty(ref _foregroundWrapper);
			set => SetProperty(ref _foregroundWrapper, value);
		}

		[Ordinal(4)] 
		[RED("johnnyWrapper")] 
		public inkWidgetReference JohnnyWrapper
		{
			get => GetProperty(ref _johnnyWrapper);
			set => SetProperty(ref _johnnyWrapper, value);
		}

		[Ordinal(5)] 
		[RED("attributeName")] 
		public inkTextWidgetReference AttributeName
		{
			get => GetProperty(ref _attributeName);
			set => SetProperty(ref _attributeName, value);
		}

		[Ordinal(6)] 
		[RED("attributeIcon")] 
		public inkImageWidgetReference AttributeIcon
		{
			get => GetProperty(ref _attributeIcon);
			set => SetProperty(ref _attributeIcon, value);
		}

		[Ordinal(7)] 
		[RED("attributeLevel")] 
		public inkTextWidgetReference AttributeLevel
		{
			get => GetProperty(ref _attributeLevel);
			set => SetProperty(ref _attributeLevel, value);
		}

		[Ordinal(8)] 
		[RED("frameHovered")] 
		public inkWidgetReference FrameHovered
		{
			get => GetProperty(ref _frameHovered);
			set => SetProperty(ref _frameHovered, value);
		}

		[Ordinal(9)] 
		[RED("accent1Hovered")] 
		public inkWidgetReference Accent1Hovered
		{
			get => GetProperty(ref _accent1Hovered);
			set => SetProperty(ref _accent1Hovered, value);
		}

		[Ordinal(10)] 
		[RED("accent1BGHovered")] 
		public inkWidgetReference Accent1BGHovered
		{
			get => GetProperty(ref _accent1BGHovered);
			set => SetProperty(ref _accent1BGHovered, value);
		}

		[Ordinal(11)] 
		[RED("accent2Hovered")] 
		public inkWidgetReference Accent2Hovered
		{
			get => GetProperty(ref _accent2Hovered);
			set => SetProperty(ref _accent2Hovered, value);
		}

		[Ordinal(12)] 
		[RED("accent2BGHovered")] 
		public inkWidgetReference Accent2BGHovered
		{
			get => GetProperty(ref _accent2BGHovered);
			set => SetProperty(ref _accent2BGHovered, value);
		}

		[Ordinal(13)] 
		[RED("topConnectionContainer")] 
		public inkWidgetReference TopConnectionContainer
		{
			get => GetProperty(ref _topConnectionContainer);
			set => SetProperty(ref _topConnectionContainer, value);
		}

		[Ordinal(14)] 
		[RED("bottomConnectionContainer")] 
		public inkWidgetReference BottomConnectionContainer
		{
			get => GetProperty(ref _bottomConnectionContainer);
			set => SetProperty(ref _bottomConnectionContainer, value);
		}

		[Ordinal(15)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(16)] 
		[RED("attribute")] 
		public CEnum<PerkMenuAttribute> Attribute
		{
			get => GetProperty(ref _attribute);
			set => SetProperty(ref _attribute, value);
		}

		[Ordinal(17)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get => GetProperty(ref _attributeData);
			set => SetProperty(ref _attributeData, value);
		}

		public PerksMenuAttributeDisplayController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
