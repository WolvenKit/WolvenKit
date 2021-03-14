using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorAlphaByDistance : IParticleModificator
	{
		private Vector2 _nearBlendDistance;
		private Vector2 _farBlendDistance;

		[Ordinal(4)] 
		[RED("nearBlendDistance")] 
		public Vector2 NearBlendDistance
		{
			get
			{
				if (_nearBlendDistance == null)
				{
					_nearBlendDistance = (Vector2) CR2WTypeManager.Create("Vector2", "nearBlendDistance", cr2w, this);
				}
				return _nearBlendDistance;
			}
			set
			{
				if (_nearBlendDistance == value)
				{
					return;
				}
				_nearBlendDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("farBlendDistance")] 
		public Vector2 FarBlendDistance
		{
			get
			{
				if (_farBlendDistance == null)
				{
					_farBlendDistance = (Vector2) CR2WTypeManager.Create("Vector2", "farBlendDistance", cr2w, this);
				}
				return _farBlendDistance;
			}
			set
			{
				if (_farBlendDistance == value)
				{
					return;
				}
				_farBlendDistance = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorAlphaByDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
