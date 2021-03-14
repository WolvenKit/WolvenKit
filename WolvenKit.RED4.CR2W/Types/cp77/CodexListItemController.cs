using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexListItemController : inkListItemController
	{
		private CBool _doMarkNew;
		private inkWidgetReference _stateMapperRef;
		private wCHandle<ListItemStateMapper> _stateMapper;

		[Ordinal(16)] 
		[RED("doMarkNew")] 
		public CBool DoMarkNew
		{
			get
			{
				if (_doMarkNew == null)
				{
					_doMarkNew = (CBool) CR2WTypeManager.Create("Bool", "doMarkNew", cr2w, this);
				}
				return _doMarkNew;
			}
			set
			{
				if (_doMarkNew == value)
				{
					return;
				}
				_doMarkNew = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("stateMapperRef")] 
		public inkWidgetReference StateMapperRef
		{
			get
			{
				if (_stateMapperRef == null)
				{
					_stateMapperRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "stateMapperRef", cr2w, this);
				}
				return _stateMapperRef;
			}
			set
			{
				if (_stateMapperRef == value)
				{
					return;
				}
				_stateMapperRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("stateMapper")] 
		public wCHandle<ListItemStateMapper> StateMapper
		{
			get
			{
				if (_stateMapper == null)
				{
					_stateMapper = (wCHandle<ListItemStateMapper>) CR2WTypeManager.Create("whandle:ListItemStateMapper", "stateMapper", cr2w, this);
				}
				return _stateMapper;
			}
			set
			{
				if (_stateMapper == value)
				{
					return;
				}
				_stateMapper = value;
				PropertySet(this);
			}
		}

		public CodexListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
