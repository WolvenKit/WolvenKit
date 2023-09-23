using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SWidgetPackageWrapper : IScriptable
	{
		[Ordinal(0)] 
		[RED("WidgetPackage")] 
		public SWidgetPackage WidgetPackage
		{
			get => GetPropertyValue<SWidgetPackage>();
			set => SetPropertyValue<SWidgetPackage>(value);
		}

		public SWidgetPackageWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
