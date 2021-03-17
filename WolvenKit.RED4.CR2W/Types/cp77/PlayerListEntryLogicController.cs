using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerListEntryLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _playerNameLabel;
		private inkImageWidgetReference _playerClassIcon;

		[Ordinal(1)] 
		[RED("playerNameLabel")] 
		public inkWidgetReference PlayerNameLabel
		{
			get => GetProperty(ref _playerNameLabel);
			set => SetProperty(ref _playerNameLabel, value);
		}

		[Ordinal(2)] 
		[RED("playerClassIcon")] 
		public inkImageWidgetReference PlayerClassIcon
		{
			get => GetProperty(ref _playerClassIcon);
			set => SetProperty(ref _playerClassIcon, value);
		}

		public PlayerListEntryLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
