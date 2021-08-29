using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HubMenuInitData : IScriptable
	{
		private CName _menuName;
		private CName _submenuName;
		private CHandle<IScriptable> _userData;

		[Ordinal(0)] 
		[RED("menuName")] 
		public CName MenuName
		{
			get => GetProperty(ref _menuName);
			set => SetProperty(ref _menuName, value);
		}

		[Ordinal(1)] 
		[RED("submenuName")] 
		public CName SubmenuName
		{
			get => GetProperty(ref _submenuName);
			set => SetProperty(ref _submenuName, value);
		}

		[Ordinal(2)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}
	}
}
