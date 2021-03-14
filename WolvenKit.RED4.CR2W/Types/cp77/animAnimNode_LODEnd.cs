using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LODEnd : animAnimNode_Base
	{
		private animPoseLink _inputLink;

		[Ordinal(11)] 
		[RED("inputLink")] 
		public animPoseLink InputLink
		{
			get
			{
				if (_inputLink == null)
				{
					_inputLink = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "inputLink", cr2w, this);
				}
				return _inputLink;
			}
			set
			{
				if (_inputLink == value)
				{
					return;
				}
				_inputLink = value;
				PropertySet(this);
			}
		}

		public animAnimNode_LODEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
