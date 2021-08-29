using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LinkedStatusEffect : RedBaseClass
	{
		private CArray<entEntityID> _netrunnerIDs;
		private entEntityID _targetID;
		private CArray<TweakDBID> _statusEffectList;

		[Ordinal(0)] 
		[RED("netrunnerIDs")] 
		public CArray<entEntityID> NetrunnerIDs
		{
			get => GetProperty(ref _netrunnerIDs);
			set => SetProperty(ref _netrunnerIDs, value);
		}

		[Ordinal(1)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		[Ordinal(2)] 
		[RED("statusEffectList")] 
		public CArray<TweakDBID> StatusEffectList
		{
			get => GetProperty(ref _statusEffectList);
			set => SetProperty(ref _statusEffectList, value);
		}
	}
}
