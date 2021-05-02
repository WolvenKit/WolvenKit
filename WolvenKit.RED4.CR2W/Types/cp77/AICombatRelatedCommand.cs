using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICombatRelatedCommand : AICommand
	{
		private CBool _immediately;

		[Ordinal(4)] 
		[RED("immediately")] 
		public CBool Immediately
		{
			get => GetProperty(ref _immediately);
			set => SetProperty(ref _immediately, value);
		}

		public AICombatRelatedCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
