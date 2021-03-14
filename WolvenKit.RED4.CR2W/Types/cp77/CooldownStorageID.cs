using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CooldownStorageID : CVariable
	{
		private CUInt32 _iD;
		private CEnum<EBOOL> _isValid;

		[Ordinal(0)] 
		[RED("ID")] 
		public CUInt32 ID
		{
			get
			{
				if (_iD == null)
				{
					_iD = (CUInt32) CR2WTypeManager.Create("Uint32", "ID", cr2w, this);
				}
				return _iD;
			}
			set
			{
				if (_iD == value)
				{
					return;
				}
				_iD = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isValid")] 
		public CEnum<EBOOL> IsValid
		{
			get
			{
				if (_isValid == null)
				{
					_isValid = (CEnum<EBOOL>) CR2WTypeManager.Create("EBOOL", "isValid", cr2w, this);
				}
				return _isValid;
			}
			set
			{
				if (_isValid == value)
				{
					return;
				}
				_isValid = value;
				PropertySet(this);
			}
		}

		public CooldownStorageID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
