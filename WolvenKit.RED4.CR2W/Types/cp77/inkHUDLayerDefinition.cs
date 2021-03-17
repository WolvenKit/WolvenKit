using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkHUDLayerDefinition : inkLayerDefinition
	{
		private rRef<inkHudEntriesResource> _entriesResource;

		[Ordinal(8)] 
		[RED("entriesResource")] 
		public rRef<inkHudEntriesResource> EntriesResource
		{
			get => GetProperty(ref _entriesResource);
			set => SetProperty(ref _entriesResource, value);
		}

		public inkHUDLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
