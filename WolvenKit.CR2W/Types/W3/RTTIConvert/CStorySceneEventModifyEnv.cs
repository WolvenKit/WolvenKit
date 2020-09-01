using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventModifyEnv : CStorySceneEvent
	{
		[Ordinal(0)] [RED("environmentDefinition")] 		public CHandle<CEnvironmentDefinition> EnvironmentDefinition { get; set;}

		[Ordinal(0)] [RED("activate")] 		public CBool Activate { get; set;}

		[Ordinal(0)] [RED("priority")] 		public CInt32 Priority { get; set;}

		[Ordinal(0)] [RED("blendFactor")] 		public CFloat BlendFactor { get; set;}

		[Ordinal(0)] [RED("blendInTime")] 		public CFloat BlendInTime { get; set;}

		public CStorySceneEventModifyEnv(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventModifyEnv(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}