using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ColorTemplatePreviewDisplayController : BaseButtonView
	{
		[Ordinal(5)] 
		[RED("primaryColorMask")] 
		public inkImageWidgetReference PrimaryColorMask
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("primaryColorMaskGroup")] 
		public inkWidgetReference PrimaryColorMaskGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("secondaryColorMask")] 
		public inkImageWidgetReference SecondaryColorMask
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("secondaryColorMaskGroup")] 
		public inkWidgetReference SecondaryColorMaskGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("lightColorMask")] 
		public inkImageWidgetReference LightColorMask
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("lightColorMaskGroup")] 
		public inkWidgetReference LightColorMaskGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("frame")] 
		public inkFlexWidgetReference Frame
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("noTemplate")] 
		public inkFlexWidgetReference NoTemplate
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("checkbox")] 
		public inkFlexWidgetReference Checkbox
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("templateType")] 
		public inkImageWidgetReference TemplateType
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("checkboxSquare")] 
		public inkRectangleWidgetReference CheckboxSquare
		{
			get => GetPropertyValue<inkRectangleWidgetReference>();
			set => SetPropertyValue<inkRectangleWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("addIcon")] 
		public inkImageWidgetReference AddIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("lightsColorGrey")] 
		public inkImageWidgetReference LightsColorGrey
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("uniqueTemplateImage")] 
		public inkImageWidgetReference UniqueTemplateImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("frameSelected")] 
		public inkImageWidgetReference FrameSelected
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("genericColor")] 
		public HDRColor GenericColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(21)] 
		[RED("uniqueColor")] 
		public HDRColor UniqueColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(22)] 
		[RED("currentTemplate")] 
		public VehicleVisualCustomizationTemplate CurrentTemplate
		{
			get => GetPropertyValue<VehicleVisualCustomizationTemplate>();
			set => SetPropertyValue<VehicleVisualCustomizationTemplate>(value);
		}

		[Ordinal(23)] 
		[RED("canAdd")] 
		public CBool CanAdd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("lightsColorAvailable")] 
		public CBool LightsColorAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ColorTemplatePreviewDisplayController()
		{
			PrimaryColorMask = new inkImageWidgetReference();
			PrimaryColorMaskGroup = new inkWidgetReference();
			SecondaryColorMask = new inkImageWidgetReference();
			SecondaryColorMaskGroup = new inkWidgetReference();
			LightColorMask = new inkImageWidgetReference();
			LightColorMaskGroup = new inkWidgetReference();
			Frame = new inkFlexWidgetReference();
			NoTemplate = new inkFlexWidgetReference();
			Checkbox = new inkFlexWidgetReference();
			TemplateType = new inkImageWidgetReference();
			CheckboxSquare = new inkRectangleWidgetReference();
			AddIcon = new inkImageWidgetReference();
			LightsColorGrey = new inkImageWidgetReference();
			UniqueTemplateImage = new inkImageWidgetReference();
			FrameSelected = new inkImageWidgetReference();
			GenericColor = new HDRColor();
			UniqueColor = new HDRColor();
			CurrentTemplate = new VehicleVisualCustomizationTemplate { GenericData = new GenericTemplatePersistentData(), UniqueData = new UniqueTemplateData { CustomMultilayers = new(), CustomDecals = new(), GlobalClearCoatOverrides = new vehicleVehicleClearCoatOverrides { Opacity = -1.000000F, CoatTintFwd = new CColor(), CoatTintSide = new CColor(), CoatTintFresnelBias = -1.000000F, CoatSpecularColor = new CColor(), CoatFresnelBias = -1.000000F }, PartsClearCoatOverrides = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
