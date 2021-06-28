using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPlayerListGameController : gameuiHUDGameController
	{
		private CArray<PlayerListEntryData> _playerEntries;
		private inkCompoundWidgetReference _container;

		[Ordinal(9)] 
		[RED("playerEntries")] 
		public CArray<PlayerListEntryData> PlayerEntries
		{
			get => GetProperty(ref _playerEntries);
			set => SetProperty(ref _playerEntries, value);
		}

		[Ordinal(10)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		public gameuiPlayerListGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
