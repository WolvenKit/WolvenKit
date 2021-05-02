using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimCutsceneEnvironmentEvent : CExtAnimEvent
	{
		[Ordinal(1)] [RED("stabilizeBlending")] 		public CBool StabilizeBlending { get; set;}

		[Ordinal(2)] [RED("instantEyeAdaptation")] 		public CBool InstantEyeAdaptation { get; set;}

		[Ordinal(3)] [RED("instantDissolve")] 		public CBool InstantDissolve { get; set;}

		[Ordinal(4)] [RED("forceSetupLocalEnvironments")] 		public CBool ForceSetupLocalEnvironments { get; set;}

		[Ordinal(5)] [RED("forceSetupGlobalEnvironments")] 		public CBool ForceSetupGlobalEnvironments { get; set;}

		[Ordinal(6)] [RED("environmentName")] 		public CString EnvironmentName { get; set;}

		[Ordinal(7)] [RED("environmentActivate")] 		public CBool EnvironmentActivate { get; set;}

		[Ordinal(8)] [RED("forceNoOtherEnvironments")] 		public CBool ForceNoOtherEnvironments { get; set;}

		public CExtAnimCutsceneEnvironmentEvent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}