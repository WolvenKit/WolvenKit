using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneWaypointComponent : CComponent
	{
		[RED("dialogsetName")] 		public CName DialogsetName { get; set;}

		[RED("dialogset")] 		public CHandle<CStorySceneDialogset> Dialogset { get; set;}

		[RED("showCameras")] 		public CBool ShowCameras { get; set;}

		[RED("useDefaultDialogsetPositions")] 		public CBool UseDefaultDialogsetPositions { get; set;}

		public CStorySceneWaypointComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneWaypointComponent(cr2w);

	}
}