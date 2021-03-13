using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootwearVsMaterialMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("footwearType")] public CName FootwearType { get; set; }
		[Ordinal(2)] [RED("skidEvent")] public CName SkidEvent { get; set; }
		[Ordinal(3)] [RED("defaultFootstep")] public CName DefaultFootstep { get; set; }
		[Ordinal(4)] [RED("locomotionStates")] public CHandle<audioLocomotionStateEventDictionary> LocomotionStates { get; set; }
		[Ordinal(5)] [RED("customActionEvents")] public CHandle<audioLocomotionCustomActionEventDictionary> CustomActionEvents { get; set; }

		public audioFootwearVsMaterialMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
