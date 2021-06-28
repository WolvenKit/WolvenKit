using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioStationListItemController : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _typeIcon;
		private CHandle<RadioListItemData> _stationData;

		[Ordinal(15)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(16)] 
		[RED("typeIcon")] 
		public inkImageWidgetReference TypeIcon
		{
			get => GetProperty(ref _typeIcon);
			set => SetProperty(ref _typeIcon, value);
		}

		[Ordinal(17)] 
		[RED("stationData")] 
		public CHandle<RadioListItemData> StationData
		{
			get => GetProperty(ref _stationData);
			set => SetProperty(ref _stationData, value);
		}

		public RadioStationListItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
