using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlayHUDEntryAnimation_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CName HudEntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("dependsOnTimeDilation")] 
		public CBool DependsOnTimeDilation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questPlayHUDEntryAnimation_NodeType()
		{
			DependsOnTimeDilation = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
