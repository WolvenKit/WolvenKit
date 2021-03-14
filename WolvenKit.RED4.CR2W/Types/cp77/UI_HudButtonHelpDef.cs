using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HudButtonHelpDef : gamebbScriptDefinition
	{
		private gamebbScriptID_String _button1_Text;
		private gamebbScriptID_CName _button1_Icon;
		private gamebbScriptID_String _button2_Text;
		private gamebbScriptID_CName _button2_Icon;
		private gamebbScriptID_String _button3_Text;
		private gamebbScriptID_CName _button3_Icon;

		[Ordinal(0)] 
		[RED("button1_Text")] 
		public gamebbScriptID_String Button1_Text
		{
			get
			{
				if (_button1_Text == null)
				{
					_button1_Text = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "button1_Text", cr2w, this);
				}
				return _button1_Text;
			}
			set
			{
				if (_button1_Text == value)
				{
					return;
				}
				_button1_Text = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("button1_Icon")] 
		public gamebbScriptID_CName Button1_Icon
		{
			get
			{
				if (_button1_Icon == null)
				{
					_button1_Icon = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "button1_Icon", cr2w, this);
				}
				return _button1_Icon;
			}
			set
			{
				if (_button1_Icon == value)
				{
					return;
				}
				_button1_Icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("button2_Text")] 
		public gamebbScriptID_String Button2_Text
		{
			get
			{
				if (_button2_Text == null)
				{
					_button2_Text = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "button2_Text", cr2w, this);
				}
				return _button2_Text;
			}
			set
			{
				if (_button2_Text == value)
				{
					return;
				}
				_button2_Text = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("button2_Icon")] 
		public gamebbScriptID_CName Button2_Icon
		{
			get
			{
				if (_button2_Icon == null)
				{
					_button2_Icon = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "button2_Icon", cr2w, this);
				}
				return _button2_Icon;
			}
			set
			{
				if (_button2_Icon == value)
				{
					return;
				}
				_button2_Icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("button3_Text")] 
		public gamebbScriptID_String Button3_Text
		{
			get
			{
				if (_button3_Text == null)
				{
					_button3_Text = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "button3_Text", cr2w, this);
				}
				return _button3_Text;
			}
			set
			{
				if (_button3_Text == value)
				{
					return;
				}
				_button3_Text = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("button3_Icon")] 
		public gamebbScriptID_CName Button3_Icon
		{
			get
			{
				if (_button3_Icon == null)
				{
					_button3_Icon = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "button3_Icon", cr2w, this);
				}
				return _button3_Icon;
			}
			set
			{
				if (_button3_Icon == value)
				{
					return;
				}
				_button3_Icon = value;
				PropertySet(this);
			}
		}

		public UI_HudButtonHelpDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
