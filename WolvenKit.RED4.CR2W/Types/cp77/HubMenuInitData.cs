using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubMenuInitData : IScriptable
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

		public HubMenuInitData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
