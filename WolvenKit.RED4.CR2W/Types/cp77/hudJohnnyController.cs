using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudJohnnyController : gameuiHUDGameController
	{
		private inkTextWidgetReference _tourHeader;
		private inkTextWidgetReference _leftDates;
		private inkTextWidgetReference _rightDates;
		private inkWidgetReference _cancelled;
		private ScriptGameInstance _gameInstance;

		[Ordinal(9)] 
		[RED("tourHeader")] 
		public inkTextWidgetReference TourHeader
		{
			get
			{
				if (_tourHeader == null)
				{
					_tourHeader = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "tourHeader", cr2w, this);
				}
				return _tourHeader;
			}
			set
			{
				if (_tourHeader == value)
				{
					return;
				}
				_tourHeader = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("leftDates")] 
		public inkTextWidgetReference LeftDates
		{
			get
			{
				if (_leftDates == null)
				{
					_leftDates = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "leftDates", cr2w, this);
				}
				return _leftDates;
			}
			set
			{
				if (_leftDates == value)
				{
					return;
				}
				_leftDates = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("rightDates")] 
		public inkTextWidgetReference RightDates
		{
			get
			{
				if (_rightDates == null)
				{
					_rightDates = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "rightDates", cr2w, this);
				}
				return _rightDates;
			}
			set
			{
				if (_rightDates == value)
				{
					return;
				}
				_rightDates = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("cancelled")] 
		public inkWidgetReference Cancelled
		{
			get
			{
				if (_cancelled == null)
				{
					_cancelled = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "cancelled", cr2w, this);
				}
				return _cancelled;
			}
			set
			{
				if (_cancelled == value)
				{
					return;
				}
				_cancelled = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		public hudJohnnyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
