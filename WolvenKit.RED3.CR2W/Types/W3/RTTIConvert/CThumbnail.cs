using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CThumbnail : CObject
	{
		[Ordinal(1)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(2)] [RED("info", 2,0)] 		public CArray<CString> Info { get; set;}

		[Ordinal(3)] [RED("cameraPosition")] 		public Vector CameraPosition { get; set;}

		[Ordinal(4)] [RED("cameraRotation")] 		public EulerAngles CameraRotation { get; set;}

		[Ordinal(5)] [RED("cameraFov")] 		public CFloat CameraFov { get; set;}

		[Ordinal(6)] [RED("sunRotation")] 		public EulerAngles SunRotation { get; set;}

		[Ordinal(7)] [RED("flags")] 		public CInt32 Flags { get; set;}

		public CThumbnail(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CThumbnail(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}