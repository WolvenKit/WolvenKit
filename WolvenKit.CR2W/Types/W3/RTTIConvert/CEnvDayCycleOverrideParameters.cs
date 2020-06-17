using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvDayCycleOverrideParameters : CVariable
	{
		[RED("fakeDayCycleEnable")] 		public CBool FakeDayCycleEnable { get; set;}

		[RED("fakeDayCycleHour")] 		public CFloat FakeDayCycleHour { get; set;}

		[RED("enableCustomSunRotation")] 		public CBool EnableCustomSunRotation { get; set;}

		[RED("customSunRotation")] 		public EulerAngles CustomSunRotation { get; set;}

		public CEnvDayCycleOverrideParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEnvDayCycleOverrideParameters(cr2w);

	}
}