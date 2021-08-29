using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questGameplayRestrictions_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		private CEnum<questGameplayRestrictionAction> _action;
		private CName _source;
		private CArray<TweakDBID> _restrictionIDs;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questGameplayRestrictionAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(2)] 
		[RED("restrictionIDs")] 
		public CArray<TweakDBID> RestrictionIDs
		{
			get => GetProperty(ref _restrictionIDs);
			set => SetProperty(ref _restrictionIDs, value);
		}
	}
}
