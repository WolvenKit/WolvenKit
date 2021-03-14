using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapQuestMappinController : gameuiBaseMinimapMappinController
	{
		private wCHandle<gamemappinsQuestMappin> _questMappin;

		[Ordinal(14)] 
		[RED("questMappin")] 
		public wCHandle<gamemappinsQuestMappin> QuestMappin
		{
			get
			{
				if (_questMappin == null)
				{
					_questMappin = (wCHandle<gamemappinsQuestMappin>) CR2WTypeManager.Create("whandle:gamemappinsQuestMappin", "questMappin", cr2w, this);
				}
				return _questMappin;
			}
			set
			{
				if (_questMappin == value)
				{
					return;
				}
				_questMappin = value;
				PropertySet(this);
			}
		}

		public gameuiMinimapQuestMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
