using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterSearchFoodIdleParams : CAISubTreeParameters
	{
		[Ordinal(1)] [RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[Ordinal(2)] [RED("corpse")] 		public CBool Corpse { get; set;}

		[Ordinal(3)] [RED("meat")] 		public CBool Meat { get; set;}

		[Ordinal(4)] [RED("vegetable")] 		public CBool Vegetable { get; set;}

		[Ordinal(5)] [RED("water")] 		public CBool Water { get; set;}

		[Ordinal(6)] [RED("monster")] 		public CBool Monster { get; set;}

		[Ordinal(7)] [RED("landHeight")] 		public CFloat LandHeight { get; set;}

		[Ordinal(8)] [RED("flyHeight")] 		public CFloat FlyHeight { get; set;}

		public CAIMonsterSearchFoodIdleParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMonsterSearchFoodIdleParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}