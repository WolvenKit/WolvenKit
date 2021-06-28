using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentWidgets : CVariable
	{
		private CArray<inkWidgetReference> _widgetArray;

		[Ordinal(0)] 
		[RED("widgetArray")] 
		public CArray<inkWidgetReference> WidgetArray
		{
			get => GetProperty(ref _widgetArray);
			set => SetProperty(ref _widgetArray, value);
		}

		public EquipmentWidgets(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
