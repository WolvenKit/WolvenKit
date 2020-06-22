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
		[RED("groupId")] 		public CFlyingGroupId GroupId { get; set;}

		[RED("groupState")] 		public CName GroupState { get; set;}

		[RED("groupStateSetOnArrival")] 		public CName GroupStateSetOnArrival { get; set;}

		[RED("targetPoiComponent")] 		public CHandle<CBoidPointOfInterestComponent> TargetPoiComponent { get; set;}

		[RED("targetNode")] 		public CHandle<CNode> TargetNode { get; set;}

		[RED("delay")] 		public CFloat Delay { get; set;}

		[RED("delayTimer")] 		public CFloat DelayTimer { get; set;}

		[RED("factID")] 		public CString FactID { get; set;}

		[RED("factValue")] 		public CInt32 FactValue { get; set;}

		[RED("groupCenterWhenStart")] 		public Vector GroupCenterWhenStart { get; set;}

		[RED("init")] 		public CBool Init { get; set;}

		public GotoRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new GotoRequest(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}