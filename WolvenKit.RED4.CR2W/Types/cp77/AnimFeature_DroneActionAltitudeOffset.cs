using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DroneActionAltitudeOffset : animAnimFeature
	{
		private CFloat _desiredOffset;

		[Ordinal(0)] 
		[RED("desiredOffset")] 
		public CFloat DesiredOffset
		{
			get
			{
				if (_desiredOffset == null)
				{
					_desiredOffset = (CFloat) CR2WTypeManager.Create("Float", "desiredOffset", cr2w, this);
				}
				return _desiredOffset;
			}
			set
			{
				if (_desiredOffset == value)
				{
					return;
				}
				_desiredOffset = value;
				PropertySet(this);
			}
		}

		public AnimFeature_DroneActionAltitudeOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
