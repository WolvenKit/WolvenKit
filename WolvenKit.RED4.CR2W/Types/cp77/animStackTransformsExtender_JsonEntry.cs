using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animStackTransformsExtender_JsonEntry : CVariable
	{
		private CName _name;
		private CName _parentName;
		private QsTransform _referenceTransformLs;
		private CEnum<animStackTransformsExtender_SnapToBoneMethod> _snapMethod;
		private CBool _snapToReference;
		private CName _snapTargetBone;
		private CBool _offsetToReference;
		private CName _offsetSpaceBone;
		private QsTransform _offset;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("parentName")] 
		public CName ParentName
		{
			get => GetProperty(ref _parentName);
			set => SetProperty(ref _parentName, value);
		}

		[Ordinal(2)] 
		[RED("referenceTransformLs")] 
		public QsTransform ReferenceTransformLs
		{
			get => GetProperty(ref _referenceTransformLs);
			set => SetProperty(ref _referenceTransformLs, value);
		}

		[Ordinal(3)] 
		[RED("snapMethod")] 
		public CEnum<animStackTransformsExtender_SnapToBoneMethod> SnapMethod
		{
			get => GetProperty(ref _snapMethod);
			set => SetProperty(ref _snapMethod, value);
		}

		[Ordinal(4)] 
		[RED("snapToReference")] 
		public CBool SnapToReference
		{
			get => GetProperty(ref _snapToReference);
			set => SetProperty(ref _snapToReference, value);
		}

		[Ordinal(5)] 
		[RED("snapTargetBone")] 
		public CName SnapTargetBone
		{
			get => GetProperty(ref _snapTargetBone);
			set => SetProperty(ref _snapTargetBone, value);
		}

		[Ordinal(6)] 
		[RED("offsetToReference")] 
		public CBool OffsetToReference
		{
			get => GetProperty(ref _offsetToReference);
			set => SetProperty(ref _offsetToReference, value);
		}

		[Ordinal(7)] 
		[RED("offsetSpaceBone")] 
		public CName OffsetSpaceBone
		{
			get => GetProperty(ref _offsetSpaceBone);
			set => SetProperty(ref _offsetSpaceBone, value);
		}

		[Ordinal(8)] 
		[RED("offset")] 
		public QsTransform Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		public animStackTransformsExtender_JsonEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
