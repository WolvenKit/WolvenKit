using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animMultipleParentConstraint_JsonProperties : ISerializable
	{
		private CArray<animMultipleParentConstraint_JsonEntry> _parentsTransforms;
		private CName _transformIndex;
		private CEnum<animConstraintWeightMode> _weightMode;
		private CFloat _weight;
		private CName _weightFloatTrack;

		[Ordinal(0)] 
		[RED("parentsTransforms")] 
		public CArray<animMultipleParentConstraint_JsonEntry> ParentsTransforms
		{
			get => GetProperty(ref _parentsTransforms);
			set => SetProperty(ref _parentsTransforms, value);
		}

		[Ordinal(1)] 
		[RED("transformIndex")] 
		public CName TransformIndex
		{
			get => GetProperty(ref _transformIndex);
			set => SetProperty(ref _transformIndex, value);
		}

		[Ordinal(2)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get => GetProperty(ref _weightMode);
			set => SetProperty(ref _weightMode, value);
		}

		[Ordinal(3)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(4)] 
		[RED("weightFloatTrack")] 
		public CName WeightFloatTrack
		{
			get => GetProperty(ref _weightFloatTrack);
			set => SetProperty(ref _weightFloatTrack, value);
		}

		public animMultipleParentConstraint_JsonProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
