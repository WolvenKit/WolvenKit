using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameweaponGrenadeReplicatedState : netIEntityState
	{
		[Ordinal(2)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(4)] 
		[RED("currentTransform")] 
		public WorldTransform CurrentTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(5)] 
		[RED("exploded")] 
		public CBool Exploded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("launched")] 
		public CBool Launched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameweaponGrenadeReplicatedState()
		{
			ItemID = new();
			CurrentTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
