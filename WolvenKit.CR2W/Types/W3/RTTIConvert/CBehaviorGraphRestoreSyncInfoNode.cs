using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRestoreSyncInfoNode : CBehaviorGraphBaseNode
	{
		[RED("storeName")] 		public CName StoreName { get; set;}

		[RED("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[RED("restoreOnActivation")] 		public CBool RestoreOnActivation { get; set;}

		[RED("restoreEveryFrame")] 		public CBool RestoreEveryFrame { get; set;}

		[RED("restoreOnEvent")] 		public CName RestoreOnEvent { get; set;}

		public CBehaviorGraphRestoreSyncInfoNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphRestoreSyncInfoNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}