using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCustomActionOperationData : CVariable
	{
		private CName _actionID;
		private SBaseDeviceOperationData _operation;

		[Ordinal(0)] 
		[RED("actionID")] 
		public CName ActionID
		{
			get
			{
				if (_actionID == null)
				{
					_actionID = (CName) CR2WTypeManager.Create("CName", "actionID", cr2w, this);
				}
				return _actionID;
			}
			set
			{
				if (_actionID == value)
				{
					return;
				}
				_actionID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (SBaseDeviceOperationData) CR2WTypeManager.Create("SBaseDeviceOperationData", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		public SCustomActionOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
