using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameAudioEmitterComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("EmitterName")] public CName EmitterName { get; set; }
		[Ordinal(1)]  [RED("EmitterType")] public CEnum<audioEntityEmitterContextType> EmitterType { get; set; }
		[Ordinal(2)]  [RED("OnAttach")] public gameAudioSyncs OnAttach { get; set; }
		[Ordinal(3)]  [RED("OnDetach")] public gameAudioSyncs OnDetach { get; set; }
		[Ordinal(4)]  [RED("TagList")] public redTagList TagList { get; set; }
		[Ordinal(5)]  [RED("Tags")] public CArray<CName> Tags { get; set; }
		[Ordinal(6)]  [RED("emitterMetadataName")] public CName EmitterMetadataName { get; set; }
		[Ordinal(7)]  [RED("updateDistance")] public CFloat UpdateDistance { get; set; }

		public gameAudioEmitterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
