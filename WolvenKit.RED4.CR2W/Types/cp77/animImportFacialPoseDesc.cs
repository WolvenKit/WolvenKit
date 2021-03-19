using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialPoseDesc : CVariable
	{
		private CArray<animImportFacialTransform> _transforms;
		private CArray<animImportFacialTransformNoScale> _transformsNoScale;
		private CArray<CUInt16> _transformIds;
		private CArray<CName> _transformNames;

		[Ordinal(0)] 
		[RED("transforms")] 
		public CArray<animImportFacialTransform> Transforms
		{
			get => GetProperty(ref _transforms);
			set => SetProperty(ref _transforms, value);
		}

		[Ordinal(1)] 
		[RED("transformsNoScale")] 
		public CArray<animImportFacialTransformNoScale> TransformsNoScale
		{
			get => GetProperty(ref _transformsNoScale);
			set => SetProperty(ref _transformsNoScale, value);
		}

		[Ordinal(2)] 
		[RED("transformIds")] 
		public CArray<CUInt16> TransformIds
		{
			get => GetProperty(ref _transformIds);
			set => SetProperty(ref _transformIds, value);
		}

		[Ordinal(3)] 
		[RED("transformNames")] 
		public CArray<CName> TransformNames
		{
			get => GetProperty(ref _transformNames);
			set => SetProperty(ref _transformNames, value);
		}

		public animImportFacialPoseDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
