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
			get
			{
				if (_rootBone == null)
				{
					_rootBone = (CName) CR2WTypeManager.Create("CName", "rootBone", cr2w, this);
				}
				return _rootBone;
			}
			set
			{
				if (_rootBone == value)
				{
					return;
				}
				_rootBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("subtreesToChange")] 
		public CArray<animRigPartBoneTree> SubtreesToChange
		{
			get
			{
				if (_subtreesToChange == null)
				{
					_subtreesToChange = (CArray<animRigPartBoneTree>) CR2WTypeManager.Create("array:animRigPartBoneTree", "subtreesToChange", cr2w, this);
				}
				return _subtreesToChange;
			}
			set
			{
				if (_subtreesToChange == value)
				{
					return;
				}
				_subtreesToChange = value;
				PropertySet(this);
			}
		}

		public animRigPartBoneTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
