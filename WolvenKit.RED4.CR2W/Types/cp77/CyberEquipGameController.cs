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
			get
			{
				if (_eyesTags == null)
				{
					_eyesTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "eyesTags", cr2w, this);
				}
				return _eyesTags;
			}
			set
			{
				if (_eyesTags == value)
				{
					return;
				}
				_eyesTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("brainTags")] 
		public CArray<CName> BrainTags
		{
			get
			{
				if (_brainTags == null)
				{
					_brainTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "brainTags", cr2w, this);
				}
				return _brainTags;
			}
			set
			{
				if (_brainTags == value)
				{
					return;
				}
				_brainTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("musculoskeletalTags")] 
		public CArray<CName> MusculoskeletalTags
		{
			get
			{
				if (_musculoskeletalTags == null)
				{
					_musculoskeletalTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "musculoskeletalTags", cr2w, this);
				}
				return _musculoskeletalTags;
			}
			set
			{
				if (_musculoskeletalTags == value)
				{
					return;
				}
				_musculoskeletalTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("nervousTags")] 
		public CArray<CName> NervousTags
		{
			get
			{
				if (_nervousTags == null)
				{
					_nervousTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "nervousTags", cr2w, this);
				}
				return _nervousTags;
			}
			set
			{
				if (_nervousTags == value)
				{
					return;
				}
				_nervousTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("cardiovascularTags")] 
		public CArray<CName> CardiovascularTags
		{
			get
			{
				if (_cardiovascularTags == null)
				{
					_cardiovascularTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "cardiovascularTags", cr2w, this);
				}
				return _cardiovascularTags;
			}
			set
			{
				if (_cardiovascularTags == value)
				{
					return;
				}
				_cardiovascularTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("immuneTags")] 
		public CArray<CName> ImmuneTags
		{
			get
			{
				if (_immuneTags == null)
				{
					_immuneTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "immuneTags", cr2w, this);
				}
				return _immuneTags;
			}
			set
			{
				if (_immuneTags == value)
				{
					return;
				}
				_immuneTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("integumentaryTags")] 
		public CArray<CName> IntegumentaryTags
		{
			get
			{
				if (_integumentaryTags == null)
				{
					_integumentaryTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "integumentaryTags", cr2w, this);
				}
				return _integumentaryTags;
			}
			set
			{
				if (_integumentaryTags == value)
				{
					return;
				}
				_integumentaryTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("handsTags")] 
		public CArray<CName> HandsTags
		{
			get
			{
				if (_handsTags == null)
				{
					_handsTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "handsTags", cr2w, this);
				}
				return _handsTags;
			}
			set
			{
				if (_handsTags == value)
				{
					return;
				}
				_handsTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("armsTags")] 
		public CArray<CName> ArmsTags
		{
			get
			{
				if (_armsTags == null)
				{
					_armsTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "armsTags", cr2w, this);
				}
				return _armsTags;
			}
			set
			{
				if (_armsTags == value)
				{
					return;
				}
				_armsTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("legsTags")] 
		public CArray<CName> LegsTags
		{
			get
			{
				if (_legsTags == null)
				{
					_legsTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "legsTags", cr2w, this);
				}
				return _legsTags;
			}
			set
			{
				if (_legsTags == value)
				{
					return;
				}
				_legsTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("quickSlotTags")] 
		public CArray<CName> QuickSlotTags
		{
			get
			{
				if (_quickSlotTags == null)
				{
					_quickSlotTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "quickSlotTags", cr2w, this);
				}
				return _quickSlotTags;
			}
			set
			{
				if (_quickSlotTags == value)
				{
					return;
				}
				_quickSlotTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("weaponsQuickSlotTags")] 
		public CArray<CName> WeaponsQuickSlotTags
		{
			get
			{
				if (_weaponsQuickSlotTags == null)
				{
					_weaponsQuickSlotTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "weaponsQuickSlotTags", cr2w, this);
				}
				return _weaponsQuickSlotTags;
			}
			set
			{
				if (_weaponsQuickSlotTags == value)
				{
					return;
				}
				_weaponsQuickSlotTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("fragmentTags")] 
		public CArray<CName> FragmentTags
		{
			get
			{
				if (_fragmentTags == null)
				{
					_fragmentTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "fragmentTags", cr2w, this);
				}
				return _fragmentTags;
			}
			set
			{
				if (_fragmentTags == value)
				{
					return;
				}
				_fragmentTags = value;
				PropertySet(this);
			}
		}

		public CyberEquipGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
