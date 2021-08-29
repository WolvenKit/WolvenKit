using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questBlockTokenActivation_NodeSubType : questIContentTokenManager_NodeSubType
	{
		private CEnum<questBlockAction> _action;
		private CName _source;
		private CBool _resetTokenSpawnTimer;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questBlockAction> Action
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
		[RED("resetTokenSpawnTimer")] 
		public CBool ResetTokenSpawnTimer
		{
			get => GetProperty(ref _resetTokenSpawnTimer);
			set => SetProperty(ref _resetTokenSpawnTimer, value);
		}
	}
}
