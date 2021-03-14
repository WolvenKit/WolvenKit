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
			get
			{
				if (_nameLabel == null)
				{
					_nameLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "NameLabel", cr2w, this);
				}
				return _nameLabel;
			}
			set
			{
				if (_nameLabel == value)
				{
					return;
				}
				_nameLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("MoneyLabel")] 
		public inkTextWidgetReference MoneyLabel
		{
			get
			{
				if (_moneyLabel == null)
				{
					_moneyLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "MoneyLabel", cr2w, this);
				}
				return _moneyLabel;
			}
			set
			{
				if (_moneyLabel == value)
				{
					return;
				}
				_moneyLabel = value;
				PropertySet(this);
			}
		}

		public RipperdocIdPanel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
