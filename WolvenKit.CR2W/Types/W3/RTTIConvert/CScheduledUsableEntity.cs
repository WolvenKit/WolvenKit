using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CScheduledUsableEntity : CUsableEntity
	{
		[RED("bUseSwitchingSchedule")] 		public CBool BUseSwitchingSchedule { get; set;}

		[RED("switchOnHour")] 		public CInt32 SwitchOnHour { get; set;}

		[RED("switchOffHour")] 		public CInt32 SwitchOffHour { get; set;}

		public CScheduledUsableEntity(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CScheduledUsableEntity(cr2w);

	}
}