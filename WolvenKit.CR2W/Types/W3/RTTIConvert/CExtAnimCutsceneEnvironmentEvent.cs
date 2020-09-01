using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimCutsceneEnvironmentEvent : CExtAnimEvent
	{
		[Ordinal(0)] [RED("("stabilizeBlending")] 		public CBool StabilizeBlending { get; set;}

		[Ordinal(0)] [RED("("instantEyeAdaptation")] 		public CBool InstantEyeAdaptation { get; set;}

		[Ordinal(0)] [RED("("instantDissolve")] 		public CBool InstantDissolve { get; set;}

		[Ordinal(0)] [RED("("forceSetupLocalEnvironments")] 		public CBool ForceSetupLocalEnvironments { get; set;}

		[Ordinal(0)] [RED("("forceSetupGlobalEnvironments")] 		public CBool ForceSetupGlobalEnvironments { get; set;}

		[Ordinal(0)] [RED("("environmentName")] 		public CString EnvironmentName { get; set;}

		[Ordinal(0)] [RED("("environmentActivate")] 		public CBool EnvironmentActivate { get; set;}

		[Ordinal(0)] [RED("("forceNoOtherEnvironments")] 		public CBool ForceNoOtherEnvironments { get; set;}

		public CExtAnimCutsceneEnvironmentEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimCutsceneEnvironmentEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}