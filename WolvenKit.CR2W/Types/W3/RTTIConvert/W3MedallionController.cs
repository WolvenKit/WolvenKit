using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MedallionController : CObject
	{
		[Ordinal(1)] [RED("("deactivateTimer")] 		public CFloat DeactivateTimer { get; set;}

		[Ordinal(2)] [RED("("instantIntensity")] 		public CFloat InstantIntensity { get; set;}

		[Ordinal(3)] [RED("("isBlocked")] 		public CBool IsBlocked { get; set;}

		[Ordinal(4)] [RED("("focusModeFactor")] 		public CFloat FocusModeFactor { get; set;}

		[Ordinal(5)] [RED("("defaultDuration")] 		public CFloat DefaultDuration { get; set;}

		[Ordinal(6)] [RED("("defaultTreshold")] 		public CFloat DefaultTreshold { get; set;}

		[Ordinal(7)] [RED("("maxTreshold")] 		public CFloat MaxTreshold { get; set;}

		public W3MedallionController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MedallionController(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}