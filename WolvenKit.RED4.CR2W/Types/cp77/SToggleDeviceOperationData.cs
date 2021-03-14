using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SToggleDeviceOperationData : CVariable
	{
		private CName _operationName;
		private CBool _enable;

		[Ordinal(0)] 
		[RED("operationName")] 
		public CName OperationName
		{
			get
			{
				if (_operationName == null)
				{
					_operationName = (CName) CR2WTypeManager.Create("CName", "operationName", cr2w, this);
				}
				return _operationName;
			}
			set
			{
				if (_operationName == value)
				{
					return;
				}
				_operationName = value;
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

		public SToggleDeviceOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
