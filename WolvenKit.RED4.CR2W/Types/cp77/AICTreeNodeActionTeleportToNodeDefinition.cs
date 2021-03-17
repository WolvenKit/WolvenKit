using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionTeleportToNodeDefinition : AICTreeNodeActionDefinition
	{
		private LibTreeDefNodeRef _nodeRef;
		private LibTreeDefVector _offset;
		private CBool _doNavTest;

		[Ordinal(1)] 
		[RED("nodeRef")] 
		public LibTreeDefNodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public LibTreeDefVector Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(3)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get => GetProperty(ref _doNavTest);
			set => SetProperty(ref _doNavTest, value);
		}

		public AICTreeNodeActionTeleportToNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
