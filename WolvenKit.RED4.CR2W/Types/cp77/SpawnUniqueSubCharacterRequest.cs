using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpawnUniqueSubCharacterRequest : gameScriptableSystemRequest
	{
		private TweakDBID _subCharacterID;
		private CFloat _desiredDistance;

		[Ordinal(0)] 
		[RED("subCharacterID")] 
		public TweakDBID SubCharacterID
		{
			get => GetProperty(ref _subCharacterID);
			set => SetProperty(ref _subCharacterID, value);
		}

		[Ordinal(1)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get => GetProperty(ref _desiredDistance);
			set => SetProperty(ref _desiredDistance, value);
		}

		public SpawnUniqueSubCharacterRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
