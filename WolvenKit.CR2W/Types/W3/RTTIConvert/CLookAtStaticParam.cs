using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CLookAtStaticParam : CEntityTemplateParam
	{
		[Ordinal(1)] [RED("maxLookAtLevel")] 		public CEnum<ELookAtLevel> MaxLookAtLevel { get; set;}

		[Ordinal(2)] [RED("maxHorAngle")] 		public CFloat MaxHorAngle { get; set;}

		[Ordinal(3)] [RED("maxVerAngle")] 		public CFloat MaxVerAngle { get; set;}

		[Ordinal(4)] [RED("secWeight")] 		public CFloat SecWeight { get; set;}

		[Ordinal(5)] [RED("firstWeight")] 		public CFloat FirstWeight { get; set;}

		[Ordinal(6)] [RED("responsiveness")] 		public CFloat Responsiveness { get; set;}

		public CLookAtStaticParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CLookAtStaticParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}