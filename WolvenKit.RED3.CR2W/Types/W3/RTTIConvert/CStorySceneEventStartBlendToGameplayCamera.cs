using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventStartBlendToGameplayCamera : CStorySceneEventCustomCamera
	{
		[Ordinal(1)] [RED("blendTime")] 		public CFloat BlendTime { get; set;}

		[Ordinal(2)] [RED("changesCamera")] 		public CBool ChangesCamera { get; set;}

		[Ordinal(3)] [RED("lightsBlendTime")] 		public CFloat LightsBlendTime { get; set;}

		public CStorySceneEventStartBlendToGameplayCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventStartBlendToGameplayCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}