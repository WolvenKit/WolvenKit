using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkStyleResourceWrapper : ISerializable
	{
		private CResourceAsyncReference<inkStyleResource> _styleResource;

		[Ordinal(0)] 
		[RED("styleResource")] 
		public CResourceAsyncReference<inkStyleResource> StyleResource
		{
			get => GetProperty(ref _styleResource);
			set => SetProperty(ref _styleResource, value);
		}
	}
}
