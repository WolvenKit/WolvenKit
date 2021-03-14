using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorColorOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorColor> _color;
		private CBool _modulate;

		[Ordinal(4)] 
		[RED("color")] 
		public CHandle<IEvaluatorColor> Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CHandle<IEvaluatorColor>) CR2WTypeManager.Create("handle:IEvaluatorColor", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
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

		public CParticleModificatorColorOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
