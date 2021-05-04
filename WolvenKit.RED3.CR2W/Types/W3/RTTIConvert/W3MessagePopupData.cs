using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MessagePopupData : CObject
	{
		[Ordinal(1)] [RED("actionsList", 2,0)] 		public CArray<UserMessageActionData> ActionsList { get; set;}

		[Ordinal(2)] [RED("titleText")] 		public CString TitleText { get; set;}

		[Ordinal(3)] [RED("messageText")] 		public CString MessageText { get; set;}

		[Ordinal(4)] [RED("messageId")] 		public CInt32 MessageId { get; set;}

		[Ordinal(5)] [RED("autoLocalize")] 		public CBool AutoLocalize { get; set;}

		[Ordinal(6)] [RED("messageType")] 		public CEnum<EUserDialogButtons> MessageType { get; set;}

		[Ordinal(7)] [RED("priority")] 		public CInt32 Priority { get; set;}

		[Ordinal(8)] [RED("progress")] 		public CFloat Progress { get; set;}

		[Ordinal(9)] [RED("progressType")] 		public CEnum<EUserMessageProgressType> ProgressType { get; set;}

		[Ordinal(10)] [RED("progressTag")] 		public CName ProgressTag { get; set;}

		public W3MessagePopupData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}