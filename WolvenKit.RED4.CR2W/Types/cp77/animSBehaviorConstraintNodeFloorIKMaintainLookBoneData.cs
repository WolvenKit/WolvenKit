using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKMaintainLookBoneData : CVariable
	{
		private CName _bone;
		private CFloat _amountOfRotation;

		[Ordinal(0)] 
		[RED("bone")] 
		public CName Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(1)] 
		[RED("amountOfRotation")] 
		public CFloat AmountOfRotation
		{
			get => GetProperty(ref _amountOfRotation);
			set => SetProperty(ref _amountOfRotation, value);
		}

		public animSBehaviorConstraintNodeFloorIKMaintainLookBoneData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
