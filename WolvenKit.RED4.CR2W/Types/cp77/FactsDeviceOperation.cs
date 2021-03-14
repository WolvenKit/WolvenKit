using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FactsDeviceOperation : DeviceOperationBase
	{
		private CArray<SFactOperationData> _facts;

		[Ordinal(5)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get
			{
				if (_facts == null)
				{
					_facts = (CArray<SFactOperationData>) CR2WTypeManager.Create("array:SFactOperationData", "facts", cr2w, this);
				}
				return _facts;
			}
			set
			{
				if (_facts == value)
				{
					return;
				}
				_facts = value;
				PropertySet(this);
			}
		}

		public FactsDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
