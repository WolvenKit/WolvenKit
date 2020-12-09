using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskRaiseEventOnEntity : IBehTreeTask
	{
		[Ordinal(1)] [RED("entityTag")] 		public CName EntityTag { get; set;}

		[Ordinal(2)] [RED("eventName")] 		public CName EventName { get; set;}

		[Ordinal(3)] [RED("forceEvent")] 		public CBool ForceEvent { get; set;}

		[Ordinal(4)] [RED("maxDistFromNpc")] 		public CFloat MaxDistFromNpc { get; set;}

		[Ordinal(5)] [RED("raiseSameEventOnOwner")] 		public CBool RaiseSameEventOnOwner { get; set;}

		public BTTaskRaiseEventOnEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskRaiseEventOnEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}