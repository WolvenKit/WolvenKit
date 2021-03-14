using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakFenceControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<EngDemoContainer> _weakfenceSkillChecks;
		private WeakFenceSetup _weakFenceSetup;

		[Ordinal(103)] 
		[RED("weakfenceSkillChecks")] 
		public CHandle<EngDemoContainer> WeakfenceSkillChecks
		{
			get
			{
				if (_weakfenceSkillChecks == null)
				{
					_weakfenceSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "weakfenceSkillChecks", cr2w, this);
				}
				return _weakfenceSkillChecks;
			}
			set
			{
				if (_weakfenceSkillChecks == value)
				{
					return;
				}
				_weakfenceSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("weakFenceSetup")] 
		public WeakFenceSetup WeakFenceSetup
		{
			get
			{
				if (_weakFenceSetup == null)
				{
					_weakFenceSetup = (WeakFenceSetup) CR2WTypeManager.Create("WeakFenceSetup", "weakFenceSetup", cr2w, this);
				}
				return _weakFenceSetup;
			}
			set
			{
				if (_weakFenceSetup == value)
				{
					return;
				}
				_weakFenceSetup = value;
				PropertySet(this);
			}
		}

		public WeakFenceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
