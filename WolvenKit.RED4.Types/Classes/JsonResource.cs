using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JsonResource : CResource
	{
		private CHandle<ISerializable> _root;

		[Ordinal(1)] 
		[RED("root")] 
		public CHandle<ISerializable> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}
	}
}
