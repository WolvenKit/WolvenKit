using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioFootwearVsMaterialMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("footwearType")] public CName FootwearType { get; set; }
		[Ordinal(1)]  [RED("skidEvent")] public CName SkidEvent { get; set; }
		[Ordinal(2)]  [RED("defaultFootstep")] public CName DefaultFootstep { get; set; }
		[Ordinal(3)]  [RED("locomotionStates")] public CHandle<audioLocomotionStateEventDictionary> LocomotionStates { get; set; }
		[Ordinal(4)]  [RED("customActionEvents")] public CHandle<audioLocomotionCustomActionEventDictionary> CustomActionEvents { get; set; }

		public audioFootwearVsMaterialMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
