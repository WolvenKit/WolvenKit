using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingNotification : GenericNotificationController
	{
		private CHandle<inkanimProxy> _introAnimation;

		[Ordinal(12)] 
		[RED("introAnimation")] 
		public CHandle<inkanimProxy> IntroAnimation
		{
			get
			{
				if (_introAnimation == null)
				{
					_introAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "introAnimation", cr2w, this);
				}
				return _introAnimation;
			}
			set
			{
				if (_introAnimation == value)
				{
					return;
				}
				_introAnimation = value;
				PropertySet(this);
			}
		}

		public CraftingNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
