using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSendInfoDef : IBehTreeTaskDefinition
	{
		[RED("onIsAvailable")] 		public CBool OnIsAvailable { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDectivate")] 		public CBool OnDectivate { get; set;}

		[RED("infoType")] 		public EActionInfoType InfoType { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		public CBTTaskSendInfoDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskSendInfoDef(cr2w);

	}
}