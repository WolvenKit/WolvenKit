using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entVisualTagsSchema : ISerializable
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
	}
}
