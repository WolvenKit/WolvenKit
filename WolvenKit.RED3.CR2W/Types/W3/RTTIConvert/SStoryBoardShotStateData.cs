using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStoryBoardShotStateData : CVariable
	{
		[Ordinal(1)] [RED("shotname")] 		public CString Shotname { get; set;}

		[Ordinal(2)] [RED("camera")] 		public SStoryBoardCameraSettings Camera { get; set;}

		[Ordinal(3)] [RED("assets", 2,0)] 		public CArray<SStoryBoardShotAssetSettings> Assets { get; set;}

		public SStoryBoardShotStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStoryBoardShotStateData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}