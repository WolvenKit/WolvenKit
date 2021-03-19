using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldGINode : worldNode
	{
		private raRef<CGIDataResource> _data;
		private CArrayFixedSize<CInt16> _location;

		[Ordinal(4)] 
		[RED("data")] 
		public raRef<CGIDataResource> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(5)] 
		[RED("location", 3)] 
		public CArrayFixedSize<CInt16> Location
		{
			get => GetProperty(ref _location);
			set => SetProperty(ref _location, value);
		}

		public worldGINode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
