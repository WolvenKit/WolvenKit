using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GlitchedTurret : Device
	{
		private CHandle<AnimFeature_SensorDevice> _animFeature;

		[Ordinal(86)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SensorDevice> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_SensorDevice>) CR2WTypeManager.Create("handle:AnimFeature_SensorDevice", "animFeature", cr2w, this);
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

		public GlitchedTurret(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
