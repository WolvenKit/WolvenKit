using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorAlphaOverLife : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _alpha;
		private CBool _modulate;

		[Ordinal(4)] 
		[RED("alpha")] 
		public CHandle<IEvaluatorFloat> Alpha
		{
			get
			{
				if (_alpha == null)
				{
					_alpha = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "alpha", cr2w, this);
				}
				return _alpha;
			}
			set
			{
				if (_alpha == value)
				{
					return;
				}
				_alpha = value;
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

		public CParticleModificatorAlphaOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
