using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationVisualTaggedOverride : ISerializable
	{
		private redTagList _visualTags;
		private gameHitShapeContainer _represenationOverride;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("represenationOverride")] 
		public gameHitShapeContainer RepresenationOverride
		{
			get
			{
				if (_represenationOverride == null)
				{
					_represenationOverride = (gameHitShapeContainer) CR2WTypeManager.Create("gameHitShapeContainer", "represenationOverride", cr2w, this);
				}
				return _represenationOverride;
			}
			set
			{
				if (_represenationOverride == value)
				{
					return;
				}
				_represenationOverride = value;
				PropertySet(this);
			}
		}

		public gameHitRepresentationVisualTaggedOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
