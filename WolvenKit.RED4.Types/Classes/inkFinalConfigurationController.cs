using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkFinalConfigurationController : inkWidgetLogicController
	{
		private CEnum<inkFinalConfigurationVisibility> _visibilityFlag;

		[Ordinal(1)] 
		[RED("visibilityFlag")] 
		public CEnum<inkFinalConfigurationVisibility> VisibilityFlag
		{
			get => GetProperty(ref _visibilityFlag);
			set => SetProperty(ref _visibilityFlag, value);
		}
	}
}
