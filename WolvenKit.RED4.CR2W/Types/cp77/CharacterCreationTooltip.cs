using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationTooltip : MessageTooltip
	{
		private inkTextWidgetReference _attribiuteLevel;
		private inkTextWidgetReference _maxedOrMinimumLabelText;
		private inkWidgetReference _maxedOrMinimumLabel;
		private inkWidgetReference _attribiuteLevelLabel;

		[Ordinal(5)] 
		[RED("attribiuteLevel")] 
		public inkTextWidgetReference AttribiuteLevel
		{
			get
			{
				if (_attribiuteLevel == null)
				{
					_attribiuteLevel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "attribiuteLevel", cr2w, this);
				}
				return _attribiuteLevel;
			}
			set
			{
				if (_attribiuteLevel == value)
				{
					return;
				}
				_attribiuteLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maxedOrMinimumLabelText")] 
		public inkTextWidgetReference MaxedOrMinimumLabelText
		{
			get
			{
				if (_maxedOrMinimumLabelText == null)
				{
					_maxedOrMinimumLabelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "maxedOrMinimumLabelText", cr2w, this);
				}
				return _maxedOrMinimumLabelText;
			}
			set
			{
				if (_maxedOrMinimumLabelText == value)
				{
					return;
				}
				_maxedOrMinimumLabelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maxedOrMinimumLabel")] 
		public inkWidgetReference MaxedOrMinimumLabel
		{
			get
			{
				if (_maxedOrMinimumLabel == null)
				{
					_maxedOrMinimumLabel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "maxedOrMinimumLabel", cr2w, this);
				}
				return _maxedOrMinimumLabel;
			}
			set
			{
				if (_maxedOrMinimumLabel == value)
				{
					return;
				}
				_maxedOrMinimumLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("attribiuteLevelLabel")] 
		public inkWidgetReference AttribiuteLevelLabel
		{
			get
			{
				if (_attribiuteLevelLabel == null)
				{
					_attribiuteLevelLabel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attribiuteLevelLabel", cr2w, this);
				}
				return _attribiuteLevelLabel;
			}
			set
			{
				if (_attribiuteLevelLabel == value)
				{
					return;
				}
				_attribiuteLevelLabel = value;
				PropertySet(this);
			}
		}

		public CharacterCreationTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
