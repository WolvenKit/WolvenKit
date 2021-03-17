using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponGrenadeReplicatedState : netIEntityState
	{
		private wCHandle<gameObject> _instigator;
		private gameItemID _itemID;
		private WorldTransform _currentTransform;
		private CBool _exploded;
		private CBool _launched;

		[Ordinal(2)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(3)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(4)] 
		[RED("currentTransform")] 
		public WorldTransform CurrentTransform
		{
			get => GetProperty(ref _currentTransform);
			set => SetProperty(ref _currentTransform, value);
		}

		[Ordinal(5)] 
		[RED("exploded")] 
		public CBool Exploded
		{
			get => GetProperty(ref _exploded);
			set => SetProperty(ref _exploded, value);
		}

		[Ordinal(6)] 
		[RED("launched")] 
		public CBool Launched
		{
			get => GetProperty(ref _launched);
			set => SetProperty(ref _launched, value);
		}

		public gameweaponGrenadeReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
