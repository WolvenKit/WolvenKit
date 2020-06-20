using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterSearchFoodIdleParams : CAISubTreeParameters
	{
		[RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[RED("corpse")] 		public CBool Corpse { get; set;}

		[RED("meat")] 		public CBool Meat { get; set;}

		[RED("vegetable")] 		public CBool Vegetable { get; set;}

		[RED("water")] 		public CBool Water { get; set;}

		[RED("monster")] 		public CBool Monster { get; set;}

		[RED("landHeight")] 		public CFloat LandHeight { get; set;}

		[RED("flyHeight")] 		public CFloat FlyHeight { get; set;}

		public CAIMonsterSearchFoodIdleParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMonsterSearchFoodIdleParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}