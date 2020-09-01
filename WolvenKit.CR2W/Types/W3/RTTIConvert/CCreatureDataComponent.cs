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
		[Ordinal(0)] [RED("("itemsUsedAgainstCreature", 2,0)] 		public CArray<CName> ItemsUsedAgainstCreature { get; set;}

		[Ordinal(0)] [RED("("skillsUsedAgainstCreature", 2,0)] 		public CArray<CName> SkillsUsedAgainstCreature { get; set;}

		[Ordinal(0)] [RED("("cameraDistance")] 		public CFloat CameraDistance { get; set;}

		[Ordinal(0)] [RED("("cameraLookAtZ")] 		public CFloat CameraLookAtZ { get; set;}

		[Ordinal(0)] [RED("("cameraRotationYaw")] 		public CFloat CameraRotationYaw { get; set;}

		[Ordinal(0)] [RED("("cameraRotationPitch")] 		public CFloat CameraRotationPitch { get; set;}

		[Ordinal(0)] [RED("("environmentSunRotationYaw")] 		public CFloat EnvironmentSunRotationYaw { get; set;}

		[Ordinal(0)] [RED("("environmentSunRotationPitch")] 		public CFloat EnvironmentSunRotationPitch { get; set;}

		[Ordinal(0)] [RED("("appearance")] 		public CName Appearance { get; set;}

		[Ordinal(0)] [RED("("position")] 		public Vector Position { get; set;}

		[Ordinal(0)] [RED("("scale")] 		public CFloat Scale { get; set;}

		[Ordinal(0)] [RED("("fov")] 		public CFloat Fov { get; set;}

		public CCreatureDataComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCreatureDataComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}