using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetGroupsAttitude : questICharacterManagerParameters_NodeSubType
	{
		private CBool _set;
		private CName _group1Name;
		private CName _group2Name;
		private CEnum<EAIAttitude> _attitude;

		[Ordinal(0)] 
		[RED("set")] 
		public CBool Set
		{
			get
			{
				if (_set == null)
				{
					_set = (CBool) CR2WTypeManager.Create("Bool", "set", cr2w, this);
				}
				return _set;
			}
			set
			{
				if (_set == value)
				{
					return;
				}
				_set = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("group1Name")] 
		public CName Group1Name
		{
			get
			{
				if (_group1Name == null)
				{
					_group1Name = (CName) CR2WTypeManager.Create("CName", "group1Name", cr2w, this);
				}
				return _group1Name;
			}
			set
			{
				if (_group1Name == value)
				{
					return;
				}
				_group1Name = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("group2Name")] 
		public CName Group2Name
		{
			get
			{
				if (_group2Name == null)
				{
					_group2Name = (CName) CR2WTypeManager.Create("CName", "group2Name", cr2w, this);
				}
				return _group2Name;
			}
			set
			{
				if (_group2Name == value)
				{
					return;
				}
				_group2Name = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get
			{
				if (_attitude == null)
				{
					_attitude = (CEnum<EAIAttitude>) CR2WTypeManager.Create("EAIAttitude", "attitude", cr2w, this);
				}
				return _attitude;
			}
			set
			{
				if (_attitude == value)
				{
					return;
				}
				_attitude = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerParameters_SetGroupsAttitude(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
