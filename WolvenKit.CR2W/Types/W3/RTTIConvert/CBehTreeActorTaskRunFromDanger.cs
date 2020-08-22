using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeActorTaskRunFromDanger : IBehTreeTask
	{
		[RED("dangerRadius")] 		public CFloat DangerRadius { get; set;}

		[RED("fleeDistance")] 		public CFloat FleeDistance { get; set;}

		[RED("dangerNode")] 		public CHandle<CNode> DangerNode { get; set;}

		[RED("pursue")] 		public CBool Pursue { get; set;}

		public CBehTreeActorTaskRunFromDanger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeActorTaskRunFromDanger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}