using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInteractionMappinController : gameuiMappinBaseController
	{
		private CBool _isCurrentlyClamped;
		private CBool _isUnderCrosshair;
		private CName _canvasWidgetName;
		private CName _arrowWidgetName;

		[Ordinal(7)] 
		[RED("isCurrentlyClamped")] 
		public CBool IsCurrentlyClamped
		{
			get
			{
				if (_isCurrentlyClamped == null)
				{
					_isCurrentlyClamped = (CBool) CR2WTypeManager.Create("Bool", "isCurrentlyClamped", cr2w, this);
				}
				return _isCurrentlyClamped;
			}
			set
			{
				if (_isCurrentlyClamped == value)
				{
					return;
				}
				_isCurrentlyClamped = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isUnderCrosshair")] 
		public CBool IsUnderCrosshair
		{
			get
			{
				if (_isUnderCrosshair == null)
				{
					_isUnderCrosshair = (CBool) CR2WTypeManager.Create("Bool", "isUnderCrosshair", cr2w, this);
				}
				return _isUnderCrosshair;
			}
			set
			{
				if (_isUnderCrosshair == value)
				{
					return;
				}
				_isUnderCrosshair = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("canvasWidgetName")] 
		public CName CanvasWidgetName
		{
			get
			{
				if (_canvasWidgetName == null)
				{
					_canvasWidgetName = (CName) CR2WTypeManager.Create("CName", "canvasWidgetName", cr2w, this);
				}
				return _canvasWidgetName;
			}
			set
			{
				if (_canvasWidgetName == value)
				{
					return;
				}
				_canvasWidgetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("arrowWidgetName")] 
		public CName ArrowWidgetName
		{
			get
			{
				if (_arrowWidgetName == null)
				{
					_arrowWidgetName = (CName) CR2WTypeManager.Create("CName", "arrowWidgetName", cr2w, this);
				}
				return _arrowWidgetName;
			}
			set
			{
				if (_arrowWidgetName == value)
				{
					return;
				}
				_arrowWidgetName = value;
				PropertySet(this);
			}
		}

		public gameuiInteractionMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
