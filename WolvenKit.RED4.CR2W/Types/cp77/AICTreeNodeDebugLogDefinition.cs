using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeDebugLogDefinition : AICTreeExtendableNodeDefinition
	{
		private CString _text;
		private CFloat _timeOnScreen;
		private CBool _useVisualDebug;

		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
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
		[RED("timeOnScreen")] 
		public CFloat TimeOnScreen
		{
			get
			{
				if (_timeOnScreen == null)
				{
					_timeOnScreen = (CFloat) CR2WTypeManager.Create("Float", "timeOnScreen", cr2w, this);
				}
				return _timeOnScreen;
			}
			set
			{
				if (_timeOnScreen == value)
				{
					return;
				}
				_timeOnScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useVisualDebug")] 
		public CBool UseVisualDebug
		{
			get
			{
				if (_useVisualDebug == null)
				{
					_useVisualDebug = (CBool) CR2WTypeManager.Create("Bool", "useVisualDebug", cr2w, this);
				}
				return _useVisualDebug;
			}
			set
			{
				if (_useVisualDebug == value)
				{
					return;
				}
				_useVisualDebug = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeDebugLogDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
