using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetBoneOrientation : animAnimNode_OnePoseInput
	{
		private animTransformIndex _bone;
		private animQuaternionLink _orientationMs;

		[Ordinal(12)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get
			{
				if (_bone == null)
				{
					_bone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "bone", cr2w, this);
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

		[Ordinal(13)] 
		[RED("orientationMs")] 
		public animQuaternionLink OrientationMs
		{
			get
			{
				if (_orientationMs == null)
				{
					_orientationMs = (animQuaternionLink) CR2WTypeManager.Create("animQuaternionLink", "orientationMs", cr2w, this);
				}
				return _orientationMs;
			}
			set
			{
				if (_orientationMs == value)
				{
					return;
				}
				_orientationMs = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SetBoneOrientation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
