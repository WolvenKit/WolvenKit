using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSlidingMaterialPresetParams : CVariable
	{
		[RED("presetName")] 		public CName PresetName { get; set;}

		[RED("angleMin")] 		public CFloat AngleMin { get; set;}

		[RED("angleMinRain")] 		public CFloat AngleMinRain { get; set;}

		[RED("frictionMultiplier")] 		public CFloat FrictionMultiplier { get; set;}

		[RED("frictionMultiplierRain")] 		public CFloat FrictionMultiplierRain { get; set;}

		public SSlidingMaterialPresetParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSlidingMaterialPresetParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}