using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NamedTooltipController : IScriptable
	{
		private CName _identifier;
		private wCHandle<AGenericTooltipController> _controller;

		[Ordinal(0)] 
		[RED("identifier")] 
		public CName Identifier
		{
			get
			{
				if (_identifier == null)
				{
					_identifier = (CName) CR2WTypeManager.Create("CName", "identifier", cr2w, this);
				}
				return _identifier;
			}
			set
			{
				if (_identifier == value)
				{
					return;
				}
				_identifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public wCHandle<AGenericTooltipController> Controller
		{
			get
			{
				if (_controller == null)
				{
					_controller = (wCHandle<AGenericTooltipController>) CR2WTypeManager.Create("whandle:AGenericTooltipController", "controller", cr2w, this);
				}
				return _controller;
			}
			set
			{
				if (_controller == value)
				{
					return;
				}
				_controller = value;
				PropertySet(this);
			}
		}

		public NamedTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
