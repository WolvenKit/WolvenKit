using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animRigPartBoneTree : RedBaseClass
	{
		private CName _rootBone;
		private CFloat _weight;
		private CArray<animRigPartBoneTree> _subtreesToChange;

		[Ordinal(0)] 
		[RED("rootBone")] 
		public CName RootBone
		{
			get => GetProperty(ref _rootBone);
			set => SetProperty(ref _rootBone, value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(2)] 
		[RED("subtreesToChange")] 
		public CArray<animRigPartBoneTree> SubtreesToChange
		{
			get => GetProperty(ref _subtreesToChange);
			set => SetProperty(ref _subtreesToChange, value);
		}
	}
}
