using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponTailSettings : audioAudioMetadata
	{
		private CName _interiorDefault;
		private CName _interiorWide;
		private CName _exteriorWide;
		private CName _exteriorUrbanNarrow;
		private CName _exteriorUrbanStreet;
		private CName _exteriorUrbanStreetWide;
		private CName _exteriorUrbanOpen;
		private CName _exteriorUrbanEnclosed;
		private CName _exteriorBadlandsOpen;
		private CName _exteriorBadlandsCanyon;

		[Ordinal(1)] 
		[RED("interiorDefault")] 
		public CName InteriorDefault
		{
			get
			{
				if (_interiorDefault == null)
				{
					_interiorDefault = (CName) CR2WTypeManager.Create("CName", "interiorDefault", cr2w, this);
				}
				return _interiorDefault;
			}
			set
			{
				if (_interiorDefault == value)
				{
					return;
				}
				_interiorDefault = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("interiorWide")] 
		public CName InteriorWide
		{
			get
			{
				if (_interiorWide == null)
				{
					_interiorWide = (CName) CR2WTypeManager.Create("CName", "interiorWide", cr2w, this);
				}
				return _interiorWide;
			}
			set
			{
				if (_interiorWide == value)
				{
					return;
				}
				_interiorWide = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("exteriorWide")] 
		public CName ExteriorWide
		{
			get
			{
				if (_exteriorWide == null)
				{
					_exteriorWide = (CName) CR2WTypeManager.Create("CName", "exteriorWide", cr2w, this);
				}
				return _exteriorWide;
			}
			set
			{
				if (_exteriorWide == value)
				{
					return;
				}
				_exteriorWide = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("exteriorUrbanNarrow")] 
		public CName ExteriorUrbanNarrow
		{
			get
			{
				if (_exteriorUrbanNarrow == null)
				{
					_exteriorUrbanNarrow = (CName) CR2WTypeManager.Create("CName", "exteriorUrbanNarrow", cr2w, this);
				}
				return _exteriorUrbanNarrow;
			}
			set
			{
				if (_exteriorUrbanNarrow == value)
				{
					return;
				}
				_exteriorUrbanNarrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("exteriorUrbanStreet")] 
		public CName ExteriorUrbanStreet
		{
			get
			{
				if (_exteriorUrbanStreet == null)
				{
					_exteriorUrbanStreet = (CName) CR2WTypeManager.Create("CName", "exteriorUrbanStreet", cr2w, this);
				}
				return _exteriorUrbanStreet;
			}
			set
			{
				if (_exteriorUrbanStreet == value)
				{
					return;
				}
				_exteriorUrbanStreet = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("exteriorUrbanStreetWide")] 
		public CName ExteriorUrbanStreetWide
		{
			get
			{
				if (_exteriorUrbanStreetWide == null)
				{
					_exteriorUrbanStreetWide = (CName) CR2WTypeManager.Create("CName", "exteriorUrbanStreetWide", cr2w, this);
				}
				return _exteriorUrbanStreetWide;
			}
			set
			{
				if (_exteriorUrbanStreetWide == value)
				{
					return;
				}
				_exteriorUrbanStreetWide = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("exteriorUrbanOpen")] 
		public CName ExteriorUrbanOpen
		{
			get
			{
				if (_exteriorUrbanOpen == null)
				{
					_exteriorUrbanOpen = (CName) CR2WTypeManager.Create("CName", "exteriorUrbanOpen", cr2w, this);
				}
				return _exteriorUrbanOpen;
			}
			set
			{
				if (_exteriorUrbanOpen == value)
				{
					return;
				}
				_exteriorUrbanOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("exteriorUrbanEnclosed")] 
		public CName ExteriorUrbanEnclosed
		{
			get
			{
				if (_exteriorUrbanEnclosed == null)
				{
					_exteriorUrbanEnclosed = (CName) CR2WTypeManager.Create("CName", "exteriorUrbanEnclosed", cr2w, this);
				}
				return _exteriorUrbanEnclosed;
			}
			set
			{
				if (_exteriorUrbanEnclosed == value)
				{
					return;
				}
				_exteriorUrbanEnclosed = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("exteriorBadlandsOpen")] 
		public CName ExteriorBadlandsOpen
		{
			get
			{
				if (_exteriorBadlandsOpen == null)
				{
					_exteriorBadlandsOpen = (CName) CR2WTypeManager.Create("CName", "exteriorBadlandsOpen", cr2w, this);
				}
				return _exteriorBadlandsOpen;
			}
			set
			{
				if (_exteriorBadlandsOpen == value)
				{
					return;
				}
				_exteriorBadlandsOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("exteriorBadlandsCanyon")] 
		public CName ExteriorBadlandsCanyon
		{
			get
			{
				if (_exteriorBadlandsCanyon == null)
				{
					_exteriorBadlandsCanyon = (CName) CR2WTypeManager.Create("CName", "exteriorBadlandsCanyon", cr2w, this);
				}
				return _exteriorBadlandsCanyon;
			}
			set
			{
				if (_exteriorBadlandsCanyon == value)
				{
					return;
				}
				_exteriorBadlandsCanyon = value;
				PropertySet(this);
			}
		}

		public audioWeaponTailSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
