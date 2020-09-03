using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CScheduledUsableEntity : CUsableEntity
	{
		[Ordinal(1)] [RED("bUseSwitchingSchedule")] 		public CBool BUseSwitchingSchedule { get; set;}

		[Ordinal(2)] [RED("switchOnHour")] 		public CInt32 SwitchOnHour { get; set;}

		[Ordinal(3)] [RED("switchOffHour")] 		public CInt32 SwitchOffHour { get; set;}

		public CScheduledUsableEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CScheduledUsableEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}