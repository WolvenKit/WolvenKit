using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redResourceListResource : CResource
	{
		private CArray<raRef<CResource>> _resources;
		private CArray<CString> _descriptions;

		[Ordinal(1)] 
		[RED("resources")] 
		public CArray<raRef<CResource>> Resources
		{
			get => GetProperty(ref _resources);
			set => SetProperty(ref _resources, value);
		}

		[Ordinal(2)] 
		[RED("descriptions")] 
		public CArray<CString> Descriptions
		{
			get => GetProperty(ref _descriptions);
			set => SetProperty(ref _descriptions, value);
		}

		public redResourceListResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
