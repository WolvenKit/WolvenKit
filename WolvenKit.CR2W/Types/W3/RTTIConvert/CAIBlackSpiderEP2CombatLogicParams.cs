using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIBlackSpiderEP2CombatLogicParams : CAIMonsterCombatLogicParams
	{
		[RED("minChargeDist")] 		public CFloat MinChargeDist { get; set;}

		[RED("maxChargeDist")] 		public CFloat MaxChargeDist { get; set;}

		public CAIBlackSpiderEP2CombatLogicParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIBlackSpiderEP2CombatLogicParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}