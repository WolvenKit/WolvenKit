using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3EnvironmentManager : CObject
	{
		[Ordinal(1)] [RED("m_envId")] 		public CInt32 M_envId { get; set;}

		[Ordinal(2)] [RED("lunation")] 		public CInt32 Lunation { get; set;}

		[Ordinal(3)] [RED("dayStart")] 		public CInt32 DayStart { get; set;}

		[Ordinal(4)] [RED("nightStart")] 		public CInt32 NightStart { get; set;}

		[Ordinal(5)] [RED("redMoonPeriod")] 		public CInt32 RedMoonPeriod { get; set;}

		[Ordinal(6)] [RED("hourToSwitchEnv")] 		public CInt32 HourToSwitchEnv { get; set;}

		public W3EnvironmentManager(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3EnvironmentManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}