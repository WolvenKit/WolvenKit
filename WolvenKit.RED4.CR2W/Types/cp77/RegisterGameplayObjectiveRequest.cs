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
			get
			{
				if (_objectiveData == null)
				{
					_objectiveData = (CHandle<GemplayObjectiveData>) CR2WTypeManager.Create("handle:GemplayObjectiveData", "objectiveData", cr2w, this);
				}
				return _objectiveData;
			}
			set
			{
				if (_objectiveData == value)
				{
					return;
				}
				_objectiveData = value;
				PropertySet(this);
			}
		}

		public RegisterGameplayObjectiveRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
