
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSmartGunTargetSortData_Record
	{
		[RED("angleDistUnitSq")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleDistUnitSq
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleDistUnitWeightSq")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleDistUnitWeightSq
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleProximityBonusSq")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleProximityBonusSq
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleProximityThresholdSq")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleProximityThresholdSq
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("previouslyLockedBonusSq")]
		[REDProperty(IsIgnored = true)]
		public CFloat PreviouslyLockedBonusSq
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("worldDistUnitSq")]
		[REDProperty(IsIgnored = true)]
		public CFloat WorldDistUnitSq
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("worldDistUnitWeightSq")]
		[REDProperty(IsIgnored = true)]
		public CFloat WorldDistUnitWeightSq
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("worldProximityBonusSq")]
		[REDProperty(IsIgnored = true)]
		public CFloat WorldProximityBonusSq
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("worldProximityThresholdSq")]
		[REDProperty(IsIgnored = true)]
		public CFloat WorldProximityThresholdSq
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
