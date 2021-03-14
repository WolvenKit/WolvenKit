using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationUiPresetInfo : CVariable
	{
		private CName _name;
		private raRef<gameuiCharacterCustomizationUiPreset> _resource;

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
		[RED("resource")] 
		public raRef<gameuiCharacterCustomizationUiPreset> Resource
		{
			get
			{
				if (_resource == null)
				{
					_resource = (raRef<gameuiCharacterCustomizationUiPreset>) CR2WTypeManager.Create("raRef:gameuiCharacterCustomizationUiPreset", "resource", cr2w, this);
				}
				return _resource;
			}
			set
			{
				if (_resource == value)
				{
					return;
				}
				_resource = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationUiPresetInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
