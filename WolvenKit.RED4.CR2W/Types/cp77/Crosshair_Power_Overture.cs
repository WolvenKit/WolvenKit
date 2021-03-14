using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Power_Overture : gameuiCrosshairBaseGameController
	{
		private inkWidgetReference _leftPart;
		private inkWidgetReference _rightPart;
		private inkWidgetReference _topPart;
		private inkWidgetReference _botPart;

		[Ordinal(18)] 
		[RED("leftPart")] 
		public inkWidgetReference LeftPart
		{
			get
			{
				if (_leftPart == null)
				{
					_leftPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "leftPart", cr2w, this);
				}
				return _leftPart;
			}
			set
			{
				if (_leftPart == value)
				{
					return;
				}
				_leftPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("rightPart")] 
		public inkWidgetReference RightPart
		{
			get
			{
				if (_rightPart == null)
				{
					_rightPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rightPart", cr2w, this);
				}
				return _rightPart;
			}
			set
			{
				if (_rightPart == value)
				{
					return;
				}
				_rightPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("topPart")] 
		public inkWidgetReference TopPart
		{
			get
			{
				if (_topPart == null)
				{
					_topPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "topPart", cr2w, this);
				}
				return _topPart;
			}
			set
			{
				if (_topPart == value)
				{
					return;
				}
				_topPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("botPart")] 
		public inkWidgetReference BotPart
		{
			get
			{
				if (_botPart == null)
				{
					_botPart = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "botPart", cr2w, this);
				}
				return _botPart;
			}
			set
			{
				if (_botPart == value)
				{
					return;
				}
				_botPart = value;
				PropertySet(this);
			}
		}

		public Crosshair_Power_Overture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
