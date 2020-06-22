using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSteeringCompositeCondition : IMoveSteeringCondition
	{
		[RED("firstCondition")] 		public CPtr<IMoveSteeringCondition> FirstCondition { get; set;}

		[RED("notFirstCondition")] 		public CBool NotFirstCondition { get; set;}

		[RED("operator")] 		public CEnum<ELogicOperator> Operator { get; set;}

		[RED("secondCondition")] 		public CPtr<IMoveSteeringCondition> SecondCondition { get; set;}

		[RED("notSecondCondition")] 		public CBool NotSecondCondition { get; set;}

		public CMoveSteeringCompositeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSteeringCompositeCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}