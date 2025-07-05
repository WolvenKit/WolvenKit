using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioGroupingTagMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("shape")] 
		public CName Shape
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("classificationMethod")] 
		public CEnum<audioClassificationMethod> ClassificationMethod
		{
			get => GetPropertyValue<CEnum<audioClassificationMethod>>();
			set => SetPropertyValue<CEnum<audioClassificationMethod>>(value);
		}

		[Ordinal(3)] 
		[RED("inputEmitterName")] 
		public CName InputEmitterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("inputEventNames")] 
		public CArray<CName> InputEventNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("inputTags")] 
		public CArray<CName> InputTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("outputEventId")] 
		public CName OutputEventId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("minimalGroupCount")] 
		public CFloat MinimalGroupCount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("fullGroupCount")] 
		public CFloat FullGroupCount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioGroupingTagMetadata()
		{
			InputEventNames = new();
			InputTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
