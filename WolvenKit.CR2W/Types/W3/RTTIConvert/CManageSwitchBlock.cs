using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CManageSwitchBlock : CQuestGraphBlock
	{
		[RED("switchTag")] 		public CName SwitchTag { get; set;}

		[RED("operations", 2,0)] 		public CArray<CEnum<ESwitchOperation>> Operations { get; set;}

		[RED("force")] 		public CBool Force { get; set;}

		[RED("skipEvents")] 		public CBool SkipEvents { get; set;}

		public CManageSwitchBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CManageSwitchBlock(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}