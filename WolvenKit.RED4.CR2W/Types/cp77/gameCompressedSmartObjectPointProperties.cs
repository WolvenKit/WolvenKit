using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCompressedSmartObjectPointProperties : CVariable
	{
		private CUInt16 _propertyId;

		[Ordinal(0)] 
		[RED("propertyId")] 
		public CUInt16 PropertyId
		{
			get
			{
				if (_propertyId == null)
				{
					_propertyId = (CUInt16) CR2WTypeManager.Create("Uint16", "propertyId", cr2w, this);
				}
				return _propertyId;
			}
			set
			{
				if (_propertyId == value)
				{
					return;
				}
				_propertyId = value;
				PropertySet(this);
			}
		}

		public gameCompressedSmartObjectPointProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
