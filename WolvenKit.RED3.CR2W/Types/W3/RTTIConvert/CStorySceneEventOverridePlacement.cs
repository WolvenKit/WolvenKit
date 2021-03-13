using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventOverridePlacement : CStorySceneEvent
	{
		[Ordinal(1)] [RED("actorName")] 		public CName ActorName { get; set;}

		[Ordinal(2)] [RED("placement")] 		public EngineTransform Placement { get; set;}

		[Ordinal(3)] [RED("resetCloth")] 		public CEnum<EDialogResetClothAndDanglesType> ResetCloth { get; set;}

		public CStorySceneEventOverridePlacement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventOverridePlacement(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}