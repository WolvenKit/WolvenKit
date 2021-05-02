using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondActorInDangerDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(1)] [RED("dangerRadius")] 		public CFloat DangerRadius { get; set;}

		[Ordinal(2)] [RED("checkQuestRequests")] 		public CBool CheckQuestRequests { get; set;}

		[Ordinal(3)] [RED("ignoreEntityWithTag")] 		public CName IgnoreEntityWithTag { get; set;}

		public CBTCondActorInDangerDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondActorInDangerDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}