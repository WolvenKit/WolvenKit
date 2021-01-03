using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioFootwearVsMaterialMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("customActionEvents")] public CHandle<audioLocomotionCustomActionEventDictionary> CustomActionEvents { get; set; }
		[Ordinal(1)]  [RED("defaultFootstep")] public CName DefaultFootstep { get; set; }
		[Ordinal(2)]  [RED("footwearType")] public CName FootwearType { get; set; }
		[Ordinal(3)]  [RED("locomotionStates")] public CHandle<audioLocomotionStateEventDictionary> LocomotionStates { get; set; }
		[Ordinal(4)]  [RED("skidEvent")] public CName SkidEvent { get; set; }

		public audioFootwearVsMaterialMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
