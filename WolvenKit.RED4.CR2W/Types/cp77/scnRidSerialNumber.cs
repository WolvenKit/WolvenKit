using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidSerialNumber : CVariable
	{
		private CUInt32 _serialNumber;

		[Ordinal(0)] 
		[RED("serialNumber")] 
		public CUInt32 SerialNumber
		{
			get
			{
				if (_serialNumber == null)
				{
					_serialNumber = (CUInt32) CR2WTypeManager.Create("Uint32", "serialNumber", cr2w, this);
				}
				return _serialNumber;
			}
			set
			{
				if (_serialNumber == value)
				{
					return;
				}
				_serialNumber = value;
				PropertySet(this);
			}
		}

		public scnRidSerialNumber(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
