using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemotePlayerMappinController : gameuiInteractionMappinController
	{
		private wCHandle<gamemappinsRemotePlayerMappin> _mappin;
		private wCHandle<inkWidget> _root;

		[Ordinal(11)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsRemotePlayerMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(12)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		public RemotePlayerMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
