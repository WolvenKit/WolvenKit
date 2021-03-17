using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerTotalDamageAgainstHealth : CVariable
	{
		private wCHandle<gameObject> _player;
		private CFloat _totalDamage;
		private CFloat _targetHealth;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("totalDamage")] 
		public CFloat TotalDamage
		{
			get => GetProperty(ref _totalDamage);
			set => SetProperty(ref _totalDamage, value);
		}

		[Ordinal(2)] 
		[RED("targetHealth")] 
		public CFloat TargetHealth
		{
			get => GetProperty(ref _targetHealth);
			set => SetProperty(ref _targetHealth, value);
		}

		public PlayerTotalDamageAgainstHealth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
