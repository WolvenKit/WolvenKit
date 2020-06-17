using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAINpcVesemirTutorialTacticTreeParams : CAINpcTacticTreeParams
	{
		[RED("backgroundTraining")] 		public CBool BackgroundTraining { get; set;}

		[RED("onlyBlock")] 		public CBool OnlyBlock { get; set;}

		[RED("onlyBlocksWithQuen")] 		public CBool OnlyBlocksWithQuen { get; set;}

		[RED("useAttacks")] 		public CBool UseAttacks { get; set;}

		[RED("useCombos")] 		public CBool UseCombos { get; set;}

		[RED("forceIdle")] 		public CBool ForceIdle { get; set;}

		[RED("attacksInterval")] 		public CFloat AttacksInterval { get; set;}

		[RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		public CAINpcVesemirTutorialTacticTreeParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAINpcVesemirTutorialTacticTreeParams(cr2w);

	}
}