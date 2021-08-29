using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntityStubComponentPS : gameComponentPS
	{
		private Vector3 _entityLocalPosition;
		private Quaternion _entityLocalRotation;
		private gameCommunityID _spawnerId;
		private CName _ownerCommunityEntryName;
		private CName _selectedAppearanceName;

		[Ordinal(0)] 
		[RED("entityLocalPosition")] 
		public Vector3 EntityLocalPosition
		{
			get => GetProperty(ref _entityLocalPosition);
			set => SetProperty(ref _entityLocalPosition, value);
		}

		[Ordinal(1)] 
		[RED("entityLocalRotation")] 
		public Quaternion EntityLocalRotation
		{
			get => GetProperty(ref _entityLocalRotation);
			set => SetProperty(ref _entityLocalRotation, value);
		}

		[Ordinal(2)] 
		[RED("spawnerId")] 
		public gameCommunityID SpawnerId
		{
			get => GetProperty(ref _spawnerId);
			set => SetProperty(ref _spawnerId, value);
		}

		[Ordinal(3)] 
		[RED("ownerCommunityEntryName")] 
		public CName OwnerCommunityEntryName
		{
			get => GetProperty(ref _ownerCommunityEntryName);
			set => SetProperty(ref _ownerCommunityEntryName, value);
		}

		[Ordinal(4)] 
		[RED("selectedAppearanceName")] 
		public CName SelectedAppearanceName
		{
			get => GetProperty(ref _selectedAppearanceName);
			set => SetProperty(ref _selectedAppearanceName, value);
		}
	}
}
