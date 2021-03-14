using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerRotation : IParticleInitializer
	{
		private CHandle<IEvaluatorFloat> _rotation;

		[Ordinal(4)] 
		[RED("rotation")] 
		public CHandle<IEvaluatorFloat> Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "rotation", cr2w, this);
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

		public CParticleInitializerRotation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
