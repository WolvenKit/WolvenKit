using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestMapPinBase : gameJournalContainerEntry
	{
		private CBool _enableGPS;

		[Ordinal(2)] 
		[RED("enableGPS")] 
		public CBool EnableGPS
		{
			get
			{
				if (_enableGPS == null)
				{
					_enableGPS = (CBool) CR2WTypeManager.Create("Bool", "enableGPS", cr2w, this);
				}
				return _enableGPS;
			}
			set
			{
				if (_enableGPS == value)
				{
					return;
				}
				_enableGPS = value;
				PropertySet(this);
			}
		}

		public gameJournalQuestMapPinBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
