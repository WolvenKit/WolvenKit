using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMenuAccountLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _playerId;
		private inkTextWidgetReference _changeAccountLabelTextRef;
		private inkWidgetReference _inputDisplayControllerRef;
		private CBool _changeAccountEnabled;

		[Ordinal(1)] 
		[RED("playerId")] 
		public inkTextWidgetReference PlayerId
		{
			get
			{
				if (_playerId == null)
				{
					_playerId = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "playerId", cr2w, this);
				}
				return _playerId;
			}
			set
			{
				if (_playerId == value)
				{
					return;
				}
				_playerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("changeAccountLabelTextRef")] 
		public inkTextWidgetReference ChangeAccountLabelTextRef
		{
			get
			{
				if (_changeAccountLabelTextRef == null)
				{
					_changeAccountLabelTextRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "changeAccountLabelTextRef", cr2w, this);
				}
				return _changeAccountLabelTextRef;
			}
			set
			{
				if (_changeAccountLabelTextRef == value)
				{
					return;
				}
				_changeAccountLabelTextRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inputDisplayControllerRef")] 
		public inkWidgetReference InputDisplayControllerRef
		{
			get
			{
				if (_inputDisplayControllerRef == null)
				{
					_inputDisplayControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputDisplayControllerRef", cr2w, this);
				}
				return _inputDisplayControllerRef;
			}
			set
			{
				if (_inputDisplayControllerRef == value)
				{
					return;
				}
				_inputDisplayControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("changeAccountEnabled")] 
		public CBool ChangeAccountEnabled
		{
			get
			{
				if (_changeAccountEnabled == null)
				{
					_changeAccountEnabled = (CBool) CR2WTypeManager.Create("Bool", "changeAccountEnabled", cr2w, this);
				}
				return _changeAccountEnabled;
			}
			set
			{
				if (_changeAccountEnabled == value)
				{
					return;
				}
				_changeAccountEnabled = value;
				PropertySet(this);
			}
		}

		public inkMenuAccountLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
