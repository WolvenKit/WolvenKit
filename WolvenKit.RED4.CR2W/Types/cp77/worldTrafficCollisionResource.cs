using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficCollisionResource : CResource
	{
		private CHandle<worldTrafficStaticCollisionData> _data;

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<worldTrafficStaticCollisionData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public worldTrafficCollisionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
