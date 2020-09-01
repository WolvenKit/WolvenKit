using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSendInfoDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("("onIsAvailable")] 		public CBool OnIsAvailable { get; set;}

		[Ordinal(2)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(3)] [RED("("onDectivate")] 		public CBool OnDectivate { get; set;}

		[Ordinal(4)] [RED("("infoType")] 		public CEnum<EActionInfoType> InfoType { get; set;}

		[Ordinal(5)] [RED("("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		public CBTTaskSendInfoDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSendInfoDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}