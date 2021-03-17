using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCompiledSmartObjectsNode : worldNode
	{
		private raRef<gameSmartObjectsCompiledResource> _resource;

		[Ordinal(4)] 
		[RED("resource")] 
		public raRef<gameSmartObjectsCompiledResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		public worldCompiledSmartObjectsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
