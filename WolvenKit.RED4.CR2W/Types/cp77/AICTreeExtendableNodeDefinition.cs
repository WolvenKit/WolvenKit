using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeExtendableNodeDefinition : AICTreeNodeDefinition
	{
		private CHandle<LibTreeINodeDefinition> _optionalChild;

		[Ordinal(0)] 
		[RED("optionalChild")] 
		public CHandle<LibTreeINodeDefinition> OptionalChild
		{
			get => GetProperty(ref _optionalChild);
			set => SetProperty(ref _optionalChild, value);
		}

		public AICTreeExtendableNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
