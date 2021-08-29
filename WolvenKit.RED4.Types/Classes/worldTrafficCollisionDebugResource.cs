using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficCollisionDebugResource : CResource
	{
		private CHandle<worldTrafficCollisionDebug> _data;

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<worldTrafficCollisionDebug> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
