using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_CompassInfoDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Float _northOffset;
		private gamebbScriptID_Float _southOffset;
		private gamebbScriptID_Float _eastOffset;
		private gamebbScriptID_Float _westOffset;
		private gamebbScriptID_Variant _pins;

		[Ordinal(0)] 
		[RED("NorthOffset")] 
		public gamebbScriptID_Float NorthOffset
		{
			get => GetProperty(ref _northOffset);
			set => SetProperty(ref _northOffset, value);
		}

		[Ordinal(1)] 
		[RED("SouthOffset")] 
		public gamebbScriptID_Float SouthOffset
		{
			get => GetProperty(ref _southOffset);
			set => SetProperty(ref _southOffset, value);
		}

		[Ordinal(2)] 
		[RED("EastOffset")] 
		public gamebbScriptID_Float EastOffset
		{
			get => GetProperty(ref _eastOffset);
			set => SetProperty(ref _eastOffset, value);
		}

		[Ordinal(3)] 
		[RED("WestOffset")] 
		public gamebbScriptID_Float WestOffset
		{
			get => GetProperty(ref _westOffset);
			set => SetProperty(ref _westOffset, value);
		}

		[Ordinal(4)] 
		[RED("Pins")] 
		public gamebbScriptID_Variant Pins
		{
			get => GetProperty(ref _pins);
			set => SetProperty(ref _pins, value);
		}
	}
}
