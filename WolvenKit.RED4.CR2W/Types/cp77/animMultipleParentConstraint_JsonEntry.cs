using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animMultipleParentConstraint_JsonEntry : CVariable
	{
		private CName _parentTransform;
		private CEnum<animConstraintWeightMode> _parentWeightMode;
		private CFloat _parentStaticWeight;
		private CName _parentTrackWeight;
		private CBool _useComplementWeight;
		private CBool _useOffset;
		private QsTransform _offset;

		[Ordinal(0)] 
		[RED("parentTransform")] 
		public CName ParentTransform
		{
			get => GetProperty(ref _parentTransform);
			set => SetProperty(ref _parentTransform, value);
		}

		[Ordinal(1)] 
		[RED("parentWeightMode")] 
		public CEnum<animConstraintWeightMode> ParentWeightMode
		{
			get => GetProperty(ref _parentWeightMode);
			set => SetProperty(ref _parentWeightMode, value);
		}

		[Ordinal(2)] 
		[RED("parentStaticWeight")] 
		public CFloat ParentStaticWeight
		{
			get => GetProperty(ref _parentStaticWeight);
			set => SetProperty(ref _parentStaticWeight, value);
		}

		[Ordinal(3)] 
		[RED("parentTrackWeight")] 
		public CName ParentTrackWeight
		{
			get => GetProperty(ref _parentTrackWeight);
			set => SetProperty(ref _parentTrackWeight, value);
		}

		[Ordinal(4)] 
		[RED("useComplementWeight")] 
		public CBool UseComplementWeight
		{
			get => GetProperty(ref _useComplementWeight);
			set => SetProperty(ref _useComplementWeight, value);
		}

		[Ordinal(5)] 
		[RED("useOffset")] 
		public CBool UseOffset
		{
			get => GetProperty(ref _useOffset);
			set => SetProperty(ref _useOffset, value);
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public QsTransform Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		public animMultipleParentConstraint_JsonEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
