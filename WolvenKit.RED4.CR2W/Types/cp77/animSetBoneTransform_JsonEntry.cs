using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSetBoneTransform_JsonEntry : CVariable
	{
		private CName _transformToChange;
		private CEnum<animSetBoneTransformEntry_SetMethod> _setMethod;
		private CBool _snapToReference;
		private CName _sourceBone;
		private CBool _offsetToReference;
		private CName _offsetSpaceBone;
		private QsTransform _offset;

		[Ordinal(0)] 
		[RED("transformToChange")] 
		public CName TransformToChange
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
		public CName SourceBone
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
		public CName OffsetSpaceBone
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

		public animSetBoneTransform_JsonEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
