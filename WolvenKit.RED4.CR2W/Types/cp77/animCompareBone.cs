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
			get
			{
				if (_boneName == null)
				{
					_boneName = (CName) CR2WTypeManager.Create("CName", "boneName", cr2w, this);
				}
				return _boneName;
			}
			set
			{
				if (_boneName == value)
				{
					return;
				}
				_boneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("boneRotationLs")] 
		public Quaternion BoneRotationLs
		{
			get
			{
				if (_boneRotationLs == null)
				{
					_boneRotationLs = (Quaternion) CR2WTypeManager.Create("Quaternion", "boneRotationLs", cr2w, this);
				}
				return _boneRotationLs;
			}
			set
			{
				if (_boneRotationLs == value)
				{
					return;
				}
				_boneRotationLs = value;
				PropertySet(this);
			}
		}

		public animCompareBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
