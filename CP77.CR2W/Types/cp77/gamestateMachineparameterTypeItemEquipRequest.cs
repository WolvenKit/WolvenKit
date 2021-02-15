using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeItemEquipRequest : IScriptable
	{
		[Ordinal(0)] [RED("slotId")] public TweakDBID SlotId { get; set; }
		[Ordinal(1)] [RED("itemId")] public gameItemID ItemId { get; set; }
		[Ordinal(2)] [RED("startingRenderingPlane")] public CEnum<ERenderingPlane> StartingRenderingPlane { get; set; }

		public gamestateMachineparameterTypeItemEquipRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
