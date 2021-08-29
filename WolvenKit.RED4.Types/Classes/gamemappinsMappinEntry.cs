using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemappinsMappinEntry : RedBaseClass
	{
		private gameNewMappinID _id;
		private CName _type;
		private Vector4 _worldPosition;

		[Ordinal(0)] 
		[RED("id")] 
		public gameNewMappinID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CName Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}
	}
}
