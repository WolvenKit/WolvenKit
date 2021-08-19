using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatPoolModifierEffector : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private entEntityID _ownerEntityID;
		private gameStatPoolModifier _poolModifier;
		private CEnum<gamedataStatPoolType> _poolType;
		private CEnum<gameStatPoolModificationTypes> _modType;
		private gameStatPoolModifier _previousMod;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get => GetProperty(ref _ownerEntityID);
			set => SetProperty(ref _ownerEntityID, value);
		}

		[Ordinal(2)] 
		[RED("poolModifier")] 
		public gameStatPoolModifier PoolModifier
		{
			get => GetProperty(ref _poolModifier);
			set => SetProperty(ref _poolModifier, value);
		}

		[Ordinal(3)] 
		[RED("poolType")] 
		public CEnum<gamedataStatPoolType> PoolType
		{
			get => GetProperty(ref _poolType);
			set => SetProperty(ref _poolType, value);
		}

		[Ordinal(4)] 
		[RED("modType")] 
		public CEnum<gameStatPoolModificationTypes> ModType
		{
			get => GetProperty(ref _modType);
			set => SetProperty(ref _modType, value);
		}

		[Ordinal(5)] 
		[RED("previousMod")] 
		public gameStatPoolModifier PreviousMod
		{
			get => GetProperty(ref _previousMod);
			set => SetProperty(ref _previousMod, value);
		}

		public ModifyStatPoolModifierEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
