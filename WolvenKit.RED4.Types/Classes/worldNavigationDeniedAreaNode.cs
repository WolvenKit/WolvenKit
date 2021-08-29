using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNavigationDeniedAreaNode : worldAreaShapeNode
	{
		private CEnum<worldEDeniedAreaFlags> _flags;

		[Ordinal(6)] 
		[RED("flags")] 
		public CEnum<worldEDeniedAreaFlags> Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}
	}
}
