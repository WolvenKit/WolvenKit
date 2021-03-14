using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkHoverOutEvent : redEvent
	{
		private wCHandle<inkWidget> _widget;
		private CHandle<BasePerkDisplayData> _perkData;

		[Ordinal(0)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get
			{
				if (_widget == null)
				{
					_widget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "widget", cr2w, this);
				}
				return _widget;
			}
			set
			{
				if (_widget == value)
				{
					return;
				}
				_widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("perkData")] 
		public CHandle<BasePerkDisplayData> PerkData
		{
			get
			{
				if (_perkData == null)
				{
					_perkData = (CHandle<BasePerkDisplayData>) CR2WTypeManager.Create("handle:BasePerkDisplayData", "perkData", cr2w, this);
				}
				return _perkData;
			}
			set
			{
				if (_perkData == value)
				{
					return;
				}
				_perkData = value;
				PropertySet(this);
			}
		}

		public PerkHoverOutEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
