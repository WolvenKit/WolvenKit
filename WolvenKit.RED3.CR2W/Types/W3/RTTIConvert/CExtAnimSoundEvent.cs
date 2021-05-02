using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimSoundEvent : CExtAnimEvent
	{
		[Ordinal(1)] [RED("soundEventName")] 		public StringAnsi SoundEventName { get; set;}

		[Ordinal(2)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(3)] [RED("bone")] 		public CName Bone { get; set;}

		[Ordinal(4)] [RED("switchesToUpdate", 2,0)] 		public CArray<StringAnsi> SwitchesToUpdate { get; set;}

		[Ordinal(5)] [RED("parametersToUpdate", 2,0)] 		public CArray<StringAnsi> ParametersToUpdate { get; set;}

		[Ordinal(6)] [RED("filter")] 		public CBool Filter { get; set;}

		[Ordinal(7)] [RED("filterCooldown")] 		public CFloat FilterCooldown { get; set;}

		[Ordinal(8)] [RED("useDistanceParameter")] 		public CBool UseDistanceParameter { get; set;}

		[Ordinal(9)] [RED("speed")] 		public CFloat Speed { get; set;}

		[Ordinal(10)] [RED("decelDist")] 		public CFloat DecelDist { get; set;}

		public CExtAnimSoundEvent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimSoundEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}