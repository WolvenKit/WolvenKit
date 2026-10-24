using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCrowdNullAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] 
		[RED("IsForBlockade")] 
		public CBool IsForBlockade
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("permanentlyEnabledByDefault")] 
		public CBool PermanentlyEnabledByDefault
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldCrowdNullAreaNode()
		{
			Color = new CColor { Red = 32, Green = 32, Blue = 32, Alpha = 128 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
