using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneActorPosition : CVariable
	{
		[Ordinal(1)] [RED("position")] 		public TagList Position { get; set;}

		[Ordinal(2)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(3)] [RED("useRotation")] 		public CBool UseRotation { get; set;}

		[Ordinal(4)] [RED("performAction")] 		public CEnum<EStoryScenePerformActionMode> PerformAction { get; set;}

		public CStorySceneActorPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneActorPosition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}