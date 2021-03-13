using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAudioEmitterComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("EmitterName")] public CName EmitterName { get; set; }
		[Ordinal(6)] [RED("EmitterType")] public CEnum<audioEntityEmitterContextType> EmitterType { get; set; }
		[Ordinal(7)] [RED("OnAttach")] public gameAudioSyncs OnAttach { get; set; }
		[Ordinal(8)] [RED("OnDetach")] public gameAudioSyncs OnDetach { get; set; }
		[Ordinal(9)] [RED("updateDistance")] public CFloat UpdateDistance { get; set; }
		[Ordinal(10)] [RED("emitterMetadataName")] public CName EmitterMetadataName { get; set; }
		[Ordinal(11)] [RED("Tags")] public CArray<CName> Tags { get; set; }
		[Ordinal(12)] [RED("TagList")] public redTagList TagList { get; set; }

		public gameAudioEmitterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
