using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAppearanceNameVisualTagsPreset_AppearanceTags : ISerializable
	{
		private CName _appearanceName;
		private redTagList _visualTags;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("visualTags")] 
		public redTagList VisualTags
		{
			get
			{
				if (_visualTags == null)
				{
					_visualTags = (redTagList) CR2WTypeManager.Create("redTagList", "visualTags", cr2w, this);
				}
				return _visualTags;
			}
			set
			{
				if (_visualTags == value)
				{
					return;
				}
				_visualTags = value;
				PropertySet(this);
			}
		}

		public gameAppearanceNameVisualTagsPreset_AppearanceTags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
