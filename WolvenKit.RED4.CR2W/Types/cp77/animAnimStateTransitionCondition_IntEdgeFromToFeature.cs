using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_IntEdgeFromToFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		private CInt32 _fromValue;
		private CInt32 _toValue;

		[Ordinal(2)] 
		[RED("fromValue")] 
		public CInt32 FromValue
		{
			get
			{
				if (_fromValue == null)
				{
					_fromValue = (CInt32) CR2WTypeManager.Create("Int32", "fromValue", cr2w, this);
				}
				return _fromValue;
			}
			set
			{
				if (_fromValue == value)
				{
					return;
				}
				_fromValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public animAnimStateTransitionCondition_IntEdgeFromToFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
