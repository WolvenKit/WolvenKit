using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigIk2Setup : animIRigIkSetup
	{
		private CName _firstBone;
		private CName _secondBone;
		private CName _endBone;
		private CEnum<animAxis> _hingeAxis;
		private CInt16 _firstBoneIdx;
		private CInt16 _secondBoneIdx;
		private CInt16 _endBoneIdx;

		[Ordinal(1)] 
		[RED("firstBone")] 
		public CName FirstBone
		{
			get => GetProperty(ref _firstBone);
			set => SetProperty(ref _firstBone, value);
		}

		[Ordinal(2)] 
		[RED("secondBone")] 
		public CName SecondBone
		{
			get => GetProperty(ref _secondBone);
			set => SetProperty(ref _secondBone, value);
		}

		[Ordinal(3)] 
		[RED("endBone")] 
		public CName EndBone
		{
			get => GetProperty(ref _endBone);
			set => SetProperty(ref _endBone, value);
		}

		[Ordinal(4)] 
		[RED("hingeAxis")] 
		public CEnum<animAxis> HingeAxis
		{
			get => GetProperty(ref _hingeAxis);
			set => SetProperty(ref _hingeAxis, value);
		}

		[Ordinal(5)] 
		[RED("firstBoneIdx")] 
		public CInt16 FirstBoneIdx
		{
			get => GetProperty(ref _firstBoneIdx);
			set => SetProperty(ref _firstBoneIdx, value);
		}

		[Ordinal(6)] 
		[RED("secondBoneIdx")] 
		public CInt16 SecondBoneIdx
		{
			get => GetProperty(ref _secondBoneIdx);
			set => SetProperty(ref _secondBoneIdx, value);
		}

		[Ordinal(7)] 
		[RED("endBoneIdx")] 
		public CInt16 EndBoneIdx
		{
			get => GetProperty(ref _endBoneIdx);
			set => SetProperty(ref _endBoneIdx, value);
		}

		public animRigIk2Setup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
