using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGuiSceneDescription : CVariable
	{
		[Ordinal(1)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(2)] [RED("worldClass")] 		public CName WorldClass { get; set;}

		[Ordinal(3)] [RED("defaultEnvDef")] 		public CSoft<CEnvironmentDefinition> DefaultEnvDef { get; set;}

		[Ordinal(4)] [RED("defaultSunRotation")] 		public EulerAngles DefaultSunRotation { get; set;}

		[Ordinal(5)] [RED("enablePhysics")] 		public CBool EnablePhysics { get; set;}

		public SGuiSceneDescription(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}