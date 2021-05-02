using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVisualTagToNPCMetadata : CVariable
	{
		private CArray<CName> _visualTags;
		private CName _foleyNPCMetadata;

		[Ordinal(0)] 
		[RED("visualTags")] 
		public CArray<CName> VisualTags
		{
			get => GetProperty(ref _visualTags);
			set => SetProperty(ref _visualTags, value);
		}

		[Ordinal(1)] 
		[RED("foleyNPCMetadata")] 
		public CName FoleyNPCMetadata
		{
			get => GetProperty(ref _foleyNPCMetadata);
			set => SetProperty(ref _foleyNPCMetadata, value);
		}

		public audioVisualTagToNPCMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
