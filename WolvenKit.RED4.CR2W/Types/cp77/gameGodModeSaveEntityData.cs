using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGodModeSaveEntityData : CVariable
	{
		[Ordinal(0)] [RED("entityId")] public entEntityID EntityId { get; set; }
		[Ordinal(1)] [RED("data")] public gameGodModeEntityData Data { get; set; }

		public gameGodModeSaveEntityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
