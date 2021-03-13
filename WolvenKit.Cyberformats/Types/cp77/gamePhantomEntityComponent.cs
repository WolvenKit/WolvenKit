using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePhantomEntityComponent : entIComponent
	{
		[Ordinal(3)] [RED("params")] public gamePhantomEntityParameters Params { get; set; }
		[Ordinal(4)] [RED("effectBinding")] public CHandle<gameEffectComponentBinding> EffectBinding { get; set; }

		public gamePhantomEntityComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
