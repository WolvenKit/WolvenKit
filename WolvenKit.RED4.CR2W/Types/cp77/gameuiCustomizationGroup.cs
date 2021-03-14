using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCustomizationGroup : CVariable
	{
		private CName _name;
		private CArray<gameuiCustomizationAppearance> _customization;
		private CArray<gameuiCustomizationMorph> _morphs;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("customization")] 
		public CArray<gameuiCustomizationAppearance> Customization
		{
			get
			{
				if (_customization == null)
				{
					_customization = (CArray<gameuiCustomizationAppearance>) CR2WTypeManager.Create("array:gameuiCustomizationAppearance", "customization", cr2w, this);
				}
				return _customization;
			}
			set
			{
				if (_customization == value)
				{
					return;
				}
				_customization = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("morphs")] 
		public CArray<gameuiCustomizationMorph> Morphs
		{
			get
			{
				if (_morphs == null)
				{
					_morphs = (CArray<gameuiCustomizationMorph>) CR2WTypeManager.Create("array:gameuiCustomizationMorph", "morphs", cr2w, this);
				}
				return _morphs;
			}
			set
			{
				if (_morphs == value)
				{
					return;
				}
				_morphs = value;
				PropertySet(this);
			}
		}

		public gameuiCustomizationGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
