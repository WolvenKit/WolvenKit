using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVisualTagsSchema : ISerializable
	{
		private redTagList _visualTags;
		private CName _schema;

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
		[RED("schema")] 
		public CName Schema
		{
			get
			{
				if (_schema == null)
				{
					_schema = (CName) CR2WTypeManager.Create("CName", "schema", cr2w, this);
				}
				return _schema;
			}
			set
			{
				if (_schema == value)
				{
					return;
				}
				_schema = value;
				PropertySet(this);
			}
		}

		public entVisualTagsSchema(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
