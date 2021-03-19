using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigPart : CVariable
	{
		private CName _name;
		private CArray<animRigPartBone> _singleBones;
		private CArray<animRigPartBoneTree> _treeBones;
		private CArray<CName> _bonesWithRotationInModelSpace;
		private CArray<animTransformMask> _mask;
		private CArray<CInt32> _maskRotMS;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("singleBones")] 
		public CArray<animRigPartBone> SingleBones
		{
			get => GetProperty(ref _singleBones);
			set => SetProperty(ref _singleBones, value);
		}

		[Ordinal(2)] 
		[RED("treeBones")] 
		public CArray<animRigPartBoneTree> TreeBones
		{
			get => GetProperty(ref _treeBones);
			set => SetProperty(ref _treeBones, value);
		}

		[Ordinal(3)] 
		[RED("bonesWithRotationInModelSpace")] 
		public CArray<CName> BonesWithRotationInModelSpace
		{
			get => GetProperty(ref _bonesWithRotationInModelSpace);
			set => SetProperty(ref _bonesWithRotationInModelSpace, value);
		}

		[Ordinal(4)] 
		[RED("mask")] 
		public CArray<animTransformMask> Mask
		{
			get => GetProperty(ref _mask);
			set => SetProperty(ref _mask, value);
		}

		[Ordinal(5)] 
		[RED("maskRotMS")] 
		public CArray<CInt32> MaskRotMS
		{
			get => GetProperty(ref _maskRotMS);
			set => SetProperty(ref _maskRotMS, value);
		}

		public animRigPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
