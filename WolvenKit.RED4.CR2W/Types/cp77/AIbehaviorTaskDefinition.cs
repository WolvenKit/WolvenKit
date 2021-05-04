using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTaskDefinition : ISerializable
	{
		private CBool _ignoreTaskCompletion;

		[Ordinal(0)] 
		[RED("ignoreTaskCompletion")] 
		public CBool IgnoreTaskCompletion
		{
			get => GetProperty(ref _ignoreTaskCompletion);
			set => SetProperty(ref _ignoreTaskCompletion, value);
		}

		public AIbehaviorTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
