using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTemplateAppearance : CVariable
	{
		private CName _name;
		private raRef<appearanceAppearanceResource> _appearanceResource;
		private CName _appearanceName;

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
		[RED("appearanceResource")] 
		public raRef<appearanceAppearanceResource> AppearanceResource
		{
			get
			{
				if (_appearanceResource == null)
				{
					_appearanceResource = (raRef<appearanceAppearanceResource>) CR2WTypeManager.Create("raRef:appearanceAppearanceResource", "appearanceResource", cr2w, this);
				}
				return _appearanceResource;
			}
			set
			{
				if (_appearanceResource == value)
				{
					return;
				}
				_appearanceResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get
			{
				if (_appearanceName == null)
				{
					_appearanceName = (CName) CR2WTypeManager.Create("CName", "appearanceName", cr2w, this);
				}
				return _appearanceName;
			}
			set
			{
				if (_appearanceName == value)
				{
					return;
				}
				_appearanceName = value;
				PropertySet(this);
			}
		}

		public entTemplateAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
