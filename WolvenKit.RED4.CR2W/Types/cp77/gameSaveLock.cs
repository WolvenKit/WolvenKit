using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSaveLock : CVariable
	{
		private CEnum<gameSaveLockReason> _reason;

		[Ordinal(0)] 
		[RED("reason")] 
		public CEnum<gameSaveLockReason> Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (CEnum<gameSaveLockReason>) CR2WTypeManager.Create("gameSaveLockReason", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		public gameSaveLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
