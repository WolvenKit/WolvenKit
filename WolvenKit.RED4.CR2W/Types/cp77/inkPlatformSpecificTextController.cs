using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPlatformSpecificTextController : inkWidgetLogicController
	{
		private CName _textLocKey;
		private CName _textLocKey_PS4;
		private CName _textLocKey_XB1;

		[Ordinal(1)] 
		[RED("textLocKey")] 
		public CName TextLocKey
		{
			get
			{
				if (_textLocKey == null)
				{
					_textLocKey = (CName) CR2WTypeManager.Create("CName", "textLocKey", cr2w, this);
				}
				return _textLocKey;
			}
			set
			{
				if (_textLocKey == value)
				{
					return;
				}
				_textLocKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("textLocKey_PS4")] 
		public CName TextLocKey_PS4
		{
			get
			{
				if (_textLocKey_PS4 == null)
				{
					_textLocKey_PS4 = (CName) CR2WTypeManager.Create("CName", "textLocKey_PS4", cr2w, this);
				}
				return _textLocKey_PS4;
			}
			set
			{
				if (_textLocKey_PS4 == value)
				{
					return;
				}
				_textLocKey_PS4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("textLocKey_XB1")] 
		public CName TextLocKey_XB1
		{
			get
			{
				if (_textLocKey_XB1 == null)
				{
					_textLocKey_XB1 = (CName) CR2WTypeManager.Create("CName", "textLocKey_XB1", cr2w, this);
				}
				return _textLocKey_XB1;
			}
			set
			{
				if (_textLocKey_XB1 == value)
				{
					return;
				}
				_textLocKey_XB1 = value;
				PropertySet(this);
			}
		}

		public inkPlatformSpecificTextController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
