using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StaminaListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<PlayerPuppet> _player;
		private CBool _psmAdded;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("psmAdded")] 
		public CBool PsmAdded
		{
			get => GetProperty(ref _psmAdded);
			set => SetProperty(ref _psmAdded, value);
		}

		public StaminaListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
