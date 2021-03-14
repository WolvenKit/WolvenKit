using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorRotation3DOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _rotation;
		private CBool _modulate;

		[Ordinal(4)] 
		[RED("rotation")] 
		public CHandle<IEvaluatorVector> Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "rotation", cr2w, this);
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

		[Ordinal(5)] 
		[RED("modulate")] 
		public CBool Modulate
		{
			get
			{
				if (_modulate == null)
				{
					_modulate = (CBool) CR2WTypeManager.Create("Bool", "modulate", cr2w, this);
				}
				return _modulate;
			}
			set
			{
				if (_modulate == value)
				{
					return;
				}
				_modulate = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorRotation3DOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
