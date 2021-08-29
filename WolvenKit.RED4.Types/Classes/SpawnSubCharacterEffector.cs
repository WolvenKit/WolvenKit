using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpawnSubCharacterEffector : gameEffector
	{
		private CWeakHandle<gameObject> _owner;
		private TweakDBID _subCharacterTDBID;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("subCharacterTDBID")] 
		public TweakDBID SubCharacterTDBID
		{
			get => GetProperty(ref _subCharacterTDBID);
			set => SetProperty(ref _subCharacterTDBID, value);
		}
	}
}
