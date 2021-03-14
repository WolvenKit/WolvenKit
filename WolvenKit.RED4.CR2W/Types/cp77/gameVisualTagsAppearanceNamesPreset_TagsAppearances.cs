using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisualTagsAppearanceNamesPreset_TagsAppearances : ISerializable
	{
		private CName _visualTagHash;
		private CArray<CName> _appearanceNames;

		[Ordinal(0)] 
		[RED("visualTagHash")] 
		public CName VisualTagHash
		{
			get
			{
				if (_visualTagHash == null)
				{
					_visualTagHash = (CName) CR2WTypeManager.Create("CName", "visualTagHash", cr2w, this);
				}
				return _visualTagHash;
			}
			set
			{
				if (_visualTagHash == value)
				{
					return;
				}
				_visualTagHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("appearanceNames")] 
		public CArray<CName> AppearanceNames
		{
			get
			{
				if (_appearanceNames == null)
				{
					_appearanceNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "appearanceNames", cr2w, this);
				}
				return _appearanceNames;
			}
			set
			{
				if (_appearanceNames == value)
				{
					return;
				}
				_appearanceNames = value;
				PropertySet(this);
			}
		}

		public gameVisualTagsAppearanceNamesPreset_TagsAppearances(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
