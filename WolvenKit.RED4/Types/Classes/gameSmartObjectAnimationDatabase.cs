using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSmartObjectAnimationDatabase : ISerializable
	{
		[Ordinal(0)] 
		[RED("animationData")] 
		public CArray<gameAnimationExtractedData> AnimationData
		{
			get => GetPropertyValue<CArray<gameAnimationExtractedData>>();
			set => SetPropertyValue<CArray<gameAnimationExtractedData>>(value);
		}

		[Ordinal(1)] 
		[RED("bodyTypesData")] 
		public CArray<gameBodyTypeData> BodyTypesData
		{
			get => GetPropertyValue<CArray<gameBodyTypeData>>();
			set => SetPropertyValue<CArray<gameBodyTypeData>>(value);
		}

		public gameSmartObjectAnimationDatabase()
		{
			AnimationData = new();
			BodyTypesData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
