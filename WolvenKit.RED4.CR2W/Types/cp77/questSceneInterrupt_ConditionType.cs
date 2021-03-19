using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSceneInterrupt_ConditionType : questISceneConditionType
	{
		private raRef<scnSceneResource> _sceneFile;
		private CBool _onlyInSafeMoment;
		private CArray<CHandle<scnIInterruptCondition>> _interruptConditions;

		[Ordinal(0)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
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

		public questSceneInterrupt_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
