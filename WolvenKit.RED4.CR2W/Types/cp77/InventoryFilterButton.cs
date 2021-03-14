using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryFilterButton : BaseButtonView
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _inputIcon;
		private CBool _introPlayed;

		[Ordinal(2)] 
		[RED("Label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("InputIcon")] 
		public inkImageWidgetReference InputIcon
		{
			get
			{
				if (_inputIcon == null)
				{
					_inputIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "InputIcon", cr2w, this);
				}
				return _inputIcon;
			}
			set
			{
				if (_inputIcon == value)
				{
					return;
				}
				_inputIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("IntroPlayed")] 
		public CBool IntroPlayed
		{
			get
			{
				if (_introPlayed == null)
				{
					_introPlayed = (CBool) CR2WTypeManager.Create("Bool", "IntroPlayed", cr2w, this);
				}
				return _introPlayed;
			}
			set
			{
				if (_introPlayed == value)
				{
					return;
				}
				_introPlayed = value;
				PropertySet(this);
			}
		}

		public InventoryFilterButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
