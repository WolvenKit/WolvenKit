using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsReactionData : IScriptable
	{
		[Ordinal(0)]  [RED("IKPoint")] public Vector4 IKPoint { get; set; }
		[Ordinal(1)]  [RED("choiceName")] public CName ChoiceName { get; set; }
		[Ordinal(2)]  [RED("endDuration")] public CFloat EndDuration { get; set; }
		[Ordinal(3)]  [RED("interactionDuration")] public CFloat InteractionDuration { get; set; }
		[Ordinal(4)]  [RED("interactionPoint")] public Transform InteractionPoint { get; set; }
		[Ordinal(5)]  [RED("interactionType")] public CName InteractionType { get; set; }
		[Ordinal(6)]  [RED("requiredEquips")] public CArray<gameEquipParam> RequiredEquips { get; set; }
		[Ordinal(7)]  [RED("startDuration")] public CFloat StartDuration { get; set; }
		[Ordinal(8)]  [RED("useIK")] public CBool UseIK { get; set; }

		public gameinteractionsReactionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
