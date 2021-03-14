using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDeviceControllerInvestigationData : AIbehaviortaskScript
	{
		private wCHandle<ScriptedPuppet> _ownerPuppet;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public wCHandle<ScriptedPuppet> OwnerPuppet
		{
			get
			{
				if (_ownerPuppet == null)
				{
					_ownerPuppet = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "ownerPuppet", cr2w, this);
				}
				return _ownerPuppet;
			}
			set
			{
				if (_ownerPuppet == value)
				{
					return;
				}
				_ownerPuppet = value;
				PropertySet(this);
			}
		}

		public SetDeviceControllerInvestigationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
