using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleVisWireMasterTwo : gameObject
	{
		private CArray<NodeRef> _dependableEntities;

		[Ordinal(40)] 
		[RED("dependableEntities")] 
		public CArray<NodeRef> DependableEntities
		{
			get => GetProperty(ref _dependableEntities);
			set => SetProperty(ref _dependableEntities, value);
		}
	}
}
