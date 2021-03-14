using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimRequestID : CVariable
	{
		private CUInt32 _iD;
		private CBool _isValid;

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
		public CBool IsValid
		{
			get
			{
				if (_isValid == null)
				{
					_isValid = (CBool) CR2WTypeManager.Create("Bool", "isValid", cr2w, this);
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

		public StimRequestID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
