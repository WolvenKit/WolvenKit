using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCustomizationAppearance : gameuiCensorshipInfo
	{
		private CName _name;
		private raRef<appearanceAppearanceResource> _resource;
		private CName _definition;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("resource")] 
		public raRef<appearanceAppearanceResource> Resource
		{
			get
			{
				if (_resource == null)
				{
					_resource = (raRef<appearanceAppearanceResource>) CR2WTypeManager.Create("raRef:appearanceAppearanceResource", "resource", cr2w, this);
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

		[Ordinal(4)] 
		[RED("definition")] 
		public CName Definition
		{
			get
			{
				if (_definition == null)
				{
					_definition = (CName) CR2WTypeManager.Create("CName", "definition", cr2w, this);
				}
				return _definition;
			}
			set
			{
				if (_definition == value)
				{
					return;
				}
				_definition = value;
				PropertySet(this);
			}
		}

		public gameuiCustomizationAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
