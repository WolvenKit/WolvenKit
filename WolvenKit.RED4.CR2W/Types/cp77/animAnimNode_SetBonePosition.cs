using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetBonePosition : animAnimNode_OnePoseInput
	{
		private animTransformIndex _bone;
		private animVectorLink _positionMs;

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
		[RED("positionMs")] 
		public animVectorLink PositionMs
		{
			get
			{
				if (_positionMs == null)
				{
					_positionMs = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "positionMs", cr2w, this);
				}
				return _positionMs;
			}
			set
			{
				if (_positionMs == value)
				{
					return;
				}
				_positionMs = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SetBonePosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
