using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animStackTransformsExtender_Entry : CVariable
	{
		private animTransformInfo _transformInfo;
		private CEnum<animStackTransformsExtender_SnapToBoneMethod> _snapMethod;
		private CBool _snapToReference;
		private animTransformIndex _snapTargetBone;
		private CBool _offsetToReference;
		private animTransformIndex _offsetSpaceBone;
		private QsTransform _offset;

		[Ordinal(0)] 
		[RED("transformInfo")] 
		public animTransformInfo TransformInfo
		{
			get => GetProperty(ref _transformInfo);
			set => SetProperty(ref _transformInfo, value);
		}

		[Ordinal(1)] 
		[RED("snapMethod")] 
		public CEnum<animStackTransformsExtender_SnapToBoneMethod> SnapMethod
		{
			get => GetProperty(ref _snapMethod);
			set => SetProperty(ref _snapMethod, value);
		}

		[Ordinal(2)] 
		[RED("snapToReference")] 
		public CBool SnapToReference
		{
			get => GetProperty(ref _snapToReference);
			set => SetProperty(ref _snapToReference, value);
		}

		[Ordinal(3)] 
		[RED("snapTargetBone")] 
		public animTransformIndex SnapTargetBone
		{
			get => GetProperty(ref _snapTargetBone);
			set => SetProperty(ref _snapTargetBone, value);
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

		public animStackTransformsExtender_Entry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
