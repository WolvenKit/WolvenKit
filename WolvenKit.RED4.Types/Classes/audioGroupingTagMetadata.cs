using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGroupingTagMetadata : audioAudioMetadata
	{
		private CName _shape;
		private CEnum<audioClassificationMethod> _classificationMethod;
		private CName _inputEmitterName;
		private CArray<CName> _inputEventNames;
		private CArray<CName> _inputTags;
		private CName _outputEventId;
		private CFloat _minimalGroupCount;
		private CFloat _fullGroupCount;

		[Ordinal(1)] 
		[RED("shape")] 
		public CName Shape
		{
			get => GetProperty(ref _shape);
			set => SetProperty(ref _shape, value);
		}

		[Ordinal(2)] 
		[RED("classificationMethod")] 
		public CEnum<audioClassificationMethod> ClassificationMethod
		{
			get => GetProperty(ref _classificationMethod);
			set => SetProperty(ref _classificationMethod, value);
		}

		[Ordinal(3)] 
		[RED("inputEmitterName")] 
		public CName InputEmitterName
		{
			get => GetProperty(ref _inputEmitterName);
			set => SetProperty(ref _inputEmitterName, value);
		}

		[Ordinal(4)] 
		[RED("inputEventNames")] 
		public CArray<CName> InputEventNames
		{
			get => GetProperty(ref _inputEventNames);
			set => SetProperty(ref _inputEventNames, value);
		}

		[Ordinal(5)] 
		[RED("inputTags")] 
		public CArray<CName> InputTags
		{
			get => GetProperty(ref _inputTags);
			set => SetProperty(ref _inputTags, value);
		}

		[Ordinal(6)] 
		[RED("outputEventId")] 
		public CName OutputEventId
		{
			get => GetProperty(ref _outputEventId);
			set => SetProperty(ref _outputEventId, value);
		}

		[Ordinal(7)] 
		[RED("minimalGroupCount")] 
		public CFloat MinimalGroupCount
		{
			get => GetProperty(ref _minimalGroupCount);
			set => SetProperty(ref _minimalGroupCount, value);
		}

		[Ordinal(8)] 
		[RED("fullGroupCount")] 
		public CFloat FullGroupCount
		{
			get => GetProperty(ref _fullGroupCount);
			set => SetProperty(ref _fullGroupCount, value);
		}
	}
}
