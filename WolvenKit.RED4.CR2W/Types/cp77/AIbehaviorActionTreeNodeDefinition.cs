using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionTreeNodeDefinition : AIbehaviorLeafTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _command;

		[Ordinal(0)] 
		[RED("command")] 
		public CHandle<AIArgumentMapping> Command
		{
			get => GetProperty(ref _command);
			set => SetProperty(ref _command, value);
		}

		public AIbehaviorActionTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
