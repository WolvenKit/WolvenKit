using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerHandicapSystem : gameScriptableSystem
	{
		private CBool _canDropHealingConsumable;
		private CBool _canDropAmmo;

		[Ordinal(0)] 
		[RED("canDropHealingConsumable")] 
		public CBool CanDropHealingConsumable
		{
			get => GetProperty(ref _canDropHealingConsumable);
			set => SetProperty(ref _canDropHealingConsumable, value);
		}

		[Ordinal(1)] 
		[RED("canDropAmmo")] 
		public CBool CanDropAmmo
		{
			get => GetProperty(ref _canDropAmmo);
			set => SetProperty(ref _canDropAmmo, value);
		}

		public PlayerHandicapSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
