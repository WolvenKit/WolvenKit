using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestFightCondition : IQuestCondition
	{
		[RED("tag")] 		public CName Tag { get; set;}

		[RED("attackerTag")] 		public CName AttackerTag { get; set;}

		[RED("referenceValue")] 		public CInt32 ReferenceValue { get; set;}

		[RED("damageMode")] 		public EQueryFightMode DamageMode { get; set;}

		public CQuestFightCondition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestFightCondition(cr2w);

	}
}