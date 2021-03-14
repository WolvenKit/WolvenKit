using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTooltipSlotData : inkUserData
	{
		private inkMargin _margin;
		private CEnum<gameuiETooltipPlacement> _placement;

		[Ordinal(0)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get
			{
				if (_margin == null)
				{
					_margin = (inkMargin) CR2WTypeManager.Create("inkMargin", "margin", cr2w, this);
				}
				return _margin;
			}
			set
			{
				if (_margin == value)
				{
					return;
				}
				_margin = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("placement")] 
		public CEnum<gameuiETooltipPlacement> Placement
		{
			get
			{
				if (_placement == null)
				{
					_placement = (CEnum<gameuiETooltipPlacement>) CR2WTypeManager.Create("gameuiETooltipPlacement", "placement", cr2w, this);
				}
				return _placement;
			}
			set
			{
				if (_placement == value)
				{
					return;
				}
				_placement = value;
				PropertySet(this);
			}
		}

		public gameuiTooltipSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
