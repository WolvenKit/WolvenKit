using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsList : inkWidgetLogicController
	{
		private wCHandle<inkTextWidget> _titleText;
		private wCHandle<inkCompoundWidget> _containerWidget;
		private CArray<wCHandle<inkWidget>> _widgtesList;

		[Ordinal(1)] 
		[RED("titleText")] 
		public wCHandle<inkTextWidget> TitleText
		{
			get => GetProperty(ref _titleText);
			set => SetProperty(ref _titleText, value);
		}

		[Ordinal(2)] 
		[RED("containerWidget")] 
		public wCHandle<inkCompoundWidget> ContainerWidget
		{
			get => GetProperty(ref _containerWidget);
			set => SetProperty(ref _containerWidget, value);
		}

		[Ordinal(3)] 
		[RED("widgtesList")] 
		public CArray<wCHandle<inkWidget>> WidgtesList
		{
			get => GetProperty(ref _widgtesList);
			set => SetProperty(ref _widgtesList, value);
		}

		public InventoryStatsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
