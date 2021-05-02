using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GoToMenuEvent : redEvent
	{
		private CEnum<EComputerMenuType> _menuType;
		private CBool _wakeUp;
		private entEntityID _ownerID;

		[Ordinal(0)] 
		[RED("menuType")] 
		public CEnum<EComputerMenuType> MenuType
		{
			get => GetProperty(ref _menuType);
			set => SetProperty(ref _menuType, value);
		}

		[Ordinal(1)] 
		[RED("wakeUp")] 
		public CBool WakeUp
		{
			get => GetProperty(ref _wakeUp);
			set => SetProperty(ref _wakeUp, value);
		}

		[Ordinal(2)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		public GoToMenuEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
