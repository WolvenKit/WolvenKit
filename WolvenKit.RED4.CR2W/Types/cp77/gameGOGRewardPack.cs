using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGOGRewardPack : CVariable
	{
		private CString _id;
		private CString _title;
		private CString _reason;
		private CName _iconSlot;
		private CArray<CUInt64> _rewards;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CString) CR2WTypeManager.Create("String", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("title")] 
		public CString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (CString) CR2WTypeManager.Create("String", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("reason")] 
		public CString Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (CString) CR2WTypeManager.Create("String", "reason", cr2w, this);
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

		[Ordinal(3)] 
		[RED("iconSlot")] 
		public CName IconSlot
		{
			get
			{
				if (_iconSlot == null)
				{
					_iconSlot = (CName) CR2WTypeManager.Create("CName", "iconSlot", cr2w, this);
				}
				return _iconSlot;
			}
			set
			{
				if (_iconSlot == value)
				{
					return;
				}
				_iconSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rewards")] 
		public CArray<CUInt64> Rewards
		{
			get
			{
				if (_rewards == null)
				{
					_rewards = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "rewards", cr2w, this);
				}
				return _rewards;
			}
			set
			{
				if (_rewards == value)
				{
					return;
				}
				_rewards = value;
				PropertySet(this);
			}
		}

		public gameGOGRewardPack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
