using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMovingPlatformsSavedState : ISerializable
	{
		private CArray<entEntityID> _mapping;
		private CArray<gameMovingPlatformSavedData> _data;

		[Ordinal(0)] 
		[RED("mapping")] 
		public CArray<entEntityID> Mapping
		{
			get => GetProperty(ref _mapping);
			set => SetProperty(ref _mapping, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CArray<gameMovingPlatformSavedData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
