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

		public CQuestCameraFocusCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestCameraFocusCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}