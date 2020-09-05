using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondIsHorseInAreaWithObstacles : IBehTreeTask
	{
		[Ordinal(1)] [RED("testRadius")] 		public CFloat TestRadius { get; set;}

		[Ordinal(2)] [RED("testFreq")] 		public CFloat TestFreq { get; set;}

		[Ordinal(3)] [RED("lastTestTime")] 		public CFloat LastTestTime { get; set;}

		[Ordinal(4)] [RED("lastResult")] 		public CBool LastResult { get; set;}

		public CBTCondIsHorseInAreaWithObstacles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondIsHorseInAreaWithObstacles(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}