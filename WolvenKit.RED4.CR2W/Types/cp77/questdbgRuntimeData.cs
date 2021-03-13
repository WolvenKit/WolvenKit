using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questdbgRuntimeData : CVariable
	{
		[Ordinal(0)] [RED("version")] public CUInt64 Version { get; set; }
		[Ordinal(1)] [RED("questResourcePathHash")] public CUInt64 QuestResourcePathHash { get; set; }
		[Ordinal(2)] [RED("selectedBlockId")] public CUInt64 SelectedBlockId { get; set; }
		[Ordinal(3)] [RED("objects")] public CArray<CHandle<ISerializable>> Objects { get; set; }

		public questdbgRuntimeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
