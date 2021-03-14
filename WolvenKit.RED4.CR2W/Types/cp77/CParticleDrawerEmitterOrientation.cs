using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerEmitterOrientation : IParticleDrawer
	{
		private EulerAngles _coordinateSystem;
		private CBool _isGPUBased;

		[Ordinal(1)] 
		[RED("coordinateSystem")] 
		public EulerAngles CoordinateSystem
		{
			get
			{
				if (_coordinateSystem == null)
				{
					_coordinateSystem = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "coordinateSystem", cr2w, this);
				}
				return _coordinateSystem;
			}
			set
			{
				if (_coordinateSystem == value)
				{
					return;
				}
				_coordinateSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isGPUBased")] 
		public CBool IsGPUBased
		{
			get
			{
				if (_isGPUBased == null)
				{
					_isGPUBased = (CBool) CR2WTypeManager.Create("Bool", "isGPUBased", cr2w, this);
				}
				return _isGPUBased;
			}
			set
			{
				if (_isGPUBased == value)
				{
					return;
				}
				_isGPUBased = value;
				PropertySet(this);
			}
		}

		public CParticleDrawerEmitterOrientation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
