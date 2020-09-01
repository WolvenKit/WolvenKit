using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcVesemirTutorialTacticTreeParams : CAINpcTacticTreeParams
	{
		[Ordinal(0)] [RED("backgroundTraining")] 		public CBool BackgroundTraining { get; set;}

		[Ordinal(0)] [RED("onlyBlock")] 		public CBool OnlyBlock { get; set;}

		[Ordinal(0)] [RED("onlyBlocksWithQuen")] 		public CBool OnlyBlocksWithQuen { get; set;}

		[Ordinal(0)] [RED("useAttacks")] 		public CBool UseAttacks { get; set;}

		[Ordinal(0)] [RED("useCombos")] 		public CBool UseCombos { get; set;}

		[Ordinal(0)] [RED("forceIdle")] 		public CBool ForceIdle { get; set;}

		[Ordinal(0)] [RED("attacksInterval")] 		public CFloat AttacksInterval { get; set;}

		[Ordinal(0)] [RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		public CAINpcVesemirTutorialTacticTreeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAINpcVesemirTutorialTacticTreeParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}