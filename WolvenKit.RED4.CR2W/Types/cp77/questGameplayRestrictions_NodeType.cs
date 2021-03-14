using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questGameplayRestrictions_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		private CEnum<questGameplayRestrictionAction> _action;
		private CName _source;
		private CArray<TweakDBID> _restrictionIDs;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questGameplayRestrictionAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<questGameplayRestrictionAction>) CR2WTypeManager.Create("questGameplayRestrictionAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get
			{
				if (_source == null)
				{
					_source = (CName) CR2WTypeManager.Create("CName", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("restrictionIDs")] 
		public CArray<TweakDBID> RestrictionIDs
		{
			get
			{
				if (_restrictionIDs == null)
				{
					_restrictionIDs = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "restrictionIDs", cr2w, this);
				}
				return _restrictionIDs;
			}
			set
			{
				if (_restrictionIDs == value)
				{
					return;
				}
				_restrictionIDs = value;
				PropertySet(this);
			}
		}

		public questGameplayRestrictions_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
