using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSlidingMaterialPresetParams : CVariable
	{
		[Ordinal(1)] [RED("presetName")] 		public CName PresetName { get; set;}

		[Ordinal(2)] [RED("angleMin")] 		public CFloat AngleMin { get; set;}

		[Ordinal(3)] [RED("angleMinRain")] 		public CFloat AngleMinRain { get; set;}

		[Ordinal(4)] [RED("frictionMultiplier")] 		public CFloat FrictionMultiplier { get; set;}

		[Ordinal(5)] [RED("frictionMultiplierRain")] 		public CFloat FrictionMultiplierRain { get; set;}

		public SSlidingMaterialPresetParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSlidingMaterialPresetParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}