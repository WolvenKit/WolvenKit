using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestWidgetUpdateEvent : redEvent
	{
		private gamePersistentID _requester;
		private ScreenDefinitionPackage _screenDefinition;

		[Ordinal(0)] 
		[RED("requester")] 
		public gamePersistentID Requester
		{
			get
			{
				if (_requester == null)
				{
					_requester = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "requester", cr2w, this);
				}
				return _requester;
			}
			set
			{
				if (_requester == value)
				{
					return;
				}
				_requester = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("screenDefinition")] 
		public ScreenDefinitionPackage ScreenDefinition
		{
			get
			{
				if (_screenDefinition == null)
				{
					_screenDefinition = (ScreenDefinitionPackage) CR2WTypeManager.Create("ScreenDefinitionPackage", "screenDefinition", cr2w, this);
				}
				return _screenDefinition;
			}
			set
			{
				if (_screenDefinition == value)
				{
					return;
				}
				_screenDefinition = value;
				PropertySet(this);
			}
		}

		public RequestWidgetUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
