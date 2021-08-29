using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RipperdocIdPanel : inkWidgetLogicController
	{
		private inkTextWidgetReference _nameLabel;
		private inkTextWidgetReference _moneyLabel;

		[Ordinal(1)] 
		[RED("NameLabel")] 
		public inkTextWidgetReference NameLabel
		{
			get => GetProperty(ref _nameLabel);
			set => SetProperty(ref _nameLabel, value);
		}

		[Ordinal(2)] 
		[RED("MoneyLabel")] 
		public inkTextWidgetReference MoneyLabel
		{
			get => GetProperty(ref _moneyLabel);
			set => SetProperty(ref _moneyLabel, value);
		}
	}
}
