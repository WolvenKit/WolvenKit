using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CoverActionDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _coverActionStateId;
		private gamebbScriptID_Bool _playerNearValidEdge;
		private gamebbScriptID_Bool _debugLeaning;
		private gamebbScriptID_Bool _debugAutoLeaning;
		private gamebbScriptID_Bool _debugDpadLeaning;
		private gamebbScriptID_Bool _debugLsLeaning;
		private gamebbScriptID_Bool _debugStagesLeaning;
		private gamebbScriptID_Bool _debugAdsLeaning;

		[Ordinal(0)] 
		[RED("coverActionStateId")] 
		public gamebbScriptID_Int32 CoverActionStateId
		{
			get => GetProperty(ref _coverActionStateId);
			set => SetProperty(ref _coverActionStateId, value);
		}

		[Ordinal(1)] 
		[RED("playerNearValidEdge")] 
		public gamebbScriptID_Bool PlayerNearValidEdge
		{
			get => GetProperty(ref _playerNearValidEdge);
			set => SetProperty(ref _playerNearValidEdge, value);
		}

		[Ordinal(2)] 
		[RED("debugLeaning")] 
		public gamebbScriptID_Bool DebugLeaning
		{
			get => GetProperty(ref _debugLeaning);
			set => SetProperty(ref _debugLeaning, value);
		}

		[Ordinal(3)] 
		[RED("debugAutoLeaning")] 
		public gamebbScriptID_Bool DebugAutoLeaning
		{
			get => GetProperty(ref _debugAutoLeaning);
			set => SetProperty(ref _debugAutoLeaning, value);
		}

		[Ordinal(4)] 
		[RED("debugDpadLeaning")] 
		public gamebbScriptID_Bool DebugDpadLeaning
		{
			get => GetProperty(ref _debugDpadLeaning);
			set => SetProperty(ref _debugDpadLeaning, value);
		}

		[Ordinal(5)] 
		[RED("debugLsLeaning")] 
		public gamebbScriptID_Bool DebugLsLeaning
		{
			get => GetProperty(ref _debugLsLeaning);
			set => SetProperty(ref _debugLsLeaning, value);
		}

		[Ordinal(6)] 
		[RED("debugStagesLeaning")] 
		public gamebbScriptID_Bool DebugStagesLeaning
		{
			get => GetProperty(ref _debugStagesLeaning);
			set => SetProperty(ref _debugStagesLeaning, value);
		}

		[Ordinal(7)] 
		[RED("debugAdsLeaning")] 
		public gamebbScriptID_Bool DebugAdsLeaning
		{
			get => GetProperty(ref _debugAdsLeaning);
			set => SetProperty(ref _debugAdsLeaning, value);
		}

		public CoverActionDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
