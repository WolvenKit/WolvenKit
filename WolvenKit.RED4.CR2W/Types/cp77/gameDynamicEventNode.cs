using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDynamicEventNode : worldAreaShapeNode
	{
		private NodeRef _mappinRef;
		private CHandle<questIBaseCondition> _condition;

		[Ordinal(6)] 
		[RED("mappinRef")] 
		public NodeRef MappinRef
		{
			get => GetProperty(ref _mappinRef);
			set => SetProperty(ref _mappinRef, value);
		}

		[Ordinal(7)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		public gameDynamicEventNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
