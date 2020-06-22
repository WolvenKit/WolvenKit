using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CurveDamper3d : CObject
	{
		[RED("damperX")] 		public CHandle<CurveDamper> DamperX { get; set;}

		[RED("damperY")] 		public CHandle<CurveDamper> DamperY { get; set;}

		[RED("damperZ")] 		public CHandle<CurveDamper> DamperZ { get; set;}

		public CurveDamper3d(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CurveDamper3d(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}