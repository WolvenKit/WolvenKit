using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DrawBetweenEntitiesEvent : redEvent
	{
		[Ordinal(0)] [RED("shouldDraw")] public CBool ShouldDraw { get; set; }
		[Ordinal(1)] [RED("fxResource")] public gameFxResource FxResource { get; set; }
		[Ordinal(2)] [RED("revealMaster")] public CBool RevealMaster { get; set; }
		[Ordinal(3)] [RED("revealSlave")] public CBool RevealSlave { get; set; }
		[Ordinal(4)] [RED("masterEntity")] public entEntityID MasterEntity { get; set; }
		[Ordinal(5)] [RED("slaveEntity")] public entEntityID SlaveEntity { get; set; }

		public DrawBetweenEntitiesEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
