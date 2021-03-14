using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigPartBone : CVariable
	{
		private CName _bone;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("bone")] 
		public CName Bone
		{
			get
			{
				if (_bone == null)
				{
					_bone = (CName) CR2WTypeManager.Create("CName", "bone", cr2w, this);
				}
				return _bone;
			}
			set
			{
				if (_bone == value)
				{
					return;
				}
				_bone = value;
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

		public animRigPartBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
