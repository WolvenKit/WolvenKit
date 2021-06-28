using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class resResourceSnapshot : CResource
	{
		private CArray<raRef<CResource>> _resources;

		[Ordinal(1)] 
		[RED("resources")] 
		public CArray<raRef<CResource>> Resources
		{
			get => GetProperty(ref _resources);
			set => SetProperty(ref _resources, value);
		}

		public resResourceSnapshot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
