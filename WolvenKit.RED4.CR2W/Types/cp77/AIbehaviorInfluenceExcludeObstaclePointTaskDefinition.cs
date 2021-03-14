using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorInfluenceExcludeObstaclePointTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _mountData;

		[Ordinal(1)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get
			{
				if (_workspotData == null)
				{
					_workspotData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "workspotData", cr2w, this);
				}
				return _workspotData;
			}
			set
			{
				if (_workspotData == value)
				{
					return;
				}
				_workspotData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get
			{
				if (_mountData == null)
				{
					_mountData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "mountData", cr2w, this);
				}
				return _mountData;
			}
			set
			{
				if (_mountData == value)
				{
					return;
				}
				_mountData = value;
				PropertySet(this);
			}
		}

		public AIbehaviorInfluenceExcludeObstaclePointTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
