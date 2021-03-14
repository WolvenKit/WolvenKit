using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckVectorIsValid : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _actionTweakIDMapping;
		private Vector4 _value;

		[Ordinal(0)] 
		[RED("actionTweakIDMapping")] 
		public CHandle<AIArgumentMapping> ActionTweakIDMapping
		{
			get
			{
				if (_actionTweakIDMapping == null)
				{
					_actionTweakIDMapping = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "actionTweakIDMapping", cr2w, this);
				}
				return _actionTweakIDMapping;
			}
			set
			{
				if (_actionTweakIDMapping == value)
				{
					return;
				}
				_actionTweakIDMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("value")] 
		public Vector4 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (Vector4) CR2WTypeManager.Create("Vector4", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public CheckVectorIsValid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
