using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAnimationExtractedData : CVariable
	{
		private CName _animationName;
		private CArray<gameAnimationTransforms> _animsetsExtractedTransforms;
		private CEnum<gameSmartObjectPointType> _smartObjectPointType;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(1)] 
		[RED("animsetsExtractedTransforms")] 
		public CArray<gameAnimationTransforms> AnimsetsExtractedTransforms
		{
			get => GetProperty(ref _animsetsExtractedTransforms);
			set => SetProperty(ref _animsetsExtractedTransforms, value);
		}

		[Ordinal(2)] 
		[RED("smartObjectPointType")] 
		public CEnum<gameSmartObjectPointType> SmartObjectPointType
		{
			get => GetProperty(ref _smartObjectPointType);
			set => SetProperty(ref _smartObjectPointType, value);
		}

		public gameAnimationExtractedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
