using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSceneInterrupt_ConditionType : questISceneConditionType
	{
		private CResourceAsyncReference<scnSceneResource> _sceneFile;
		private CBool _onlyInSafeMoment;
		private CArray<CHandle<scnIInterruptCondition>> _interruptConditions;

		[Ordinal(0)] 
		[RED("sceneFile")] 
		public CResourceAsyncReference<scnSceneResource> SceneFile
		{
			get => GetProperty(ref _sceneFile);
			set => SetProperty(ref _sceneFile, value);
		}

		[Ordinal(1)] 
		[RED("onlyInSafeMoment")] 
		public CBool OnlyInSafeMoment
		{
			get => GetProperty(ref _onlyInSafeMoment);
			set => SetProperty(ref _onlyInSafeMoment, value);
		}

		[Ordinal(2)] 
		[RED("interruptConditions")] 
		public CArray<CHandle<scnIInterruptCondition>> InterruptConditions
		{
			get => GetProperty(ref _interruptConditions);
			set => SetProperty(ref _interruptConditions, value);
		}

		public questSceneInterrupt_ConditionType()
		{
			_onlyInSafeMoment = true;
		}
	}
}
