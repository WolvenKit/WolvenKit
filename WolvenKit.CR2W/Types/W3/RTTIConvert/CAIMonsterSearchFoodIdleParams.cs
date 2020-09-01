using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterSearchFoodIdleParams : CAISubTreeParameters
	{
		[Ordinal(0)] [RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[Ordinal(0)] [RED("corpse")] 		public CBool Corpse { get; set;}

		[Ordinal(0)] [RED("meat")] 		public CBool Meat { get; set;}

		[Ordinal(0)] [RED("vegetable")] 		public CBool Vegetable { get; set;}

		[Ordinal(0)] [RED("water")] 		public CBool Water { get; set;}

		[Ordinal(0)] [RED("monster")] 		public CBool Monster { get; set;}

		[Ordinal(0)] [RED("landHeight")] 		public CFloat LandHeight { get; set;}

		[Ordinal(0)] [RED("flyHeight")] 		public CFloat FlyHeight { get; set;}

		public CAIMonsterSearchFoodIdleParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMonsterSearchFoodIdleParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}