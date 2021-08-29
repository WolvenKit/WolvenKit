using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSetBoneTransformEntry : RedBaseClass
	{
		private animTransformIndex _transformToChange;
		private CEnum<animSetBoneTransformEntry_SetMethod> _setMethod;
		private CBool _snapToReference;
		private animTransformIndex _sourceBone;
		private CBool _offsetToReference;
		private animTransformIndex _offsetSpaceBone;
		private QsTransform _offset;

		[Ordinal(0)] 
		[RED("transformToChange")] 
		public animTransformIndex TransformToChange
		{
			get => GetProperty(ref _transformToChange);
			set => SetProperty(ref _transformToChange, value);
		}

		[Ordinal(1)] 
		[RED("setMethod")] 
		public CEnum<animSetBoneTransformEntry_SetMethod> SetMethod
		{
			get => GetProperty(ref _setMethod);
			set => SetProperty(ref _setMethod, value);
		}

		[Ordinal(2)] 
		[RED("snapToReference")] 
		public CBool SnapToReference
		{
			get => GetProperty(ref _snapToReference);
			set => SetProperty(ref _snapToReference, value);
		}

		[Ordinal(3)] 
		[RED("sourceBone")] 
		public animTransformIndex SourceBone
		{
			get => GetProperty(ref _sourceBone);
			set => SetProperty(ref _sourceBone, value);
		}

		[Ordinal(4)] 
		[RED("offsetToReference")] 
		public CBool OffsetToReference
		{
			get => GetProperty(ref _offsetToReference);
			set => SetProperty(ref _offsetToReference, value);
		}

		[Ordinal(5)] 
		[RED("offsetSpaceBone")] 
		public animTransformIndex OffsetSpaceBone
		{
			get => GetProperty(ref _offsetSpaceBone);
			set => SetProperty(ref _offsetSpaceBone, value);
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public QsTransform Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}
	}
}
