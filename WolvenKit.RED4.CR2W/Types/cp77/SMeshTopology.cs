using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SMeshTopology : CVariable
	{
		private DataBuffer _data;
		private DataBuffer _metadata;

		[Ordinal(0)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("metadata")] 
		public DataBuffer Metadata
		{
			get => GetProperty(ref _metadata);
			set => SetProperty(ref _metadata, value);
		}

		public SMeshTopology(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
