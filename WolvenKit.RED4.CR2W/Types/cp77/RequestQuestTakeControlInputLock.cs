using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestQuestTakeControlInputLock : gameScriptableSystemRequest
	{
		private CBool _isLocked;
		private CBool _isChainForced;

		[Ordinal(0)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(1)] 
		[RED("isChainForced")] 
		public CBool IsChainForced
		{
			get => GetProperty(ref _isChainForced);
			set => SetProperty(ref _isChainForced, value);
		}

		public RequestQuestTakeControlInputLock(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
