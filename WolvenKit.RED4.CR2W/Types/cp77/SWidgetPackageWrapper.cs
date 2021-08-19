using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWidgetPackageWrapper : IScriptable
	{
		private SWidgetPackage _widgetPackage;

		[Ordinal(0)] 
		[RED("WidgetPackage")] 
		public SWidgetPackage WidgetPackage
		{
			get => GetProperty(ref _widgetPackage);
			set => SetProperty(ref _widgetPackage, value);
		}

		public SWidgetPackageWrapper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
