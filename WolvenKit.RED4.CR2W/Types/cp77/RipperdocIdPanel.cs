using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocIdPanel : inkWidgetLogicController
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

		public RipperdocIdPanel(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
