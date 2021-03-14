using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShowCustomTooltip_NodeType : questIUIManagerNodeType
	{
		private CBool _setTooltip;
		private LocalizationString _text;
		private CString _inputAction;
		private CEnum<inkInputHintHoldIndicationType> _holdIndicationType;

		[Ordinal(0)] 
		[RED("setTooltip")] 
		public CBool SetTooltip
		{
			get
			{
				if (_setTooltip == null)
				{
					_setTooltip = (CBool) CR2WTypeManager.Create("Bool", "setTooltip", cr2w, this);
				}
				return _setTooltip;
			}
			set
			{
				if (_setTooltip == value)
				{
					return;
				}
				_setTooltip = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inputAction")] 
		public CString InputAction
		{
			get
			{
				if (_inputAction == null)
				{
					_inputAction = (CString) CR2WTypeManager.Create("String", "inputAction", cr2w, this);
				}
				return _inputAction;
			}
			set
			{
				if (_inputAction == value)
				{
					return;
				}
				_inputAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("holdIndicationType")] 
		public CEnum<inkInputHintHoldIndicationType> HoldIndicationType
		{
			get
			{
				if (_holdIndicationType == null)
				{
					_holdIndicationType = (CEnum<inkInputHintHoldIndicationType>) CR2WTypeManager.Create("inkInputHintHoldIndicationType", "holdIndicationType", cr2w, this);
				}
				return _holdIndicationType;
			}
			set
			{
				if (_holdIndicationType == value)
				{
					return;
				}
				_holdIndicationType = value;
				PropertySet(this);
			}
		}

		public questShowCustomTooltip_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
