using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpecialProperties : RedBaseClass
	{
		private CBool _enemyMarker;
		private CArray<CEnum<ETrap>> _traps;

		[Ordinal(0)] 
		[RED("enemyMarker")] 
		public CBool EnemyMarker
		{
			get => GetProperty(ref _enemyMarker);
			set => SetProperty(ref _enemyMarker, value);
		}

		[Ordinal(1)] 
		[RED("traps")] 
		public CArray<CEnum<ETrap>> Traps
		{
			get => GetProperty(ref _traps);
			set => SetProperty(ref _traps, value);
		}
	}
}
