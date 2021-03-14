using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelSystemLock : CVariable
	{
		private CName _lockReason;
		private TweakDBID _linkedStatusEffectID;

		[Ordinal(0)] 
		[RED("lockReason")] 
		public CName LockReason
		{
			get
			{
				if (_lockReason == null)
				{
					_lockReason = (CName) CR2WTypeManager.Create("CName", "lockReason", cr2w, this);
				}
				return _lockReason;
			}
			set
			{
				if (_lockReason == value)
				{
					return;
				}
				_lockReason = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("linkedStatusEffectID")] 
		public TweakDBID LinkedStatusEffectID
		{
			get
			{
				if (_linkedStatusEffectID == null)
				{
					_linkedStatusEffectID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "linkedStatusEffectID", cr2w, this);
				}
				return _linkedStatusEffectID;
			}
			set
			{
				if (_linkedStatusEffectID == value)
				{
					return;
				}
				_linkedStatusEffectID = value;
				PropertySet(this);
			}
		}

		public FastTravelSystemLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
