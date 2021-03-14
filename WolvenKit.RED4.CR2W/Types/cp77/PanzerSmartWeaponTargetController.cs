using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PanzerSmartWeaponTargetController : inkWidgetLogicController
	{
		private inkTextWidgetReference _distanceText;
		private CHandle<inkanimProxy> _lockingAnimationProxy;

		[Ordinal(1)] 
		[RED("distanceText")] 
		public inkTextWidgetReference DistanceText
		{
			get
			{
				if (_distanceText == null)
				{
					_distanceText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "distanceText", cr2w, this);
				}
				return _distanceText;
			}
			set
			{
				if (_distanceText == value)
				{
					return;
				}
				_distanceText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lockingAnimationProxy")] 
		public CHandle<inkanimProxy> LockingAnimationProxy
		{
			get
			{
				if (_lockingAnimationProxy == null)
				{
					_lockingAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "lockingAnimationProxy", cr2w, this);
				}
				return _lockingAnimationProxy;
			}
			set
			{
				if (_lockingAnimationProxy == value)
				{
					return;
				}
				_lockingAnimationProxy = value;
				PropertySet(this);
			}
		}

		public PanzerSmartWeaponTargetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
