using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuestMappinController : gameuiInteractionMappinController
	{
		private CBool _nameplateVisible;
		private inkTextWidgetReference _distanceText;
		private inkTextWidgetReference _displayName;

		[Ordinal(11)] 
		[RED("nameplateVisible")] 
		public CBool NameplateVisible
		{
			get
			{
				if (_nameplateVisible == null)
				{
					_nameplateVisible = (CBool) CR2WTypeManager.Create("Bool", "nameplateVisible", cr2w, this);
				}
				return _nameplateVisible;
			}
			set
			{
				if (_nameplateVisible == value)
				{
					return;
				}
				_nameplateVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("distanceText")] 
		public inkTextWidgetReference DistanceText
		{
			get
			{
				if (_distanceText == null)
				{
					_distanceText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "distanceText", cr2w, this);
				}
				return _distanceText;
			}
			set
			{
				if (_distanceText == value)
				{
					return;
				}
				_distanceText = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("displayName")] 
		public inkTextWidgetReference DisplayName
		{
			get
			{
				if (_displayName == null)
				{
					_displayName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "displayName", cr2w, this);
				}
				return _displayName;
			}
			set
			{
				if (_displayName == value)
				{
					return;
				}
				_displayName = value;
				PropertySet(this);
			}
		}

		public gameuiQuestMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
