using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskGameplayEventListener : IBehTreeTask
	{
		[Ordinal(0)] [RED("validFor")] 		public CFloat ValidFor { get; set;}

		[Ordinal(0)] [RED("activeFor")] 		public CFloat ActiveFor { get; set;}

		[Ordinal(0)] [RED("activate")] 		public CBool Activate { get; set;}

		[Ordinal(0)] [RED("eventTime")] 		public CFloat EventTime { get; set;}

		[Ordinal(0)] [RED("eventNam")] 		public CName EventNam { get; set;}

		[Ordinal(0)] [RED("activationTime")] 		public CFloat ActivationTime { get; set;}

		[Ordinal(0)] [RED("clearOnEvent")] 		public CName ClearOnEvent { get; set;}

		public BTTaskGameplayEventListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskGameplayEventListener(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}