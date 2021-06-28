using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerTargetChangedRequest : gameScriptableSystemRequest
	{
		private entEntityID _playerTarget;

		[Ordinal(0)] 
		[RED("playerTarget")] 
		public entEntityID PlayerTarget
		{
			get => GetProperty(ref _playerTarget);
			set => SetProperty(ref _playerTarget, value);
		}

		public PlayerTargetChangedRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
