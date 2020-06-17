using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeActorTaskRunFromDangerDef : IBehTreeTaskDefinition
	{
		[RED("dangerRadius")] 		public CFloat DangerRadius { get; set;}

		[RED("fleeDistance")] 		public CFloat FleeDistance { get; set;}

		[RED("pursue")] 		public CBool Pursue { get; set;}

		public CBehTreeActorTaskRunFromDangerDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeActorTaskRunFromDangerDef(cr2w);

	}
}