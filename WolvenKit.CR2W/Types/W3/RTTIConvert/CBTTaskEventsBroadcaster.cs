using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskEventsBroadcaster : IBehTreeTask
	{
		[Ordinal(1)] [RED("broadcastedEvents", 2,0)] 		public CArray<SReactionEventData> BroadcastedEvents { get; set;}

		[Ordinal(2)] [RED("rescanInterval")] 		public CFloat RescanInterval { get; set;}

		[Ordinal(3)] [RED("minIntervalBetweenScenes")] 		public CFloat MinIntervalBetweenScenes { get; set;}

		[Ordinal(4)] [RED("owner")] 		public CHandle<CNewNPC> Owner { get; set;}

		[Ordinal(5)] [RED("i")] 		public CInt32 I { get; set;}

		[Ordinal(6)] [RED("eventsCount")] 		public CInt32 EventsCount { get; set;}

		[Ordinal(7)] [RED("currentTime")] 		public CFloat CurrentTime { get; set;}

		[Ordinal(8)] [RED("timeOfLastScene")] 		public CFloat TimeOfLastScene { get; set;}

		public CBTTaskEventsBroadcaster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskEventsBroadcaster(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}