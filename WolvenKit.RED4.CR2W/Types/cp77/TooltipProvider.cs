using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipProvider : inkWidgetLogicController
	{
		private CArray<CHandle<ATooltipData>> _tooltipsData;
		private CBool _visible;

		[Ordinal(1)] 
		[RED("TooltipsData")] 
		public CArray<CHandle<ATooltipData>> TooltipsData
		{
			get => GetProperty(ref _tooltipsData);
			set => SetProperty(ref _tooltipsData, value);
		}

		[Ordinal(2)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetProperty(ref _visible);
			set => SetProperty(ref _visible, value);
		}

		public TooltipProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
