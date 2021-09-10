using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNavigationDeniedAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("flags")] 
		public CBitField<worldEDeniedAreaFlags> Flags
		{
			get => GetPropertyValue<CBitField<worldEDeniedAreaFlags>>();
			set => SetPropertyValue<CBitField<worldEDeniedAreaFlags>>(value);
		}
	}
}
