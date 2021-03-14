using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionRotateToObjectTreeNodeDefinition : AIbehaviorActionRotateBaseTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _completeWhenRotated;

		[Ordinal(5)] 
		[RED("completeWhenRotated")] 
		public CHandle<AIArgumentMapping> CompleteWhenRotated
		{
			get
			{
				if (_completeWhenRotated == null)
				{
					_completeWhenRotated = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "completeWhenRotated", cr2w, this);
				}
				return _completeWhenRotated;
			}
			set
			{
				if (_completeWhenRotated == value)
				{
					return;
				}
				_completeWhenRotated = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionRotateToObjectTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
