using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_PhysicalImpulseFromInstigator_Value : gameEffectExecutor
	{
		private CFloat _magnitude;

		[Ordinal(1)] 
		[RED("magnitude")] 
		public CFloat Magnitude
		{
			get
			{
				if (_magnitude == null)
				{
					_magnitude = (CFloat) CR2WTypeManager.Create("Float", "magnitude", cr2w, this);
				}
				return _magnitude;
			}
			set
			{
				if (_magnitude == value)
				{
					return;
				}
				_magnitude = value;
				PropertySet(this);
			}
		}

		public gameEffectExecutor_PhysicalImpulseFromInstigator_Value(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
