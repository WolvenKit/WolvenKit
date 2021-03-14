using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITrafficExternalWorkspotDefinition : worldTrafficSpotDefinition
	{
		private CBool _nearestPointEntry;
		private NodeRef _globalWorkspotNodeRef;

		[Ordinal(2)] 
		[RED("nearestPointEntry")] 
		public CBool NearestPointEntry
		{
			get
			{
				if (_nearestPointEntry == null)
				{
					_nearestPointEntry = (CBool) CR2WTypeManager.Create("Bool", "nearestPointEntry", cr2w, this);
				}
				return _nearestPointEntry;
			}
			set
			{
				if (_nearestPointEntry == value)
				{
					return;
				}
				_nearestPointEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("globalWorkspotNodeRef")] 
		public NodeRef GlobalWorkspotNodeRef
		{
			get
			{
				if (_globalWorkspotNodeRef == null)
				{
					_globalWorkspotNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "globalWorkspotNodeRef", cr2w, this);
				}
				return _globalWorkspotNodeRef;
			}
			set
			{
				if (_globalWorkspotNodeRef == value)
				{
					return;
				}
				_globalWorkspotNodeRef = value;
				PropertySet(this);
			}
		}

		public AITrafficExternalWorkspotDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
