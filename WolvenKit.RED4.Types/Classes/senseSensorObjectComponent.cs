using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseSensorObjectComponent : entIPlacedComponent
	{
		private CHandle<senseSensorObject> _sensorObject;
		private CBool _isEnabled;

		[Ordinal(5)] 
		[RED("sensorObject")] 
		public CHandle<senseSensorObject> SensorObject
		{
			get => GetProperty(ref _sensorObject);
			set => SetProperty(ref _sensorObject, value);
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public senseSensorObjectComponent()
		{
			_isEnabled = true;
		}
	}
}
