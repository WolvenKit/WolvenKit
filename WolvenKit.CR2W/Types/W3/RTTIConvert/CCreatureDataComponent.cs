using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCreatureDataComponent : CScriptedComponent
	{
		[RED("itemsUsedAgainstCreature", 2,0)] 		public CArray<CName> ItemsUsedAgainstCreature { get; set;}

		[RED("skillsUsedAgainstCreature", 2,0)] 		public CArray<CName> SkillsUsedAgainstCreature { get; set;}

		[RED("cameraDistance")] 		public CFloat CameraDistance { get; set;}

		[RED("cameraLookAtZ")] 		public CFloat CameraLookAtZ { get; set;}

		[RED("cameraRotationYaw")] 		public CFloat CameraRotationYaw { get; set;}

		[RED("cameraRotationPitch")] 		public CFloat CameraRotationPitch { get; set;}

		[RED("environmentSunRotationYaw")] 		public CFloat EnvironmentSunRotationYaw { get; set;}

		[RED("environmentSunRotationPitch")] 		public CFloat EnvironmentSunRotationPitch { get; set;}

		[RED("appearance")] 		public CName Appearance { get; set;}

		[RED("position")] 		public Vector Position { get; set;}

		[RED("scale")] 		public CFloat Scale { get; set;}

		[RED("fov")] 		public CFloat Fov { get; set;}

		public CCreatureDataComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCreatureDataComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}