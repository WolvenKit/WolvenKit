using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCookedAreaData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("volume")] 
		public CHandle<gamemappinsIMappinVolume> Volume
		{
			get => GetPropertyValue<CHandle<gamemappinsIMappinVolume>>();
			set => SetPropertyValue<CHandle<gamemappinsIMappinVolume>>(value);
		}

		public gameCookedAreaData()
		{
			EntityID = new entEntityID();
			Position = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
