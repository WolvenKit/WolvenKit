using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AdamSmasherHealthChangeListener : gameCustomValueStatPoolsListener
	{
		private CWeakHandle<NPCPuppet> _owner;
		private CWeakHandle<PlayerPuppet> _player;
		private CHandle<AdamSmasherComponent> _adamSmasherComponent;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(2)] 
		[RED("adamSmasherComponent")] 
		public CHandle<AdamSmasherComponent> AdamSmasherComponent
		{
			get => GetProperty(ref _adamSmasherComponent);
			set => SetProperty(ref _adamSmasherComponent, value);
		}

		[Ordinal(3)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(4)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetProperty(ref _statPoolSystem);
			set => SetProperty(ref _statPoolSystem, value);
		}
	}
}
