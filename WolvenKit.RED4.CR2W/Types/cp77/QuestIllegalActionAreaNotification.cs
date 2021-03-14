using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestIllegalActionAreaNotification : redEvent
	{
		private RevealPlayerSettings _revealPlayerSettings;

		[Ordinal(0)] 
		[RED("revealPlayerSettings")] 
		public RevealPlayerSettings RevealPlayerSettings
		{
			get
			{
				if (_revealPlayerSettings == null)
				{
					_revealPlayerSettings = (RevealPlayerSettings) CR2WTypeManager.Create("RevealPlayerSettings", "revealPlayerSettings", cr2w, this);
				}
				return _revealPlayerSettings;
			}
			set
			{
				if (_revealPlayerSettings == value)
				{
					return;
				}
				_revealPlayerSettings = value;
				PropertySet(this);
			}
		}

		public QuestIllegalActionAreaNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
