using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerLifeTime : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _lifeTime;

		[Ordinal(4)] 
		[RED("lifeTime")] 
		public CHandle<IEvaluatorFloat> LifeTime
		{
			get
			{
				if (_lifeTime == null)
				{
					_lifeTime = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "lifeTime", cr2w, this);
				}
				return _lifeTime;
			}
			set
			{
				if (_lifeTime == value)
				{
					return;
				}
				_lifeTime = value;
				PropertySet(this);
			}
		}

		public CParticleInitializerLifeTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
