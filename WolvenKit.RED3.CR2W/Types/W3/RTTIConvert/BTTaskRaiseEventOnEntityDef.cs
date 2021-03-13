using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskRaiseEventOnEntityDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("entityTag")] 		public CName EntityTag { get; set;}

		[Ordinal(2)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(3)] [RED("forceEvent")] 		public CBool ForceEvent { get; set;}

		[Ordinal(4)] [RED("maxDistFromNpc")] 		public CFloat MaxDistFromNpc { get; set;}

		[Ordinal(5)] [RED("raiseSameEventOnOwner")] 		public CBool RaiseSameEventOnOwner { get; set;}

		public BTTaskRaiseEventOnEntityDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskRaiseEventOnEntityDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}