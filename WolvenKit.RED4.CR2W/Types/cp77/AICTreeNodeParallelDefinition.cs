using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeParallelDefinition : AICTreeNodeChildrenListDefinition
	{
		private CBool _forwardChildrenCompleteness;

		[Ordinal(1)] 
		[RED("forwardChildrenCompleteness")] 
		public CBool ForwardChildrenCompleteness
		{
			get
			{
				if (_forwardChildrenCompleteness == null)
				{
					_forwardChildrenCompleteness = (CBool) CR2WTypeManager.Create("Bool", "forwardChildrenCompleteness", cr2w, this);
				}
				return _forwardChildrenCompleteness;
			}
			set
			{
				if (_forwardChildrenCompleteness == value)
				{
					return;
				}
				_forwardChildrenCompleteness = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeParallelDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
