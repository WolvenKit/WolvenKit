using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ParentTransform : animAnimNode_OnePoseInput
	{
		private CArray<animAnimTransformMappingEntry> _mapping;

		[Ordinal(12)] 
		[RED("mapping")] 
		public CArray<animAnimTransformMappingEntry> Mapping
		{
			get => GetProperty(ref _mapping);
			set => SetProperty(ref _mapping, value);
		}

		public animAnimNode_ParentTransform(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
