using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotItemOverride : CVariable
	{
		private CArray<workWorkspotItemOverridePropOverride> _propOverrides;
		private CArray<workWorkspotItemOverrideItemOverride> _itemOverrides;

		[Ordinal(0)] 
		[RED("propOverrides")] 
		public CArray<workWorkspotItemOverridePropOverride> PropOverrides
		{
			get
			{
				if (_propOverrides == null)
				{
					_propOverrides = (CArray<workWorkspotItemOverridePropOverride>) CR2WTypeManager.Create("array:workWorkspotItemOverridePropOverride", "propOverrides", cr2w, this);
				}
				return _propOverrides;
			}
			set
			{
				if (_propOverrides == value)
				{
					return;
				}
				_propOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemOverrides")] 
		public CArray<workWorkspotItemOverrideItemOverride> ItemOverrides
		{
			get
			{
				if (_itemOverrides == null)
				{
					_itemOverrides = (CArray<workWorkspotItemOverrideItemOverride>) CR2WTypeManager.Create("array:workWorkspotItemOverrideItemOverride", "itemOverrides", cr2w, this);
				}
				return _itemOverrides;
			}
			set
			{
				if (_itemOverrides == value)
				{
					return;
				}
				_itemOverrides = value;
				PropertySet(this);
			}
		}

		public workWorkspotItemOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
