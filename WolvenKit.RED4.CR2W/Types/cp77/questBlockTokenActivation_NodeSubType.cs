using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questBlockTokenActivation_NodeSubType : questIContentTokenManager_NodeSubType
	{
		private CEnum<questBlockAction> _action;
		private CName _source;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questBlockAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<questBlockAction>) CR2WTypeManager.Create("questBlockAction", "action", cr2w, this);
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

		public questBlockTokenActivation_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
