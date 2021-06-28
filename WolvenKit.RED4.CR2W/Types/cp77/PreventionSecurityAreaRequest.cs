using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionSecurityAreaRequest : gameScriptableSystemRequest
	{
		private CBool _playerIsIn;
		private gamePersistentID _areaID;

		[Ordinal(0)] 
		[RED("playerIsIn")] 
		public CBool PlayerIsIn
		{
			get => GetProperty(ref _playerIsIn);
			set => SetProperty(ref _playerIsIn, value);
		}

		[Ordinal(1)] 
		[RED("areaID")] 
		public gamePersistentID AreaID
		{
			get => GetProperty(ref _areaID);
			set => SetProperty(ref _areaID, value);
		}

		public PreventionSecurityAreaRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
