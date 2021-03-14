using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneStateOverride : CVariable
	{
		private CName _templateStateName;
		private CName _enterEventOverride;
		private CName _exitEventOverride;

		[Ordinal(0)] 
		[RED("templateStateName")] 
		public CName TemplateStateName
		{
			get
			{
				if (_templateStateName == null)
				{
					_templateStateName = (CName) CR2WTypeManager.Create("CName", "templateStateName", cr2w, this);
				}
				return _templateStateName;
			}
			set
			{
				if (_templateStateName == value)
				{
					return;
				}
				_templateStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enterEventOverride")] 
		public CName EnterEventOverride
		{
			get
			{
				if (_enterEventOverride == null)
				{
					_enterEventOverride = (CName) CR2WTypeManager.Create("CName", "enterEventOverride", cr2w, this);
				}
				return _enterEventOverride;
			}
			set
			{
				if (_enterEventOverride == value)
				{
					return;
				}
				_enterEventOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("exitEventOverride")] 
		public CName ExitEventOverride
		{
			get
			{
				if (_exitEventOverride == null)
				{
					_exitEventOverride = (CName) CR2WTypeManager.Create("CName", "exitEventOverride", cr2w, this);
				}
				return _exitEventOverride;
			}
			set
			{
				if (_exitEventOverride == value)
				{
					return;
				}
				_exitEventOverride = value;
				PropertySet(this);
			}
		}

		public audioAudioSceneStateOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
