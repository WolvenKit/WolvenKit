using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventInterpolation : CStorySceneEvent
	{
		[Ordinal(0)] [RED("keyGuids", 2,0)] 		public CArray<CGUID> KeyGuids { get; set;}

		[Ordinal(0)] [RED("interpolationMethod")] 		public CEnum<EInterpolationMethod> InterpolationMethod { get; set;}

		[Ordinal(0)] [RED("easeInStyle")] 		public CEnum<EInterpolationEasingStyle> EaseInStyle { get; set;}

		[Ordinal(0)] [RED("easeInParameter")] 		public CFloat EaseInParameter { get; set;}

		[Ordinal(0)] [RED("easeOutStyle")] 		public CEnum<EInterpolationEasingStyle> EaseOutStyle { get; set;}

		[Ordinal(0)] [RED("easeOutParameter")] 		public CFloat EaseOutParameter { get; set;}

		public CStorySceneEventInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventInterpolation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}