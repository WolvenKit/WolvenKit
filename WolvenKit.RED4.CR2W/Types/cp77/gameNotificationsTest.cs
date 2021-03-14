using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNotificationsTest : gameuiWidgetGameController
	{
		private CHandle<inkGameNotificationToken> _token;

		[Ordinal(2)] 
		[RED("token")] 
		public CHandle<inkGameNotificationToken> Token
		{
			get
			{
				if (_token == null)
				{
					_token = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "token", cr2w, this);
				}
				return _token;
			}
			set
			{
				if (_token == value)
				{
					return;
				}
				_token = value;
				PropertySet(this);
			}
		}

		public gameNotificationsTest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
