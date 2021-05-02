using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemLabelController : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _moneyIcon;
		private CEnum<ItemLabelType> _type;

		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(2)] 
		[RED("moneyIcon")] 
		public inkImageWidgetReference MoneyIcon
		{
			get => GetProperty(ref _moneyIcon);
			set => SetProperty(ref _moneyIcon, value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<ItemLabelType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public ItemLabelController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
