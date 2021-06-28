using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_GlobalAttitude : CQuestScriptedCondition
	{
		[Ordinal(1)] [RED("srcGroup")] 		public CName SrcGroup { get; set;}

		[Ordinal(2)] [RED("dstGroup")] 		public CName DstGroup { get; set;}

		[Ordinal(3)] [RED("attitude")] 		public CEnum<EAIAttitude> Attitude { get; set;}

		public W3QuestCond_GlobalAttitude(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}