using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSlideToWorldPositionNodeDefinition : AIbehaviorActionSlideNodeDefinition
	{
		private CHandle<AIArgumentMapping> _worldPosition;
		private CBool _useMovePlanner;

		[Ordinal(4)] 
		[RED("worldPosition")] 
		public CHandle<AIArgumentMapping> WorldPosition
		{
			get
			{
				if (_worldPosition == null)
				{
					_worldPosition = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "worldPosition", cr2w, this);
				}
				return _worldPosition;
			}
			set
			{
				if (_worldPosition == value)
				{
					return;
				}
				_worldPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("useMovePlanner")] 
		public CBool UseMovePlanner
		{
			get
			{
				if (_useMovePlanner == null)
				{
					_useMovePlanner = (CBool) CR2WTypeManager.Create("Bool", "useMovePlanner", cr2w, this);
				}
				return _useMovePlanner;
			}
			set
			{
				if (_useMovePlanner == value)
				{
					return;
				}
				_useMovePlanner = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionSlideToWorldPositionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
