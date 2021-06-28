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
			get => GetProperty(ref _visualTags);
			set => SetProperty(ref _visualTags, value);
		}

		[Ordinal(1)] 
		[RED("schema")] 
		public CName Schema
		{
			get => GetProperty(ref _schema);
			set => SetProperty(ref _schema, value);
		}

		public entVisualTagsSchema(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
