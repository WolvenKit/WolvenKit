using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSlideToLocalPositionNodeDefinition : AIbehaviorActionSlideNodeDefinition
	{
		private CHandle<AIArgumentMapping> _localOffset;

		[Ordinal(4)] 
		[RED("localOffset")] 
		public CHandle<AIArgumentMapping> LocalOffset
		{
			get
			{
				if (_localOffset == null)
				{
					_localOffset = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "localOffset", cr2w, this);
				}
				return _localOffset;
			}
			set
			{
				if (_localOffset == value)
				{
					return;
				}
				_localOffset = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionSlideToLocalPositionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
