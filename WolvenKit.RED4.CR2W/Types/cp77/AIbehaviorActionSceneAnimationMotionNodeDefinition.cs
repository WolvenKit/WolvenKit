using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSceneAnimationMotionNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _params;
		private CHandle<AIArgumentMapping> _mountData;

		[Ordinal(1)] 
		[RED("params")] 
		public CHandle<AIArgumentMapping> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
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

		public AIbehaviorActionSceneAnimationMotionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
