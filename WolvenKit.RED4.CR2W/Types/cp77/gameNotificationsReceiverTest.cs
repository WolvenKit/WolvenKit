using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNotificationsReceiverTest : gameuiWidgetGameController
	{
		private CHandle<inkGameNotificationToken> _token;

		[Ordinal(2)] 
		[RED("token")] 
		public CHandle<inkGameNotificationToken> Token
		{
			get => GetProperty(ref _token);
			set => SetProperty(ref _token, value);
		}

		public gameNotificationsReceiverTest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
