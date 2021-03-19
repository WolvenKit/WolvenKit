using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigPartBoneTree : CVariable
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

		public animRigPartBoneTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
