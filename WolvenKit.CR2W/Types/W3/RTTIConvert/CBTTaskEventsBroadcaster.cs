using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskEventsBroadcaster : IBehTreeTask
	{
		[Ordinal(0)] [RED("("broadcastedEvents", 2,0)] 		public CArray<SReactionEventData> BroadcastedEvents { get; set;}

		[Ordinal(0)] [RED("("rescanInterval")] 		public CFloat RescanInterval { get; set;}

		[Ordinal(0)] [RED("("minIntervalBetweenScenes")] 		public CFloat MinIntervalBetweenScenes { get; set;}

		[Ordinal(0)] [RED("("owner")] 		public CHandle<CNewNPC> Owner { get; set;}

		[Ordinal(0)] [RED("("i")] 		public CInt32 I { get; set;}

		[Ordinal(0)] [RED("("eventsCount")] 		public CInt32 EventsCount { get; set;}

		[Ordinal(0)] [RED("("currentTime")] 		public CFloat CurrentTime { get; set;}

		[Ordinal(0)] [RED("("timeOfLastScene")] 		public CFloat TimeOfLastScene { get; set;}

		public CBTTaskEventsBroadcaster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskEventsBroadcaster(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}