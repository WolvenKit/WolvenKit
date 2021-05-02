using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberEquipGameController : ArmorEquipGameController
	{
		private CArray<CName> _eyesTags;
		private CArray<CName> _brainTags;
		private CArray<CName> _musculoskeletalTags;
		private CArray<CName> _nervousTags;
		private CArray<CName> _cardiovascularTags;
		private CArray<CName> _immuneTags;
		private CArray<CName> _integumentaryTags;
		private CArray<CName> _handsTags;
		private CArray<CName> _armsTags;
		private CArray<CName> _legsTags;
		private CArray<CName> _quickSlotTags;
		private CArray<CName> _weaponsQuickSlotTags;
		private CArray<CName> _fragmentTags;

		[Ordinal(47)] 
		[RED("eyesTags")] 
		public CArray<CName> EyesTags
		{
			get => GetProperty(ref _eyesTags);
			set => SetProperty(ref _eyesTags, value);
		}

		[Ordinal(48)] 
		[RED("brainTags")] 
		public CArray<CName> BrainTags
		{
			get => GetProperty(ref _brainTags);
			set => SetProperty(ref _brainTags, value);
		}

		[Ordinal(49)] 
		[RED("musculoskeletalTags")] 
		public CArray<CName> MusculoskeletalTags
		{
			get => GetProperty(ref _musculoskeletalTags);
			set => SetProperty(ref _musculoskeletalTags, value);
		}

		[Ordinal(50)] 
		[RED("nervousTags")] 
		public CArray<CName> NervousTags
		{
			get => GetProperty(ref _nervousTags);
			set => SetProperty(ref _nervousTags, value);
		}

		[Ordinal(51)] 
		[RED("cardiovascularTags")] 
		public CArray<CName> CardiovascularTags
		{
			get => GetProperty(ref _cardiovascularTags);
			set => SetProperty(ref _cardiovascularTags, value);
		}

		[Ordinal(52)] 
		[RED("immuneTags")] 
		public CArray<CName> ImmuneTags
		{
			get => GetProperty(ref _immuneTags);
			set => SetProperty(ref _immuneTags, value);
		}

		[Ordinal(53)] 
		[RED("integumentaryTags")] 
		public CArray<CName> IntegumentaryTags
		{
			get => GetProperty(ref _integumentaryTags);
			set => SetProperty(ref _integumentaryTags, value);
		}

		[Ordinal(54)] 
		[RED("handsTags")] 
		public CArray<CName> HandsTags
		{
			get => GetProperty(ref _handsTags);
			set => SetProperty(ref _handsTags, value);
		}

		[Ordinal(55)] 
		[RED("armsTags")] 
		public CArray<CName> ArmsTags
		{
			get => GetProperty(ref _armsTags);
			set => SetProperty(ref _armsTags, value);
		}

		[Ordinal(56)] 
		[RED("legsTags")] 
		public CArray<CName> LegsTags
		{
			get => GetProperty(ref _legsTags);
			set => SetProperty(ref _legsTags, value);
		}

		[Ordinal(57)] 
		[RED("quickSlotTags")] 
		public CArray<CName> QuickSlotTags
		{
			get => GetProperty(ref _quickSlotTags);
			set => SetProperty(ref _quickSlotTags, value);
		}

		[Ordinal(58)] 
		[RED("weaponsQuickSlotTags")] 
		public CArray<CName> WeaponsQuickSlotTags
		{
			get => GetProperty(ref _weaponsQuickSlotTags);
			set => SetProperty(ref _weaponsQuickSlotTags, value);
		}

		[Ordinal(59)] 
		[RED("fragmentTags")] 
		public CArray<CName> FragmentTags
		{
			get => GetProperty(ref _fragmentTags);
			set => SetProperty(ref _fragmentTags, value);
		}

		public CyberEquipGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
