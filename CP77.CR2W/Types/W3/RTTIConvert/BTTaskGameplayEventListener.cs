using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskGameplayEventListener : IBehTreeTask
	{
		[Ordinal(1)] [RED("validFor")] 		public CFloat ValidFor { get; set;}

		[Ordinal(2)] [RED("activeFor")] 		public CFloat ActiveFor { get; set;}

		[Ordinal(3)] [RED("activate")] 		public CBool Activate { get; set;}

		[Ordinal(4)] [RED("eventTime")] 		public CFloat EventTime { get; set;}

		[Ordinal(5)] [RED("eventNam")] 		public CName EventNam { get; set;}

		[Ordinal(6)] [RED("activationTime")] 		public CFloat ActivationTime { get; set;}

		[Ordinal(7)] [RED("clearOnEvent")] 		public CName ClearOnEvent { get; set;}

		public BTTaskGameplayEventListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskGameplayEventListener(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}