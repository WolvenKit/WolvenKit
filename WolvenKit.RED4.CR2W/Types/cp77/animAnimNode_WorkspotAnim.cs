using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_WorkspotAnim : animAnimNode_Base
	{
		private CBool _collectEvents;
		private animPoseLink _inputLink;

		[Ordinal(11)] 
		[RED("collectEvents")] 
		public CBool CollectEvents
		{
			get
			{
				if (_collectEvents == null)
				{
					_collectEvents = (CBool) CR2WTypeManager.Create("Bool", "collectEvents", cr2w, this);
				}
				return _collectEvents;
			}
			set
			{
				if (_collectEvents == value)
				{
					return;
				}
				_collectEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		public animAnimNode_WorkspotAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
