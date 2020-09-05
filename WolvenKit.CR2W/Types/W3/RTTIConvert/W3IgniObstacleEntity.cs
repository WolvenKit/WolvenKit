using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3IgniObstacleEntity : CInteractiveEntity
	{
		[Ordinal(1)] [RED("staticIgniObstacle")] 		public CHandle<CComponent> StaticIgniObstacle { get; set;}

		[Ordinal(2)] [RED("iceWallStage1")] 		public CHandle<CDrawableComponent> IceWallStage1 { get; set;}

		[Ordinal(3)] [RED("iceWallStage2")] 		public CHandle<CDrawableComponent> IceWallStage2 { get; set;}

		[Ordinal(4)] [RED("iceWallStage2Melted")] 		public CHandle<CDrawableComponent> IceWallStage2Melted { get; set;}

		[Ordinal(5)] [RED("iceWallStage3")] 		public CHandle<CDrawableComponent> IceWallStage3 { get; set;}

		[Ordinal(6)] [RED("iceWallStage3Melted")] 		public CHandle<CDrawableComponent> IceWallStage3Melted { get; set;}

		public W3IgniObstacleEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3IgniObstacleEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}