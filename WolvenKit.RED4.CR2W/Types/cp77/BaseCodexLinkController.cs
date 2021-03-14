using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseCodexLinkController : inkWidgetLogicController
	{
		private inkImageWidgetReference _linkImage;
		private inkTextWidgetReference _linkLabel;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(1)] 
		[RED("linkImage")] 
		public inkImageWidgetReference LinkImage
		{
			get
			{
				if (_linkImage == null)
				{
					_linkImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "linkImage", cr2w, this);
				}
				return _linkImage;
			}
			set
			{
				if (_linkImage == value)
				{
					return;
				}
				_linkImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("linkLabel")] 
		public inkTextWidgetReference LinkLabel
		{
			get
			{
				if (_linkLabel == null)
				{
					_linkLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "linkLabel", cr2w, this);
				}
				return _linkLabel;
			}
			set
			{
				if (_linkLabel == value)
				{
					return;
				}
				_linkLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		public BaseCodexLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
