using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimCutsceneEnvironmentEvent : CExtAnimEvent
	{
		[RED("stabilizeBlending")] 		public CBool StabilizeBlending { get; set;}

		[RED("instantEyeAdaptation")] 		public CBool InstantEyeAdaptation { get; set;}

		[RED("instantDissolve")] 		public CBool InstantDissolve { get; set;}

		[RED("forceSetupLocalEnvironments")] 		public CBool ForceSetupLocalEnvironments { get; set;}

		[RED("forceSetupGlobalEnvironments")] 		public CBool ForceSetupGlobalEnvironments { get; set;}

		[RED("environmentName")] 		public CString EnvironmentName { get; set;}

		[RED("environmentActivate")] 		public CBool EnvironmentActivate { get; set;}

		[RED("forceNoOtherEnvironments")] 		public CBool ForceNoOtherEnvironments { get; set;}

		public CExtAnimCutsceneEnvironmentEvent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExtAnimCutsceneEnvironmentEvent(cr2w);

	}
}