using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StackTransformsExtender_ : animAnimNode_OnePoseInput
	{
		private CName _tag;
		private CArray<animTransformInfo> _transformInfos;
		private CArray<CEnum<animStackTransformsExtender_SnapToBoneMethod>> _snapMethods;
		private CArray<CBool> _snapToReferenceValues;
		private CArray<animTransformIndex> _snapTargetBones;
		private CArray<CBool> _offsetToReferenceValues;
		private CArray<animTransformIndex> _offsetSpaceBones;
		private CArray<QsTransform> _offsets;

		[Ordinal(12)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(13)] 
		[RED("transformInfos")] 
		public CArray<animTransformInfo> TransformInfos
		{
			get => GetProperty(ref _transformInfos);
			set => SetProperty(ref _transformInfos, value);
		}

		[Ordinal(14)] 
		[RED("snapMethods")] 
		public CArray<CEnum<animStackTransformsExtender_SnapToBoneMethod>> SnapMethods
		{
			get => GetProperty(ref _snapMethods);
			set => SetProperty(ref _snapMethods, value);
		}

		[Ordinal(15)] 
		[RED("snapToReferenceValues")] 
		public CArray<CBool> SnapToReferenceValues
		{
			get => GetProperty(ref _snapToReferenceValues);
			set => SetProperty(ref _snapToReferenceValues, value);
		}

		[Ordinal(16)] 
		[RED("snapTargetBones")] 
		public CArray<animTransformIndex> SnapTargetBones
		{
			get => GetProperty(ref _snapTargetBones);
			set => SetProperty(ref _snapTargetBones, value);
		}

		[Ordinal(17)] 
		[RED("offsetToReferenceValues")] 
		public CArray<CBool> OffsetToReferenceValues
		{
			get => GetProperty(ref _offsetToReferenceValues);
			set => SetProperty(ref _offsetToReferenceValues, value);
		}

		[Ordinal(18)] 
		[RED("offsetSpaceBones")] 
		public CArray<animTransformIndex> OffsetSpaceBones
		{
			get => GetProperty(ref _offsetSpaceBones);
			set => SetProperty(ref _offsetSpaceBones, value);
		}

		[Ordinal(19)] 
		[RED("offsets")] 
		public CArray<QsTransform> Offsets
		{
			get => GetProperty(ref _offsets);
			set => SetProperty(ref _offsets, value);
		}

		public animAnimNode_StackTransformsExtender_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
