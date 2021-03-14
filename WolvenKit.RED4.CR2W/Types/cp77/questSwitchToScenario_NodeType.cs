using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSwitchToScenario_NodeType : questIUIManagerNodeType
	{
		private CName _startScenarioName;
		private CName _endScenarioName;
		private CHandle<inkUserData> _userData;
		private CBool _forceOpenDuringFadeout;

		[Ordinal(0)] 
		[RED("startScenarioName")] 
		public CName StartScenarioName
		{
			get
			{
				if (_startScenarioName == null)
				{
					_startScenarioName = (CName) CR2WTypeManager.Create("CName", "startScenarioName", cr2w, this);
				}
				return _startScenarioName;
			}
			set
			{
				if (_startScenarioName == value)
				{
					return;
				}
				_startScenarioName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("endScenarioName")] 
		public CName EndScenarioName
		{
			get
			{
				if (_endScenarioName == null)
				{
					_endScenarioName = (CName) CR2WTypeManager.Create("CName", "endScenarioName", cr2w, this);
				}
				return _endScenarioName;
			}
			set
			{
				if (_endScenarioName == value)
				{
					return;
				}
				_endScenarioName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("userData")] 
		public CHandle<inkUserData> UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (CHandle<inkUserData>) CR2WTypeManager.Create("handle:inkUserData", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("forceOpenDuringFadeout")] 
		public CBool ForceOpenDuringFadeout
		{
			get
			{
				if (_forceOpenDuringFadeout == null)
				{
					_forceOpenDuringFadeout = (CBool) CR2WTypeManager.Create("Bool", "forceOpenDuringFadeout", cr2w, this);
				}
				return _forceOpenDuringFadeout;
			}
			set
			{
				if (_forceOpenDuringFadeout == value)
				{
					return;
				}
				_forceOpenDuringFadeout = value;
				PropertySet(this);
			}
		}

		public questSwitchToScenario_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
