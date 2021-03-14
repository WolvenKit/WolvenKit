using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnGameplayTransitionEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private CEnum<scnPuppetVehicleState> _vehState;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get
			{
				if (_performer == null)
				{
					_performer = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performer", cr2w, this);
				}
				return _performer;
			}
			set
			{
				if (_performer == value)
				{
					return;
				}
				_performer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("vehState")] 
		public CEnum<scnPuppetVehicleState> VehState
		{
			get
			{
				if (_vehState == null)
				{
					_vehState = (CEnum<scnPuppetVehicleState>) CR2WTypeManager.Create("scnPuppetVehicleState", "vehState", cr2w, this);
				}
				return _vehState;
			}
			set
			{
				if (_vehState == value)
				{
					return;
				}
				_vehState = value;
				PropertySet(this);
			}
		}

		public scnGameplayTransitionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
