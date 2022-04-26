using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLayerDefinition_NEW : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("layerType")] 
		public CEnum<inkELayerType> LayerType
		{
			get => GetPropertyValue<CEnum<inkELayerType>>();
			set => SetPropertyValue<CEnum<inkELayerType>>(value);
		}

		[Ordinal(2)] 
		[RED("drawingPolicy")] 
		public CEnum<inkLayerDrawingPolicy> DrawingPolicy
		{
			get => GetPropertyValue<CEnum<inkLayerDrawingPolicy>>();
			set => SetPropertyValue<CEnum<inkLayerDrawingPolicy>>(value);
		}

		[Ordinal(3)] 
		[RED("loadPriority")] 
		public CEnum<inkELayerLoadPriority> LoadPriority
		{
			get => GetPropertyValue<CEnum<inkELayerLoadPriority>>();
			set => SetPropertyValue<CEnum<inkELayerLoadPriority>>(value);
		}

		[Ordinal(4)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isPermanent")] 
		public CBool IsPermanent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("useGlobalStyleTheme")] 
		public CBool UseGlobalStyleTheme
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isAffectedByFadeout")] 
		public CBool IsAffectedByFadeout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("useGameInput")] 
		public CBool UseGameInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("inputContext")] 
		public CName InputContext
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkLayerDefinition_NEW()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
