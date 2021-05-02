using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterGameplayObjectiveRequest : gameScriptableSystemRequest
	{
		private CHandle<GemplayObjectiveData> _objectiveData;

		[Ordinal(0)] 
		[RED("objectiveData")] 
		public CHandle<GemplayObjectiveData> ObjectiveData
		{
			get => GetProperty(ref _objectiveData);
			set => SetProperty(ref _objectiveData, value);
		}

		public RegisterGameplayObjectiveRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
