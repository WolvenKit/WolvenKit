using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDeviceActionBoolData : SDeviceActionData
	{
		private TweakDBID _nameOnTrueRecord;
		private CString _nameOnTrue;
		private TweakDBID _nameOnFalseRecord;
		private CString _nameOnFalse;

		[Ordinal(10)] 
		[RED("nameOnTrueRecord")] 
		public TweakDBID NameOnTrueRecord
		{
			get
			{
				if (_nameOnTrueRecord == null)
				{
					_nameOnTrueRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "nameOnTrueRecord", cr2w, this);
				}
				return _nameOnTrueRecord;
			}
			set
			{
				if (_nameOnTrueRecord == value)
				{
					return;
				}
				_nameOnTrueRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("nameOnTrue")] 
		public CString NameOnTrue
		{
			get
			{
				if (_nameOnTrue == null)
				{
					_nameOnTrue = (CString) CR2WTypeManager.Create("String", "nameOnTrue", cr2w, this);
				}
				return _nameOnTrue;
			}
			set
			{
				if (_nameOnTrue == value)
				{
					return;
				}
				_nameOnTrue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("nameOnFalseRecord")] 
		public TweakDBID NameOnFalseRecord
		{
			get
			{
				if (_nameOnFalseRecord == null)
				{
					_nameOnFalseRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "nameOnFalseRecord", cr2w, this);
				}
				return _nameOnFalseRecord;
			}
			set
			{
				if (_nameOnFalseRecord == value)
				{
					return;
				}
				_nameOnFalseRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("nameOnFalse")] 
		public CString NameOnFalse
		{
			get
			{
				if (_nameOnFalse == null)
				{
					_nameOnFalse = (CString) CR2WTypeManager.Create("String", "nameOnFalse", cr2w, this);
				}
				return _nameOnFalse;
			}
			set
			{
				if (_nameOnFalse == value)
				{
					return;
				}
				_nameOnFalse = value;
				PropertySet(this);
			}
		}

		public SDeviceActionBoolData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
