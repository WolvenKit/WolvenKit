using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TripwireSwitch : W3PhysicalSwitch
	{
		[Ordinal(1)] [RED("autoSwitchOnLeave")] 		public CBool AutoSwitchOnLeave { get; set;}

		[Ordinal(2)] [RED("entities", 2,0)] 		public CArray<CHandle<CEntity>> Entities { get; set;}

		[Ordinal(3)] [RED("delayedTurnOffEntity")] 		public CHandle<CEntity> DelayedTurnOffEntity { get; set;}

		[Ordinal(4)] [RED("delayedTurnOnEntity")] 		public CHandle<CEntity> DelayedTurnOnEntity { get; set;}

		[Ordinal(5)] [RED("connectedTrapClueTag")] 		public CName ConnectedTrapClueTag { get; set;}

		public W3TripwireSwitch(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}