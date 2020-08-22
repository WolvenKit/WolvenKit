using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_GlobalAttitude : CQuestScriptedCondition
	{
		[RED("srcGroup")] 		public CName SrcGroup { get; set;}

		[RED("dstGroup")] 		public CName DstGroup { get; set;}

		[RED("attitude")] 		public CEnum<EAIAttitude> Attitude { get; set;}

		public W3QuestCond_GlobalAttitude(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_GlobalAttitude(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}