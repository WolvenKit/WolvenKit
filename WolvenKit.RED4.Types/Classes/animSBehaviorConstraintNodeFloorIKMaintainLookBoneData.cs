using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSBehaviorConstraintNodeFloorIKMaintainLookBoneData : RedBaseClass
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
	}
}
