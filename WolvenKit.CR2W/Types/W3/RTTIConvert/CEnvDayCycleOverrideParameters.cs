using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvDayCycleOverrideParameters : CVariable
	{
		[Ordinal(0)] [RED("("fakeDayCycleEnable")] 		public CBool FakeDayCycleEnable { get; set;}

		[Ordinal(0)] [RED("("fakeDayCycleHour")] 		public CFloat FakeDayCycleHour { get; set;}

		[Ordinal(0)] [RED("("enableCustomSunRotation")] 		public CBool EnableCustomSunRotation { get; set;}

		[Ordinal(0)] [RED("("customSunRotation")] 		public EulerAngles CustomSunRotation { get; set;}

		public CEnvDayCycleOverrideParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvDayCycleOverrideParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}