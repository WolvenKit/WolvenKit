using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AGenericTooltipControllerWithDebug : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("DEBUG_showDebug")] 
		public CBool DEBUG_showDebug
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("DEBUG_openInVSCode")] 
		public CBool DEBUG_openInVSCode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("DEBUG_openInVSCodeBlocked")] 
		public CBool DEBUG_openInVSCodeBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AGenericTooltipControllerWithDebug()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
