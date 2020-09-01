using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraPivotPositionControllerSlide : ICustomCameraScriptedPivotPositionController
	{
		[Ordinal(1)] [RED("("originalPosition")] 		public Vector OriginalPosition { get; set;}

		[Ordinal(2)] [RED("("blendSpeed")] 		public CFloat BlendSpeed { get; set;}

		[Ordinal(3)] [RED("("timeCur")] 		public CFloat TimeCur { get; set;}

		public CCameraPivotPositionControllerSlide(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCameraPivotPositionControllerSlide(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}