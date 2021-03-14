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
		[RED("amountOfRotation")] 
		public CFloat AmountOfRotation
		{
			get
			{
				if (_amountOfRotation == null)
				{
					_amountOfRotation = (CFloat) CR2WTypeManager.Create("Float", "amountOfRotation", cr2w, this);
				}
				return _amountOfRotation;
			}
			set
			{
				if (_amountOfRotation == value)
				{
					return;
				}
				_amountOfRotation = value;
				PropertySet(this);
			}
		}

		public animSBehaviorConstraintNodeFloorIKMaintainLookBoneData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
