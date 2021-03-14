using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FollowSlot : IScriptable
	{
		private CInt32 _id;
		private Transform _slotTransform;
		private CBool _isEnabled;
		private CBool _isAvailable;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CInt32) CR2WTypeManager.Create("Int32", "id", cr2w, this);
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
		[RED("slotTransform")] 
		public Transform SlotTransform
		{
			get
			{
				if (_slotTransform == null)
				{
					_slotTransform = (Transform) CR2WTypeManager.Create("Transform", "slotTransform", cr2w, this);
				}
				return _slotTransform;
			}
			set
			{
				if (_slotTransform == value)
				{
					return;
				}
				_slotTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isAvailable")] 
		public CBool IsAvailable
		{
			get
			{
				if (_isAvailable == null)
				{
					_isAvailable = (CBool) CR2WTypeManager.Create("Bool", "isAvailable", cr2w, this);
				}
				return _isAvailable;
			}
			set
			{
				if (_isAvailable == value)
				{
					return;
				}
				_isAvailable = value;
				PropertySet(this);
			}
		}

		public FollowSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
