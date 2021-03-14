using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAppearanceInfo : gameuiCharacterCustomizationInfo
	{
		private raRef<appearanceAppearanceResource> _resource;
		private CArray<gameuiIndexedAppearanceDefinition> _definitions;
		private CBool _useThumbnails;

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("definitions")] 
		public CArray<gameuiIndexedAppearanceDefinition> Definitions
		{
			get
			{
				if (_definitions == null)
				{
					_definitions = (CArray<gameuiIndexedAppearanceDefinition>) CR2WTypeManager.Create("array:gameuiIndexedAppearanceDefinition", "definitions", cr2w, this);
				}
				return _definitions;
			}
			set
			{
				if (_definitions == value)
				{
					return;
				}
				_definitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("useThumbnails")] 
		public CBool UseThumbnails
		{
			get
			{
				if (_useThumbnails == null)
				{
					_useThumbnails = (CBool) CR2WTypeManager.Create("Bool", "useThumbnails", cr2w, this);
				}
				return _useThumbnails;
			}
			set
			{
				if (_useThumbnails == value)
				{
					return;
				}
				_useThumbnails = value;
				PropertySet(this);
			}
		}

		public gameuiAppearanceInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
