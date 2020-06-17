using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestScopeBlock : CQuestGraphBlock
	{
		[RED("phase")] 		public CHandle<CQuestPhase> Phase { get; set;}

		[RED("embeddedGraph")] 		public CPtr<CQuestGraph> EmbeddedGraph { get; set;}

		[RED("phaseHandle")] 		public CSoft<CQuestPhase> PhaseHandle { get; set;}

		[RED("requiredWorld")] 		public CString RequiredWorld { get; set;}

		public CQuestScopeBlock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestScopeBlock(cr2w);

	}
}