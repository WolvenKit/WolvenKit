using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CClimbType : CVariable
	{
		[RED("requiredState")] 		public CEnum<EClimbRequirementType> RequiredState { get; set;}

		[RED("requiredVault")] 		public CEnum<EClimbRequirementVault> RequiredVault { get; set;}

		[RED("requiredPlatform")] 		public CEnum<EClimbRequirementPlatform> RequiredPlatform { get; set;}

		[RED("type")] 		public CEnum<EClimbHeightType> Type { get; set;}

		[RED("heightUseDefaults")] 		public CBool HeightUseDefaults { get; set;}

		[RED("heightMax")] 		public CFloat HeightMax { get; set;}

		[RED("heightMin")] 		public CFloat HeightMin { get; set;}

		[RED("heightExact")] 		public CFloat HeightExact { get; set;}

		[RED("forwardDistExact")] 		public CFloat ForwardDistExact { get; set;}

		[RED("playCameraAnimation")] 		public CBool PlayCameraAnimation { get; set;}

		[RED("cameraAnimation")] 		public CName CameraAnimation { get; set;}

		public CClimbType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CClimbType(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}