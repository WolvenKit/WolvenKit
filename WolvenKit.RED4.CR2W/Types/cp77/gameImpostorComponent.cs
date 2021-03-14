using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameImpostorComponent : entIComponent
	{
		private CBool _isCharacterReplica;
		private CBool _addHead;
		private CBool _ignorePlayerHeadSlot;
		private CArray<TweakDBID> _slotIDsToOmit;

		[Ordinal(3)] 
		[RED("isCharacterReplica")] 
		public CBool IsCharacterReplica
		{
			get
			{
				if (_isCharacterReplica == null)
				{
					_isCharacterReplica = (CBool) CR2WTypeManager.Create("Bool", "isCharacterReplica", cr2w, this);
				}
				return _isCharacterReplica;
			}
			set
			{
				if (_isCharacterReplica == value)
				{
					return;
				}
				_isCharacterReplica = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("addHead")] 
		public CBool AddHead
		{
			get
			{
				if (_addHead == null)
				{
					_addHead = (CBool) CR2WTypeManager.Create("Bool", "addHead", cr2w, this);
				}
				return _addHead;
			}
			set
			{
				if (_addHead == value)
				{
					return;
				}
				_addHead = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ignorePlayerHeadSlot")] 
		public CBool IgnorePlayerHeadSlot
		{
			get
			{
				if (_ignorePlayerHeadSlot == null)
				{
					_ignorePlayerHeadSlot = (CBool) CR2WTypeManager.Create("Bool", "ignorePlayerHeadSlot", cr2w, this);
				}
				return _ignorePlayerHeadSlot;
			}
			set
			{
				if (_ignorePlayerHeadSlot == value)
				{
					return;
				}
				_ignorePlayerHeadSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("slotIDsToOmit")] 
		public CArray<TweakDBID> SlotIDsToOmit
		{
			get
			{
				if (_slotIDsToOmit == null)
				{
					_slotIDsToOmit = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "slotIDsToOmit", cr2w, this);
				}
				return _slotIDsToOmit;
			}
			set
			{
				if (_slotIDsToOmit == value)
				{
					return;
				}
				_slotIDsToOmit = value;
				PropertySet(this);
			}
		}

		public gameImpostorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
