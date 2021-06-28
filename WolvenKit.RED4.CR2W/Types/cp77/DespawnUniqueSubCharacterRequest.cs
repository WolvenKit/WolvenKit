using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DespawnUniqueSubCharacterRequest : gameScriptableSystemRequest
	{
		private TweakDBID _subCharacterID;

		[Ordinal(0)] 
		[RED("subCharacterID")] 
		public TweakDBID SubCharacterID
		{
			get => GetProperty(ref _subCharacterID);
			set => SetProperty(ref _subCharacterID, value);
		}

		public DespawnUniqueSubCharacterRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
