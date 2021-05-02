using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeDeflectAttackEvents : MeleeAttackGenericEvents
	{
		private CBool _slowMoSet;

		[Ordinal(8)] 
		[RED("slowMoSet")] 
		public CBool SlowMoSet
		{
			get => GetProperty(ref _slowMoSet);
			set => SetProperty(ref _slowMoSet, value);
		}

		public MeleeDeflectAttackEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
