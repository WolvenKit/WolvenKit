using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerksMenuAttributeDisplayController : BaseButtonView
	{
		[Ordinal(2)] 
		[RED("widgetWrapper")] 
		public inkWidgetReference WidgetWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("foregroundWrapper")] 
		public inkWidgetReference ForegroundWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("johnnyWrapper")] 
		public inkWidgetReference JohnnyWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("attributeName")] 
		public inkTextWidgetReference AttributeName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("attributeIcon")] 
		public inkImageWidgetReference AttributeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("attributeLevel")] 
		public inkTextWidgetReference AttributeLevel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("frameHovered")] 
		public inkWidgetReference FrameHovered
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("accent1Hovered")] 
		public inkWidgetReference Accent1Hovered
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("accent1BGHovered")] 
		public inkWidgetReference Accent1BGHovered
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("accent2Hovered")] 
		public inkWidgetReference Accent2Hovered
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("accent2BGHovered")] 
		public inkWidgetReference Accent2BGHovered
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("topConnectionContainer")] 
		public inkWidgetReference TopConnectionContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("bottomConnectionContainer")] 
		public inkWidgetReference BottomConnectionContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentDataManager>>(value);
		}

		[Ordinal(16)] 
		[RED("attribute")] 
		public CEnum<PerkMenuAttribute> Attribute
		{
			get => GetPropertyValue<CEnum<PerkMenuAttribute>>();
			set => SetPropertyValue<CEnum<PerkMenuAttribute>>(value);
		}

		[Ordinal(17)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get => GetPropertyValue<CHandle<AttributeData>>();
			set => SetPropertyValue<CHandle<AttributeData>>(value);
		}

		public PerksMenuAttributeDisplayController()
		{
			WidgetWrapper = new();
			ForegroundWrapper = new();
			JohnnyWrapper = new();
			AttributeName = new();
			AttributeIcon = new();
			AttributeLevel = new();
			FrameHovered = new();
			Accent1Hovered = new();
			Accent1BGHovered = new();
			Accent2Hovered = new();
			Accent2BGHovered = new();
			TopConnectionContainer = new();
			BottomConnectionContainer = new();
		}
	}
}
