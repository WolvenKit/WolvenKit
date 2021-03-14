using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidTag : CVariable
	{
		private CName _signature;
		private scnRidSerialNumber _serialNumber;

		[Ordinal(0)] 
		[RED("signature")] 
		public CName Signature
		{
			get
			{
				if (_signature == null)
				{
					_signature = (CName) CR2WTypeManager.Create("CName", "signature", cr2w, this);
				}
				return _signature;
			}
			set
			{
				if (_signature == value)
				{
					return;
				}
				_signature = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("serialNumber")] 
		public scnRidSerialNumber SerialNumber
		{
			get
			{
				if (_serialNumber == null)
				{
					_serialNumber = (scnRidSerialNumber) CR2WTypeManager.Create("scnRidSerialNumber", "serialNumber", cr2w, this);
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

		public scnRidTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
