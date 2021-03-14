using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointRequest : gameScriptableSystemRequest
	{
		private TweakDBID _record;
		private CEnum<DropPointPackageStatus> _status;
		private gamePersistentID _holder;

		[Ordinal(0)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get
			{
				if (_record == null)
				{
					_record = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "record", cr2w, this);
				}
				return _record;
			}
			set
			{
				if (_record == value)
				{
					return;
				}
				_record = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<DropPointPackageStatus> Status
		{
			get
			{
				if (_status == null)
				{
					_status = (CEnum<DropPointPackageStatus>) CR2WTypeManager.Create("DropPointPackageStatus", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("holder")] 
		public gamePersistentID Holder
		{
			get
			{
				if (_holder == null)
				{
					_holder = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "holder", cr2w, this);
				}
				return _holder;
			}
			set
			{
				if (_holder == value)
				{
					return;
				}
				_holder = value;
				PropertySet(this);
			}
		}

		public DropPointRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
