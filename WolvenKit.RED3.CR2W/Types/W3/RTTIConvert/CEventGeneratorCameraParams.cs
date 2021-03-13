using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEventGeneratorCameraParams : CVariable
	{
		[Ordinal(1)] [RED("cameraPlane")] 		public CEnum<ECameraPlane> CameraPlane { get; set;}

		[Ordinal(2)] [RED("tags")] 		public TagList Tags { get; set;}

		[Ordinal(3)] [RED("targetSlot")] 		public CInt32 TargetSlot { get; set;}

		[Ordinal(4)] [RED("sourceSlot")] 		public CInt32 SourceSlot { get; set;}

		[Ordinal(5)] [RED("usableForGenerator")] 		public CBool UsableForGenerator { get; set;}

		public CEventGeneratorCameraParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEventGeneratorCameraParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}