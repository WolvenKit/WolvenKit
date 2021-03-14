using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionAgents : IScriptable
	{
		private CName _groupName;
		private CArray<SPreventionAgentData> _requsteredAgents;

		[Ordinal(0)] 
		[RED("groupName")] 
		public CName GroupName
		{
			get
			{
				if (_groupName == null)
				{
					_groupName = (CName) CR2WTypeManager.Create("CName", "groupName", cr2w, this);
				}
				return _groupName;
			}
			set
			{
				if (_groupName == value)
				{
					return;
				}
				_groupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("requsteredAgents")] 
		public CArray<SPreventionAgentData> RequsteredAgents
		{
			get
			{
				if (_requsteredAgents == null)
				{
					_requsteredAgents = (CArray<SPreventionAgentData>) CR2WTypeManager.Create("array:SPreventionAgentData", "requsteredAgents", cr2w, this);
				}
				return _requsteredAgents;
			}
			set
			{
				if (_requsteredAgents == value)
				{
					return;
				}
				_requsteredAgents = value;
				PropertySet(this);
			}
		}

		public PreventionAgents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
