using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhoneMessageNotificationViewData : gameuiQuestUpdateNotificationViewData
	{
		private CInt32 _threadHash;
		private CInt32 _contactHash;

		[Ordinal(14)] 
		[RED("threadHash")] 
		public CInt32 ThreadHash
		{
			get
			{
				if (_threadHash == null)
				{
					_threadHash = (CInt32) CR2WTypeManager.Create("Int32", "threadHash", cr2w, this);
				}
				return _threadHash;
			}
			set
			{
				if (_threadHash == value)
				{
					return;
				}
				_threadHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("contactHash")] 
		public CInt32 ContactHash
		{
			get
			{
				if (_contactHash == null)
				{
					_contactHash = (CInt32) CR2WTypeManager.Create("Int32", "contactHash", cr2w, this);
				}
				return _contactHash;
			}
			set
			{
				if (_contactHash == value)
				{
					return;
				}
				_contactHash = value;
				PropertySet(this);
			}
		}

		public gameuiPhoneMessageNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
