using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameAttachedEvent : redEvent
	{
		private CBool _isGameplayRelevant;
		private CString _displayName;
		private TweakDBID _contentScale;

		[Ordinal(0)] 
		[RED("isGameplayRelevant")] 
		public CBool IsGameplayRelevant
		{
			get => GetProperty(ref _isGameplayRelevant);
			set => SetProperty(ref _isGameplayRelevant, value);
		}

		[Ordinal(1)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}

		[Ordinal(2)] 
		[RED("contentScale")] 
		public TweakDBID ContentScale
		{
			get => GetProperty(ref _contentScale);
			set => SetProperty(ref _contentScale, value);
		}

		public GameAttachedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
