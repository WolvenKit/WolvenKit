using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectAnimationDatabase_ : ISerializable
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

		public gameSmartObjectAnimationDatabase_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
