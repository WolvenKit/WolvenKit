using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class at_uiWidgetData : CVariable
	{
		private CString _widgetATID;
		private CEnum<inkELayerType> _layerType;
		private CName _parentGameController;

		[Ordinal(0)] 
		[RED("widgetATID")] 
		public CString WidgetATID
		{
			get => GetProperty(ref _widgetATID);
			set => SetProperty(ref _widgetATID, value);
		}

		[Ordinal(1)] 
		[RED("layerType")] 
		public CEnum<inkELayerType> LayerType
		{
			get => GetProperty(ref _layerType);
			set => SetProperty(ref _layerType, value);
		}

		[Ordinal(2)] 
		[RED("parentGameController")] 
		public CName ParentGameController
		{
			get => GetProperty(ref _parentGameController);
			set => SetProperty(ref _parentGameController, value);
		}

		public at_uiWidgetData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
