using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CClimbType : CVariable
	{
		[Ordinal(0)] [RED("requiredState")] 		public CEnum<EClimbRequirementType> RequiredState { get; set;}

		[Ordinal(0)] [RED("requiredVault")] 		public CEnum<EClimbRequirementVault> RequiredVault { get; set;}

		[Ordinal(0)] [RED("requiredPlatform")] 		public CEnum<EClimbRequirementPlatform> RequiredPlatform { get; set;}

		[Ordinal(0)] [RED("type")] 		public CEnum<EClimbHeightType> Type { get; set;}

		[Ordinal(0)] [RED("heightUseDefaults")] 		public CBool HeightUseDefaults { get; set;}

		[Ordinal(0)] [RED("heightMax")] 		public CFloat HeightMax { get; set;}

		[Ordinal(0)] [RED("heightMin")] 		public CFloat HeightMin { get; set;}

		[Ordinal(0)] [RED("heightExact")] 		public CFloat HeightExact { get; set;}

		[Ordinal(0)] [RED("forwardDistExact")] 		public CFloat ForwardDistExact { get; set;}

		[Ordinal(0)] [RED("playCameraAnimation")] 		public CBool PlayCameraAnimation { get; set;}

		[Ordinal(0)] [RED("cameraAnimation")] 		public CName CameraAnimation { get; set;}

		public CClimbType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CClimbType(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}