using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerAlpha : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _alpha;

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

		public CParticleInitializerAlpha(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
