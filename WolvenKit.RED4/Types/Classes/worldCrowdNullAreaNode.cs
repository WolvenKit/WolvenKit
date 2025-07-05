using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCrowdNullAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("IsForBlockade")] 
		public CBool IsForBlockade
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("permanentlyEnabledByDefault")] 
		public CBool PermanentlyEnabledByDefault
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldCrowdNullAreaNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
