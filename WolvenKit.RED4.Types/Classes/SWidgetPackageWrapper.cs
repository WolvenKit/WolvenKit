using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			WidgetPackage = new() { OwnerID = new() };
		}
	}
}
