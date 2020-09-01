using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventCameraLightInterpolationKey : CVariable
	{
		[Ordinal(0)] [RED("("bezierHandles", 2)] 		public CArrayFixedSize<Bezier2dHandle> BezierHandles { get; set;}

		[Ordinal(0)] [RED("("interpolationTypes", 2)] 		public CArrayFixedSize<CUInt32> InterpolationTypes { get; set;}

		[Ordinal(0)] [RED("("volatile")] 		public CBool Volatile { get; set;}

		public CStorySceneEventCameraLightInterpolationKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventCameraLightInterpolationKey(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}