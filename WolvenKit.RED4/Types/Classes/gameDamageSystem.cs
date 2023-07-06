using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDamageSystem : gameIDamageSystem
	{
		[Ordinal(0)] 
		[RED("previewTarget")] 
		public previewTargetStruct PreviewTarget
		{
			get => GetPropertyValue<previewTargetStruct>();
			set => SetPropertyValue<previewTargetStruct>(value);
		}

		[Ordinal(1)] 
		[RED("previewLock")] 
		public CBool PreviewLock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("previewRWLockTemp")] 
		public ScriptReentrantRWLock PreviewRWLockTemp
		{
			get => GetPropertyValue<ScriptReentrantRWLock>();
			set => SetPropertyValue<ScriptReentrantRWLock>(value);
		}

		public gameDamageSystem()
		{
			PreviewTarget = new previewTargetStruct();
			PreviewRWLockTemp = new ScriptReentrantRWLock();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
