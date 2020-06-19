using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimSoundEvent : CExtAnimEvent
	{
		[RED("soundEventName")] 		public StringAnsi SoundEventName { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("bone")] 		public CName Bone { get; set;}

		[RED("switchesToUpdate", 2,0)] 		public CArray<StringAnsi> SwitchesToUpdate { get; set;}

		[RED("parametersToUpdate", 2,0)] 		public CArray<StringAnsi> ParametersToUpdate { get; set;}

		[RED("filter")] 		public CBool Filter { get; set;}

		[RED("filterCooldown")] 		public CFloat FilterCooldown { get; set;}

		[RED("useDistanceParameter")] 		public CBool UseDistanceParameter { get; set;}

		[RED("speed")] 		public CFloat Speed { get; set;}

		[RED("decelDist")] 		public CFloat DecelDist { get; set;}

		public CExtAnimSoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimSoundEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}