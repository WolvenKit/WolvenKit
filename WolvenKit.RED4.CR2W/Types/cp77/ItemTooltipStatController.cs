using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipStatController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statName;
		private inkTextWidgetReference _statValue;
		private inkWidgetReference _statComparedContainer;
		private inkTextWidgetReference _statComparedValue;
		private inkImageWidgetReference _arrow;

		[Ordinal(1)] 
		[RED("statName")] 
		public inkTextWidgetReference StatName
		{
			get => GetProperty(ref _statName);
			set => SetProperty(ref _statName, value);
		}

		[Ordinal(2)] 
		[RED("statValue")] 
		public inkTextWidgetReference StatValue
		{
			get => GetProperty(ref _statValue);
			set => SetProperty(ref _statValue, value);
		}

		[Ordinal(3)] 
		[RED("statComparedContainer")] 
		public inkWidgetReference StatComparedContainer
		{
			get => GetProperty(ref _statComparedContainer);
			set => SetProperty(ref _statComparedContainer, value);
		}

		[Ordinal(4)] 
		[RED("statComparedValue")] 
		public inkTextWidgetReference StatComparedValue
		{
			get => GetProperty(ref _statComparedValue);
			set => SetProperty(ref _statComparedValue, value);
		}

		[Ordinal(5)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetProperty(ref _arrow);
			set => SetProperty(ref _arrow, value);
		}

		public ItemTooltipStatController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
