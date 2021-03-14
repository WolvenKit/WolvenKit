using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetAssessmentRequest : ScriptableDeviceAction
	{
		private wCHandle<gameObject> _targetToAssess;

		[Ordinal(25)] 
		[RED("targetToAssess")] 
		public wCHandle<gameObject> TargetToAssess
		{
			get
			{
				if (_targetToAssess == null)
				{
					_targetToAssess = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetToAssess", cr2w, this);
				}
				return _targetToAssess;
			}
			set
			{
				if (_targetToAssess == value)
				{
					return;
				}
				_targetToAssess = value;
				PropertySet(this);
			}
		}

		public TargetAssessmentRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
