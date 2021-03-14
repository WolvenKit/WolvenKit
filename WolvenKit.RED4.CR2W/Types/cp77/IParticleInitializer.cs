using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IParticleInitializer : IParticleModule
	{
		private CUInt32 _seed;

		[Ordinal(3)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get
			{
				if (_seed == null)
				{
					_seed = (CUInt32) CR2WTypeManager.Create("Uint32", "seed", cr2w, this);
				}
				return _seed;
			}
			set
			{
				if (_seed == value)
				{
					return;
				}
				_seed = value;
				PropertySet(this);
			}
		}

		public IParticleInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
