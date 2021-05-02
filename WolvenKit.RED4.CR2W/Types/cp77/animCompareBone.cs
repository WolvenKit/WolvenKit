using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCompareBone : CVariable
	{
		private CName _boneName;
		private Quaternion _boneRotationLs;

		[Ordinal(0)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetProperty(ref _boneName);
			set => SetProperty(ref _boneName, value);
		}

		[Ordinal(1)] 
		[RED("boneRotationLs")] 
		public Quaternion BoneRotationLs
		{
			get => GetProperty(ref _boneRotationLs);
			set => SetProperty(ref _boneRotationLs, value);
		}

		public animCompareBone(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
