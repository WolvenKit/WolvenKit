using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInterestingConversationData : ISerializable
	{
		private raRef<scnSceneResource> _sceneFilename;
		private CArray<CHandle<scnIInterruptionOperation>> _interruptionOperations;

		[Ordinal(0)] 
		[RED("sceneFilename")] 
		public raRef<scnSceneResource> SceneFilename
		{
			get => GetProperty(ref _sceneFilename);
			set => SetProperty(ref _sceneFilename, value);
		}

		[Ordinal(1)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get => GetProperty(ref _interruptionOperations);
			set => SetProperty(ref _interruptionOperations, value);
		}

		public scnInterestingConversationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
