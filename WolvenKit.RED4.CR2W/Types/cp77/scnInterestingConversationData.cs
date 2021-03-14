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
			get
			{
				if (_sceneFilename == null)
				{
					_sceneFilename = (raRef<scnSceneResource>) CR2WTypeManager.Create("raRef:scnSceneResource", "sceneFilename", cr2w, this);
				}
				return _sceneFilename;
			}
			set
			{
				if (_sceneFilename == value)
				{
					return;
				}
				_sceneFilename = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get
			{
				if (_interruptionOperations == null)
				{
					_interruptionOperations = (CArray<CHandle<scnIInterruptionOperation>>) CR2WTypeManager.Create("array:handle:scnIInterruptionOperation", "interruptionOperations", cr2w, this);
				}
				return _interruptionOperations;
			}
			set
			{
				if (_interruptionOperations == value)
				{
					return;
				}
				_interruptionOperations = value;
				PropertySet(this);
			}
		}

		public scnInterestingConversationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
