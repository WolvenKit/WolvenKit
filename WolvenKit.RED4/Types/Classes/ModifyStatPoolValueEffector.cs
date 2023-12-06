using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyStatPoolValueEffector : HitEventEffector
	{
		[Ordinal(0)] 
		[RED("statPoolUpdates")] 
		public CArray<CWeakHandle<gamedataStatPoolUpdate_Record>> StatPoolUpdates
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataStatPoolUpdate_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataStatPoolUpdate_Record>>>(value);
		}

		[Ordinal(1)] 
		[RED("usePercent")] 
		public CBool UsePercent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("setValue")] 
		public CBool SetValue_
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ModifyStatPoolValueEffector()
		{
			StatPoolUpdates = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
