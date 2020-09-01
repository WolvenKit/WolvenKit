using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MessagePopupData : CObject
	{
		[Ordinal(0)] [RED("("actionsList", 2,0)] 		public CArray<UserMessageActionData> ActionsList { get; set;}

		[Ordinal(0)] [RED("("titleText")] 		public CString TitleText { get; set;}

		[Ordinal(0)] [RED("("messageText")] 		public CString MessageText { get; set;}

		[Ordinal(0)] [RED("("messageId")] 		public CInt32 MessageId { get; set;}

		[Ordinal(0)] [RED("("autoLocalize")] 		public CBool AutoLocalize { get; set;}

		[Ordinal(0)] [RED("("messageType")] 		public CEnum<EUserDialogButtons> MessageType { get; set;}

		[Ordinal(0)] [RED("("priority")] 		public CInt32 Priority { get; set;}

		[Ordinal(0)] [RED("("progress")] 		public CFloat Progress { get; set;}

		[Ordinal(0)] [RED("("progressType")] 		public CEnum<EUserMessageProgressType> ProgressType { get; set;}

		[Ordinal(0)] [RED("("progressTag")] 		public CName ProgressTag { get; set;}

		public W3MessagePopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MessagePopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}