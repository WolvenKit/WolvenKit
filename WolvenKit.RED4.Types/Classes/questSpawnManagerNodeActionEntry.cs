using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSpawnManagerNodeActionEntry : RedBaseClass
	{
		private CHandle<questSpawnManagerNodeType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questSpawnManagerNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
