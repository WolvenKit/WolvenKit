using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LinkedStatusEffect : CVariable
	{
		private CArray<entEntityID> _netrunnerIDs;
		private entEntityID _targetID;
		private CArray<TweakDBID> _statusEffectList;

		[Ordinal(0)] 
		[RED("netrunnerIDs")] 
		public CArray<entEntityID> NetrunnerIDs
		{
			get
			{
				if (_netrunnerIDs == null)
				{
					_netrunnerIDs = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "netrunnerIDs", cr2w, this);
				}
				return _netrunnerIDs;
			}
			set
			{
				if (_netrunnerIDs == value)
				{
					return;
				}
				_netrunnerIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get
			{
				if (_targetID == null)
				{
					_targetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "targetID", cr2w, this);
				}
				return _targetID;
			}
			set
			{
				if (_targetID == value)
				{
					return;
				}
				_targetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("statusEffectList")] 
		public CArray<TweakDBID> StatusEffectList
		{
			get
			{
				if (_statusEffectList == null)
				{
					_statusEffectList = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "statusEffectList", cr2w, this);
				}
				return _statusEffectList;
			}
			set
			{
				if (_statusEffectList == value)
				{
					return;
				}
				_statusEffectList = value;
				PropertySet(this);
			}
		}

		public LinkedStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
