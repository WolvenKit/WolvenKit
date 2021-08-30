using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_State : animAnimNode_Container
	{
		private CName _name;
		private CArray<CInt16> _outTransitionIndices;
		private CBool _preventTransitionsInActivationFrame;
		private CArray<CName> _tags;
		private CUInt32 _requiredQualityDistanceCategory;

		[Ordinal(12)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(13)] 
		[RED("outTransitionIndices")] 
		public CArray<CInt16> OutTransitionIndices
		{
			get => GetProperty(ref _outTransitionIndices);
			set => SetProperty(ref _outTransitionIndices, value);
		}

		[Ordinal(14)] 
		[RED("preventTransitionsInActivationFrame")] 
		public CBool PreventTransitionsInActivationFrame
		{
			get => GetProperty(ref _preventTransitionsInActivationFrame);
			set => SetProperty(ref _preventTransitionsInActivationFrame, value);
		}

		[Ordinal(15)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(16)] 
		[RED("requiredQualityDistanceCategory")] 
		public CUInt32 RequiredQualityDistanceCategory
		{
			get => GetProperty(ref _requiredQualityDistanceCategory);
			set => SetProperty(ref _requiredQualityDistanceCategory, value);
		}

		public animAnimNode_State()
		{
			_requiredQualityDistanceCategory = 4;
		}
	}
}
