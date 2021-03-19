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
			get => GetProperty(ref _magnitude);
			set => SetProperty(ref _magnitude, value);
		}

		public gameEffectExecutor_PhysicalImpulseFromInstigator_Value(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
