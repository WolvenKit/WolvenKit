using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRelativeNodePath : CVariable
	{
		private CUInt32 _parentsToSkip;
		private CArray<worldRelativeNodePathElement> _elements;

		[Ordinal(0)] 
		[RED("parentsToSkip")] 
		public CUInt32 ParentsToSkip
		{
			get => GetProperty(ref _parentsToSkip);
			set => SetProperty(ref _parentsToSkip, value);
		}

		[Ordinal(1)] 
		[RED("elements")] 
		public CArray<worldRelativeNodePathElement> Elements
		{
			get => GetProperty(ref _elements);
			set => SetProperty(ref _elements, value);
		}

		public worldRelativeNodePath(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
