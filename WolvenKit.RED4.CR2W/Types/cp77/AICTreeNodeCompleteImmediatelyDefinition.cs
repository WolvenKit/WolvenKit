using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeCompleteImmediatelyDefinition : AICTreeNodeAtomicDefinition
	{
		private CBool _completeWithSuccess;

		[Ordinal(0)] 
		[RED("completeWithSuccess")] 
		public CBool CompleteWithSuccess
		{
			get
			{
				if (_completeWithSuccess == null)
				{
					_completeWithSuccess = (CBool) CR2WTypeManager.Create("Bool", "completeWithSuccess", cr2w, this);
				}
				return _completeWithSuccess;
			}
			set
			{
				if (_completeWithSuccess == value)
				{
					return;
				}
				_completeWithSuccess = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeCompleteImmediatelyDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
