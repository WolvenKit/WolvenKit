using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskHorseSendInfoDef : IBehTreeHorseTaskDefinition
	{
		[RED("onIsAvailable")] 		public CBool OnIsAvailable { get; set;}

		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onDectivate")] 		public CBool OnDectivate { get; set;}

		[RED("infoType")] 		public CEnum<EActionInfoType> InfoType { get; set;}

		[RED("notifyPlayerInsteadOfCombatTarget")] 		public CBool NotifyPlayerInsteadOfCombatTarget { get; set;}

		public CBTTaskHorseSendInfoDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskHorseSendInfoDef(cr2w);

	}
}