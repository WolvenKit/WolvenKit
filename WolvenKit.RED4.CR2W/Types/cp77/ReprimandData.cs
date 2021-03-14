using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReprimandData : CVariable
	{
		private CBool _isActive;
		private entEntityID _receiver;
		private CName _receiverAttitudeGroup;
		private CInt32 _reprimandID;
		private CInt32 _count;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("receiver")] 
		public entEntityID Receiver
		{
			get
			{
				if (_receiver == null)
				{
					_receiver = (entEntityID) CR2WTypeManager.Create("entEntityID", "receiver", cr2w, this);
				}
				return _receiver;
			}
			set
			{
				if (_receiver == value)
				{
					return;
				}
				_receiver = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("receiverAttitudeGroup")] 
		public CName ReceiverAttitudeGroup
		{
			get
			{
				if (_receiverAttitudeGroup == null)
				{
					_receiverAttitudeGroup = (CName) CR2WTypeManager.Create("CName", "receiverAttitudeGroup", cr2w, this);
				}
				return _receiverAttitudeGroup;
			}
			set
			{
				if (_receiverAttitudeGroup == value)
				{
					return;
				}
				_receiverAttitudeGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("reprimandID")] 
		public CInt32 ReprimandID
		{
			get
			{
				if (_reprimandID == null)
				{
					_reprimandID = (CInt32) CR2WTypeManager.Create("Int32", "reprimandID", cr2w, this);
				}
				return _reprimandID;
			}
			set
			{
				if (_reprimandID == value)
				{
					return;
				}
				_reprimandID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("count")] 
		public CInt32 Count
		{
			get
			{
				if (_count == null)
				{
					_count = (CInt32) CR2WTypeManager.Create("Int32", "count", cr2w, this);
				}
				return _count;
			}
			set
			{
				if (_count == value)
				{
					return;
				}
				_count = value;
				PropertySet(this);
			}
		}

		public ReprimandData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
