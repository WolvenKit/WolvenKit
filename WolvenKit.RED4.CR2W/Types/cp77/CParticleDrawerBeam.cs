using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerBeam : CParticleDrawerFacingBeam
	{
		private CFloat _rotation;

		[Ordinal(9)] 
		[RED("rotation")] 
		public CFloat Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (CFloat) CR2WTypeManager.Create("Float", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		public CParticleDrawerBeam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
