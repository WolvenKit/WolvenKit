using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeActorTaskRunFromDanger : IBehTreeTask
	{
		[Ordinal(1)] [RED("dangerRadius")] 		public CFloat DangerRadius { get; set;}

		[Ordinal(2)] [RED("fleeDistance")] 		public CFloat FleeDistance { get; set;}

		[Ordinal(3)] [RED("dangerNode")] 		public CHandle<CNode> DangerNode { get; set;}

		[Ordinal(4)] [RED("pursue")] 		public CBool Pursue { get; set;}

		public CBehTreeActorTaskRunFromDanger(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeActorTaskRunFromDanger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}