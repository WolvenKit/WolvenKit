using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleScreenProjectionLogicController : inkWidgetLogicController
	{
		private wCHandle<inkTextWidget> _widgetPos;
		private wCHandle<inkTextWidget> _worldPos;
		private CHandle<inkScreenProjection> _projection;

		[Ordinal(1)] 
		[RED("widgetPos")] 
		public wCHandle<inkTextWidget> WidgetPos
		{
			get
			{
				if (_widgetPos == null)
				{
					_widgetPos = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "widgetPos", cr2w, this);
				}
				return _widgetPos;
			}
			set
			{
				if (_widgetPos == value)
				{
					return;
				}
				_widgetPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("worldPos")] 
		public wCHandle<inkTextWidget> WorldPos
		{
			get
			{
				if (_worldPos == null)
				{
					_worldPos = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "worldPos", cr2w, this);
				}
				return _worldPos;
			}
			set
			{
				if (_worldPos == value)
				{
					return;
				}
				_worldPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get
			{
				if (_projection == null)
				{
					_projection = (CHandle<inkScreenProjection>) CR2WTypeManager.Create("handle:inkScreenProjection", "projection", cr2w, this);
				}
				return _projection;
			}
			set
			{
				if (_projection == value)
				{
					return;
				}
				_projection = value;
				PropertySet(this);
			}
		}

		public sampleScreenProjectionLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
