using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpecialProperties : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enemyMarker")] 
		public CBool EnemyMarker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("traps")] 
		public CArray<CEnum<ETrap>> Traps
		{
			get => GetPropertyValue<CArray<CEnum<ETrap>>>();
			set => SetPropertyValue<CArray<CEnum<ETrap>>>(value);
		}

		public SpecialProperties()
		{
			Traps = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
