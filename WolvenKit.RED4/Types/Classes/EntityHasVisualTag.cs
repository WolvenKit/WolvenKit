using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EntityHasVisualTag : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("visualTag")] 
		public CName VisualTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("hasTag")] 
		public CBool HasTag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EntityHasVisualTag()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
