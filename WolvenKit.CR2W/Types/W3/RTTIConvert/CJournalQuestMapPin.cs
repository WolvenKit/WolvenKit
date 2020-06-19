using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJournalQuestMapPin : CJournalContainerEntry
	{
		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("mapPinID")] 		public CName MapPinID { get; set;}

		[RED("type")] 		public CEnum<EJournalMapPinType> Type { get; set;}

		[RED("enabledAtStartup")] 		public CBool EnabledAtStartup { get; set;}

		public CJournalQuestMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CJournalQuestMapPin(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}