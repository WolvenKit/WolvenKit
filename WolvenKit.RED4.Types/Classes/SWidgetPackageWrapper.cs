using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SWidgetPackageWrapper : IScriptable
	{
		private SWidgetPackage _widgetPackage;

		[Ordinal(0)] 
		[RED("WidgetPackage")] 
		public SWidgetPackage WidgetPackage
		{
			get => GetProperty(ref _widgetPackage);
			set => SetProperty(ref _widgetPackage, value);
		}
	}
}
