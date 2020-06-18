using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestCameraFocusCondition : IQuestCondition
	{
		[RED("nodeTag")] 		public CName NodeTag { get; set;}

		[RED("angleTolerance")] 		public CFloat AngleTolerance { get; set;}

		[RED("isLookingAtNode")] 		public CBool IsLookingAtNode { get; set;}

		[RED("testLineOfSight")] 		public CBool TestLineOfSight { get; set;}

		[RED("lineOfSightSource")] 		public CEnum<ECameraFocusConditionLineOfSightSource> LineOfSightSource { get; set;}

		public CQuestCameraFocusCondition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestCameraFocusCondition(cr2w);

	}
}