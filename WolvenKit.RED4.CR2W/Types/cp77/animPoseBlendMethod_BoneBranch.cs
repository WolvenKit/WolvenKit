using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseBlendMethod_BoneBranch : animIPoseBlendMethod
	{
		private CArray<animOverrideBlendBoneInfo> _bones;

		[Ordinal(0)] 
		[RED("bones")] 
		public CArray<animOverrideBlendBoneInfo> Bones
		{
			get
			{
				if (_bones == null)
				{
					_bones = (CArray<animOverrideBlendBoneInfo>) CR2WTypeManager.Create("array:animOverrideBlendBoneInfo", "bones", cr2w, this);
				}
				return _bones;
			}
			set
			{
				if (_bones == value)
				{
					return;
				}
				_bones = value;
				PropertySet(this);
			}
		}

		public animPoseBlendMethod_BoneBranch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
