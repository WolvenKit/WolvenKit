using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventClothDisablingInterpolationKey : CVariable
	{
		[RED("bezierHandles", 1)] 		public CArrayFixedSize<Bezier2dHandle> BezierHandles { get; set;}

		[RED("interpolationTypes", 1)] 		public CArrayFixedSize<CUInt32> InterpolationTypes { get; set;}

		[RED("volatile")] 		public CBool Volatile { get; set;}

		public CStorySceneEventClothDisablingInterpolationKey(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventClothDisablingInterpolationKey(cr2w);

	}
}