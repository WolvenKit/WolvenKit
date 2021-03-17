using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgramTooltipStatController : inkWidgetLogicController
	{
		private inkImageWidgetReference _arrow;
		private inkTextWidgetReference _value;
		private inkTextWidgetReference _diffValue;

		[Ordinal(1)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetProperty(ref _arrow);
			set => SetProperty(ref _arrow, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(3)] 
		[RED("diffValue")] 
		public inkTextWidgetReference DiffValue
		{
			get => GetProperty(ref _diffValue);
			set => SetProperty(ref _diffValue, value);
		}

		public ProgramTooltipStatController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
