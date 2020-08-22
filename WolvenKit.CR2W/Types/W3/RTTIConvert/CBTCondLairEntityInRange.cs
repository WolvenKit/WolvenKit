using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondLairEntityInRange : IBehTreeTask
	{
		[RED("lair")] 		public CHandle<CFlyingSwarmMasterLair> Lair { get; set;}

		[RED("checkCount")] 		public CInt32 CheckCount { get; set;}

		[RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		public CBTCondLairEntityInRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondLairEntityInRange(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}