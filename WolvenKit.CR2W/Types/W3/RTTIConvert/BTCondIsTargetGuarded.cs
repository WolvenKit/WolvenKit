using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondIsTargetGuarded : IBehTreeTask
	{
		[Ordinal(0)] [RED("longerThan")] 		public CFloat LongerThan { get; set;}

		[Ordinal(0)] [RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[Ordinal(0)] [RED("guardedRegistered")] 		public CBool GuardedRegistered { get; set;}

		public BTCondIsTargetGuarded(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondIsTargetGuarded(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}