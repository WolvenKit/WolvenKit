using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SToggleOperationData : CVariable
	{
		private CInt32 _index;
		private CBool _enable;
		private CEnum<EOperationClassType> _classType;

		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("classType")] 
		public CEnum<EOperationClassType> ClassType
		{
			get
			{
				if (_classType == null)
				{
					_classType = (CEnum<EOperationClassType>) CR2WTypeManager.Create("EOperationClassType", "classType", cr2w, this);
				}
				return _classType;
			}
			set
			{
				if (_classType == value)
				{
					return;
				}
				_classType = value;
				PropertySet(this);
			}
		}

		public SToggleOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
