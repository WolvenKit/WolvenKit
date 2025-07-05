using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEntityStubComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("entityLocalPosition")] 
		public Vector3 EntityLocalPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("entityLocalRotation")] 
		public Quaternion EntityLocalRotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(2)] 
		[RED("spawnerId")] 
		public gameCommunityID SpawnerId
		{
			get => GetPropertyValue<gameCommunityID>();
			set => SetPropertyValue<gameCommunityID>(value);
		}

		[Ordinal(3)] 
		[RED("ownerCommunityEntryName")] 
		public CName OwnerCommunityEntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("selectedAppearanceName")] 
		public CName SelectedAppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("selectedColorVariantName")] 
		public CName SelectedColorVariantName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameEntityStubComponentPS()
		{
			EntityLocalPosition = new Vector3();
			EntityLocalRotation = new Quaternion { R = 1.000000F };
			SpawnerId = new gameCommunityID { EntityId = new entEntityID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
