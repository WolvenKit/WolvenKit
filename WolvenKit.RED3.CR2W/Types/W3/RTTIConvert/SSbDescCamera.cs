using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescCamera : CVariable
	{
		[Ordinal(1)] [RED("uId")] 		public CString UId { get; set;}

		[Ordinal(2)] [RED("repoCamId")] 		public CString RepoCamId { get; set;}

		[Ordinal(3)] [RED("pos")] 		public Vector Pos { get; set;}

		[Ordinal(4)] [RED("rot")] 		public EulerAngles Rot { get; set;}

		[Ordinal(5)] [RED("fov")] 		public CFloat Fov { get; set;}

		[Ordinal(6)] [RED("dof")] 		public SStoryBoardCameraDofSettings Dof { get; set;}

		public SSbDescCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSbDescCamera(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}