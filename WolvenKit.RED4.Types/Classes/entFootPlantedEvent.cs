using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entFootPlantedEvent : redEvent
	{
		private CName _customAction;
		private CEnum<animEventSide> _footSide;

		[Ordinal(0)] 
		[RED("customAction")] 
		public CName CustomAction
		{
			get => GetProperty(ref _customAction);
			set => SetProperty(ref _customAction, value);
		}

		[Ordinal(1)] 
		[RED("footSide")] 
		public CEnum<animEventSide> FootSide
		{
			get => GetProperty(ref _footSide);
			set => SetProperty(ref _footSide, value);
		}
	}
}
