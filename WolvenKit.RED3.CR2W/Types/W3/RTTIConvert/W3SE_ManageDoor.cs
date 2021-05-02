using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_ManageDoor : W3SwitchEvent
	{
		[Ordinal(1)] [RED("doorTag")] 		public CName DoorTag { get; set;}

		[Ordinal(2)] [RED("operations", 2,0)] 		public CArray<CEnum<EDoorOperation>> Operations { get; set;}

		[Ordinal(3)] [RED("force")] 		public CBool Force { get; set;}

		public W3SE_ManageDoor(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}