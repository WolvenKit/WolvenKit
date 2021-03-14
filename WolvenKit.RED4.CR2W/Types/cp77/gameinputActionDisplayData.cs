using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinputActionDisplayData : CVariable
	{
		private CName _name;
		private CBool _isHold;
		private CString _inputDisplayPad;
		private CString _inputDisplayKeyboard;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isHold")] 
		public CBool IsHold
		{
			get
			{
				if (_isHold == null)
				{
					_isHold = (CBool) CR2WTypeManager.Create("Bool", "isHold", cr2w, this);
				}
				return _isHold;
			}
			set
			{
				if (_isHold == value)
				{
					return;
				}
				_isHold = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inputDisplayPad")] 
		public CString InputDisplayPad
		{
			get
			{
				if (_inputDisplayPad == null)
				{
					_inputDisplayPad = (CString) CR2WTypeManager.Create("String", "inputDisplayPad", cr2w, this);
				}
				return _inputDisplayPad;
			}
			set
			{
				if (_inputDisplayPad == value)
				{
					return;
				}
				_inputDisplayPad = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inputDisplayKeyboard")] 
		public CString InputDisplayKeyboard
		{
			get
			{
				if (_inputDisplayKeyboard == null)
				{
					_inputDisplayKeyboard = (CString) CR2WTypeManager.Create("String", "inputDisplayKeyboard", cr2w, this);
				}
				return _inputDisplayKeyboard;
			}
			set
			{
				if (_inputDisplayKeyboard == value)
				{
					return;
				}
				_inputDisplayKeyboard = value;
				PropertySet(this);
			}
		}

		public gameinputActionDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
