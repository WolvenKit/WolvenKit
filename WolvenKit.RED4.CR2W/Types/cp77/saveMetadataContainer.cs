using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class saveMetadataContainer : ISerializable
	{
		private saveMetadata _metadata;

		[Ordinal(0)] 
		[RED("metadata")] 
		public saveMetadata Metadata
		{
			get => GetProperty(ref _metadata);
			set => SetProperty(ref _metadata, value);
		}

		public saveMetadataContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
