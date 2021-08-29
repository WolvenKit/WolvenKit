using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleListItemData : IScriptable
	{
		private CName _displayName;
		private vehiclePlayerVehicle _data;
		private CWeakHandle<gamedataUIIcon_Record> _icon;

		[Ordinal(0)] 
		[RED("displayName")] 
		public CName DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public vehiclePlayerVehicle Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CWeakHandle<gamedataUIIcon_Record> Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}
	}
}
