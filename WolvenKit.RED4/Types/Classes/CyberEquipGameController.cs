using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberEquipGameController : ArmorEquipGameController
	{
		[Ordinal(46)] 
		[RED("eyesTags")] 
		public CArray<CName> EyesTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(47)] 
		[RED("brainTags")] 
		public CArray<CName> BrainTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(48)] 
		[RED("musculoskeletalTags")] 
		public CArray<CName> MusculoskeletalTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(49)] 
		[RED("nervousTags")] 
		public CArray<CName> NervousTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(50)] 
		[RED("cardiovascularTags")] 
		public CArray<CName> CardiovascularTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(51)] 
		[RED("immuneTags")] 
		public CArray<CName> ImmuneTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(52)] 
		[RED("integumentaryTags")] 
		public CArray<CName> IntegumentaryTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(53)] 
		[RED("handsTags")] 
		public CArray<CName> HandsTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(54)] 
		[RED("armsTags")] 
		public CArray<CName> ArmsTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(55)] 
		[RED("legsTags")] 
		public CArray<CName> LegsTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(56)] 
		[RED("quickSlotTags")] 
		public CArray<CName> QuickSlotTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(57)] 
		[RED("weaponsQuickSlotTags")] 
		public CArray<CName> WeaponsQuickSlotTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(58)] 
		[RED("fragmentTags")] 
		public CArray<CName> FragmentTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public CyberEquipGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
