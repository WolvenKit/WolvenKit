using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntEdgeToFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		private CInt32 _toValue;

		[Ordinal(2)] 
		[RED("toValue")] 
		public CInt32 ToValue
		{
			get
			{
				if (_toValue == null)
				{
					_toValue = (CInt32) CR2WTypeManager.Create("Int32", "toValue", cr2w, this);
				}
				return _toValue;
			}
			set
			{
				if (_toValue == value)
				{
					return;
				}
				_toValue = value;
				PropertySet(this);
			}
		}

		public animAnimStateTransitionCondition_IntEdgeToFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
