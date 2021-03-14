using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakspotRecordData : CVariable
	{
		private CBool _isInvulnerable;
		private TweakDBID _slotID;
		private CBool _reducedMeleeDamage;

		[Ordinal(0)] 
		[RED("isInvulnerable")] 
		public CBool IsInvulnerable
		{
			get
			{
				if (_isInvulnerable == null)
				{
					_isInvulnerable = (CBool) CR2WTypeManager.Create("Bool", "isInvulnerable", cr2w, this);
				}
				return _isInvulnerable;
			}
			set
			{
				if (_isInvulnerable == value)
				{
					return;
				}
				_isInvulnerable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("reducedMeleeDamage")] 
		public CBool ReducedMeleeDamage
		{
			get
			{
				if (_reducedMeleeDamage == null)
				{
					_reducedMeleeDamage = (CBool) CR2WTypeManager.Create("Bool", "reducedMeleeDamage", cr2w, this);
				}
				return _reducedMeleeDamage;
			}
			set
			{
				if (_reducedMeleeDamage == value)
				{
					return;
				}
				_reducedMeleeDamage = value;
				PropertySet(this);
			}
		}

		public WeakspotRecordData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
