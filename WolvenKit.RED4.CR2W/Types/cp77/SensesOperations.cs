using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SensesOperations : DeviceOperations
	{
		private CArray<SSensesOperationData> _sensesOperations;

		[Ordinal(2)] 
		[RED("sensesOperations")] 
		public CArray<SSensesOperationData> SensesOperations_
		{
			get
			{
				if (_sensesOperations == null)
				{
					_sensesOperations = (CArray<SSensesOperationData>) CR2WTypeManager.Create("array:SSensesOperationData", "sensesOperations", cr2w, this);
				}
				return _sensesOperations;
			}
			set
			{
				if (_sensesOperations == value)
				{
					return;
				}
				_sensesOperations = value;
				PropertySet(this);
			}
		}

		public SensesOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
