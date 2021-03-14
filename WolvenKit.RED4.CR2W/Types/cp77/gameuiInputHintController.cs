using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintController : inkWidgetLogicController
	{
		private inkWidgetLibraryReference _inputDisplayLibRef;
		private inkCompoundWidgetReference _inputDisplayContainer;
		private inkTextWidgetReference _textWidgetRef;

		[Ordinal(1)] 
		[RED("inputDisplayLibRef")] 
		public inkWidgetLibraryReference InputDisplayLibRef
		{
			get
			{
				if (_inputDisplayLibRef == null)
				{
					_inputDisplayLibRef = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "inputDisplayLibRef", cr2w, this);
				}
				return _inputDisplayLibRef;
			}
			set
			{
				if (_inputDisplayLibRef == value)
				{
					return;
				}
				_inputDisplayLibRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inputDisplayContainer")] 
		public inkCompoundWidgetReference InputDisplayContainer
		{
			get
			{
				if (_inputDisplayContainer == null)
				{
					_inputDisplayContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "inputDisplayContainer", cr2w, this);
				}
				return _inputDisplayContainer;
			}
			set
			{
				if (_inputDisplayContainer == value)
				{
					return;
				}
				_inputDisplayContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("textWidgetRef")] 
		public inkTextWidgetReference TextWidgetRef
		{
			get
			{
				if (_textWidgetRef == null)
				{
					_textWidgetRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "textWidgetRef", cr2w, this);
				}
				return _textWidgetRef;
			}
			set
			{
				if (_textWidgetRef == value)
				{
					return;
				}
				_textWidgetRef = value;
				PropertySet(this);
			}
		}

		public gameuiInputHintController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
