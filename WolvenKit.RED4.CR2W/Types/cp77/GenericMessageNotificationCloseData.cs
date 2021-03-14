using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericMessageNotificationCloseData : inkGameNotificationData
	{
		private CInt32 _identifier;
		private CEnum<GenericMessageNotificationResult> _result;

		[Ordinal(6)] 
		[RED("identifier")] 
		public CInt32 Identifier
		{
			get
			{
				if (_identifier == null)
				{
					_identifier = (CInt32) CR2WTypeManager.Create("Int32", "identifier", cr2w, this);
				}
				return _identifier;
			}
			set
			{
				if (_identifier == value)
				{
					return;
				}
				_identifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("result")] 
		public CEnum<GenericMessageNotificationResult> Result
		{
			get
			{
				if (_result == null)
				{
					_result = (CEnum<GenericMessageNotificationResult>) CR2WTypeManager.Create("GenericMessageNotificationResult", "result", cr2w, this);
				}
				return _result;
			}
			set
			{
				if (_result == value)
				{
					return;
				}
				_result = value;
				PropertySet(this);
			}
		}

		public GenericMessageNotificationCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
