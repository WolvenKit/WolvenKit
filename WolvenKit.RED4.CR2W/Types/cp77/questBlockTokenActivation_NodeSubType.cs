using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questBlockTokenActivation_NodeSubType : questIContentTokenManager_NodeSubType
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

		public questBlockTokenActivation_NodeSubType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
