using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animRigPartBone : RedBaseClass
	{
		private CName _bone;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("bone")] 
		public CName Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		public animRigPartBone()
		{
			_weight = 1.000000F;
		}
	}
}
