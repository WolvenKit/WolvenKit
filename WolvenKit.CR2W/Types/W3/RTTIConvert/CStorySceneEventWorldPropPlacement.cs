using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventWorldPropPlacement : CStorySceneEvent
	{
		[RED("propId")] 		public CName PropId { get; set;}

		[RED("placement")] 		public EngineTransform Placement { get; set;}

		[RED("showHide")] 		public CBool ShowHide { get; set;}

		public CStorySceneEventWorldPropPlacement(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventWorldPropPlacement(cr2w);

	}
}