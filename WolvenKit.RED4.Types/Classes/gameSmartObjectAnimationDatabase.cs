using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectAnimationDatabase : ISerializable
	{
		private CArray<gameAnimationExtractedData> _animationData;
		private CArray<gameBodyTypeData> _bodyTypesData;

		[Ordinal(0)] 
		[RED("animationData")] 
		public CArray<gameAnimationExtractedData> AnimationData
		{
			get => GetProperty(ref _animationData);
			set => SetProperty(ref _animationData, value);
		}

		[Ordinal(1)] 
		[RED("bodyTypesData")] 
		public CArray<gameBodyTypeData> BodyTypesData
		{
			get => GetProperty(ref _bodyTypesData);
			set => SetProperty(ref _bodyTypesData, value);
		}
	}
}
