using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMultiChildren : inkChildren
	{
		private CArray<CHandle<inkWidget>> _children;

		[Ordinal(0)] 
		[RED("children")] 
		public CArray<CHandle<inkWidget>> Children
		{
			get => GetProperty(ref _children);
			set => SetProperty(ref _children, value);
		}

		public inkMultiChildren(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
