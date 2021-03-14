using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance : CVariable
	{
		private raRef<appearanceAppearanceResource> _resource;
		private CName _definition;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
