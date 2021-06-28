using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationDeniedAreaNode : worldAreaShapeNode
	{
		private CEnum<worldEDeniedAreaFlags> _flags;

		[Ordinal(6)] 
		[RED("flags")] 
		public CEnum<worldEDeniedAreaFlags> Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		public worldNavigationDeniedAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
