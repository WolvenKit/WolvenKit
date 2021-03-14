using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemsPoolCachedData : IScriptable
	{
		private CHandle<ATooltipData> _tooltipData;

		[Ordinal(0)] 
		[RED("tooltipData")] 
		public CHandle<ATooltipData> TooltipData
		{
			get
			{
				if (_tooltipData == null)
				{
					_tooltipData = (CHandle<ATooltipData>) CR2WTypeManager.Create("handle:ATooltipData", "tooltipData", cr2w, this);
				}
				return _tooltipData;
			}
			set
			{
				if (_tooltipData == value)
				{
					return;
				}
				_tooltipData = value;
				PropertySet(this);
			}
		}

		public ItemsPoolCachedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
