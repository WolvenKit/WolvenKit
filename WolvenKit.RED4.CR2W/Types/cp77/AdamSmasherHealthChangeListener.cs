using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AdamSmasherHealthChangeListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<NPCPuppet> _owner;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<AdamSmasherComponent> _adamSmasherComponent;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
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

		public AdamSmasherHealthChangeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
