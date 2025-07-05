using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyStatusEffectByChanceEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("targetEntityID")] 
		public entEntityID TargetEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("removeWithEffector")] 
		public CBool RemoveWithEffector
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("effectorChanceMods")] 
		public CArray<CWeakHandle<gamedataStatModifier_Record>> EffectorChanceMods
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataStatModifier_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataStatModifier_Record>>>(value);
		}

		public ApplyStatusEffectByChanceEffector()
		{
			TargetEntityID = new entEntityID();
			EffectorChanceMods = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
