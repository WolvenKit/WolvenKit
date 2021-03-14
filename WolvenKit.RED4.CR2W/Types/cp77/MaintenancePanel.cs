using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MaintenancePanel : InteractiveMasterDevice
	{
		private CHandle<AnimFeature_SimpleDevice> _animFeature;

		[Ordinal(93)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_SimpleDevice>) CR2WTypeManager.Create("handle:AnimFeature_SimpleDevice", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		public MaintenancePanel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
