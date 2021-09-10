using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkFinalConfigurationController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("visibilityFlag")] 
		public CEnum<inkFinalConfigurationVisibility> VisibilityFlag
		{
			get => GetPropertyValue<CEnum<inkFinalConfigurationVisibility>>();
			set => SetPropertyValue<CEnum<inkFinalConfigurationVisibility>>(value);
		}
	}
}
