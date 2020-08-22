using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3EnvironmentManager : CObject
	{
		[RED("m_envId")] 		public CInt32 M_envId { get; set;}

		[RED("lunation")] 		public CInt32 Lunation { get; set;}

		[RED("dayStart")] 		public CInt32 DayStart { get; set;}

		[RED("nightStart")] 		public CInt32 NightStart { get; set;}

		[RED("redMoonPeriod")] 		public CInt32 RedMoonPeriod { get; set;}

		[RED("hourToSwitchEnv")] 		public CInt32 HourToSwitchEnv { get; set;}

		public W3EnvironmentManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3EnvironmentManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}