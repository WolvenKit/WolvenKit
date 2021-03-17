using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentNode : worldNode
	{
		private raRef<worldTrafficPersistentResource> _resource;

		[Ordinal(4)] 
		[RED("resource")] 
		public raRef<worldTrafficPersistentResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		public worldTrafficPersistentNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
