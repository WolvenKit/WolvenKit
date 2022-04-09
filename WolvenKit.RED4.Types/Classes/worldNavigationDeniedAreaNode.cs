using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNavigationDeniedAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("flags")] 
		public CBitField<worldEDeniedAreaFlags> Flags
		{
			get => GetPropertyValue<CBitField<worldEDeniedAreaFlags>>();
			set => SetPropertyValue<CBitField<worldEDeniedAreaFlags>>(value);
		}

		public worldNavigationDeniedAreaNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
