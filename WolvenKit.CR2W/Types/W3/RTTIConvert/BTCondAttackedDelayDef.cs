using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondAttackedDelayDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(1)] [RED("delay")] 		public CFloat Delay { get; set;}

		[Ordinal(2)] [RED("completeIfAttacked")] 		public CBool CompleteIfAttacked { get; set;}

		[Ordinal(3)] [RED("wasHit")] 		public CBool WasHit { get; set;}

		public BTCondAttackedDelayDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondAttackedDelayDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}