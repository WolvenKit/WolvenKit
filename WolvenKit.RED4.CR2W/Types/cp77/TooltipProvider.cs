using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipProvider : inkWidgetLogicController
	{
		private CArray<CHandle<ATooltipData>> _tooltipsData;

		[Ordinal(1)] 
		[RED("TooltipsData")] 
		public CArray<CHandle<ATooltipData>> TooltipsData
		{
			get
			{
				if (_tooltipsData == null)
				{
					_tooltipsData = (CArray<CHandle<ATooltipData>>) CR2WTypeManager.Create("array:handle:ATooltipData", "TooltipsData", cr2w, this);
				}
				return _tooltipsData;
			}
			set
			{
				if (_tooltipsData == value)
				{
					return;
				}
				_tooltipsData = value;
				PropertySet(this);
			}
		}

		public TooltipProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
