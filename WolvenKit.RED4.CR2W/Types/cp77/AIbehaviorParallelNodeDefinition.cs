using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorParallelNodeDefinition : AIbehaviorCompositeTreeNodeDefinition
	{
		private CEnum<AIbehaviorParallelNodeWaitFor> _waitFor;

		[Ordinal(1)] 
		[RED("waitFor")] 
		public CEnum<AIbehaviorParallelNodeWaitFor> WaitFor
		{
			get
			{
				if (_waitFor == null)
				{
					_waitFor = (CEnum<AIbehaviorParallelNodeWaitFor>) CR2WTypeManager.Create("AIbehaviorParallelNodeWaitFor", "waitFor", cr2w, this);
				}
				return _waitFor;
			}
			set
			{
				if (_waitFor == value)
				{
					return;
				}
				_waitFor = value;
				PropertySet(this);
			}
		}

		public AIbehaviorParallelNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
