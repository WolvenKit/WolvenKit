using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcVesemirTutorialTacticTreeParams : CAINpcTacticTreeParams
	{
		[Ordinal(1)] [RED("backgroundTraining")] 		public CBool BackgroundTraining { get; set;}

		[Ordinal(2)] [RED("onlyBlock")] 		public CBool OnlyBlock { get; set;}

		[Ordinal(3)] [RED("onlyBlocksWithQuen")] 		public CBool OnlyBlocksWithQuen { get; set;}

		[Ordinal(4)] [RED("useAttacks")] 		public CBool UseAttacks { get; set;}

		[Ordinal(5)] [RED("useCombos")] 		public CBool UseCombos { get; set;}

		[Ordinal(6)] [RED("forceIdle")] 		public CBool ForceIdle { get; set;}

		[Ordinal(7)] [RED("attacksInterval")] 		public CFloat AttacksInterval { get; set;}

		[Ordinal(8)] [RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		public CAINpcVesemirTutorialTacticTreeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcVesemirTutorialTacticTreeParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}