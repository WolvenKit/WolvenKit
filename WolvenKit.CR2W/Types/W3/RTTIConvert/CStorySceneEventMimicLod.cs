using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventMimicLod : CStorySceneEvent
	{
		[RED("actor")] 		public CName Actor { get; set;}

		[RED("setMimicOn")] 		public CBool SetMimicOn { get; set;}

		public CStorySceneEventMimicLod(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventMimicLod(cr2w);

	}
}