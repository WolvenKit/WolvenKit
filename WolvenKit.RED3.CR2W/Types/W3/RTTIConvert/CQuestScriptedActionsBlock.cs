using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestScriptedActionsBlock : CBaseQuestScriptedActionsBlock
	{
		[Ordinal(1)] [RED("ai")] 		public CHandle<IAIActionTree> Ai { get; set;}

		[Ordinal(2)] [RED("actions", 2,0)] 		public CArray<CPtr<IActorLatentAction>> Actions { get; set;}

		public CQuestScriptedActionsBlock(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestScriptedActionsBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}