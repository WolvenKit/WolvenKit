using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class GotoRequest : CObject
	{
		[Ordinal(0)] [RED("groupId")] 		public CFlyingGroupId GroupId { get; set;}

		[Ordinal(0)] [RED("groupState")] 		public CName GroupState { get; set;}

		[Ordinal(0)] [RED("groupStateSetOnArrival")] 		public CName GroupStateSetOnArrival { get; set;}

		[Ordinal(0)] [RED("targetPoiComponent")] 		public CHandle<CBoidPointOfInterestComponent> TargetPoiComponent { get; set;}

		[Ordinal(0)] [RED("targetNode")] 		public CHandle<CNode> TargetNode { get; set;}

		[Ordinal(0)] [RED("delay")] 		public CFloat Delay { get; set;}

		[Ordinal(0)] [RED("delayTimer")] 		public CFloat DelayTimer { get; set;}

		[Ordinal(0)] [RED("factID")] 		public CString FactID { get; set;}

		[Ordinal(0)] [RED("factValue")] 		public CInt32 FactValue { get; set;}

		[Ordinal(0)] [RED("groupCenterWhenStart")] 		public Vector GroupCenterWhenStart { get; set;}

		[Ordinal(0)] [RED("init")] 		public CBool Init { get; set;}

		public GotoRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new GotoRequest(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}