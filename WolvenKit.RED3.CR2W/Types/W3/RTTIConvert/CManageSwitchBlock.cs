using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CManageSwitchBlock : CQuestGraphBlock
	{
		[Ordinal(1)] [RED("switchTag")] 		public CName SwitchTag { get; set;}

		[Ordinal(2)] [RED("operations", 2,0)] 		public CArray<CEnum<ESwitchOperation>> Operations { get; set;}

		[Ordinal(3)] [RED("force")] 		public CBool Force { get; set;}

		[Ordinal(4)] [RED("skipEvents")] 		public CBool SkipEvents { get; set;}

		public CManageSwitchBlock(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CManageSwitchBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}