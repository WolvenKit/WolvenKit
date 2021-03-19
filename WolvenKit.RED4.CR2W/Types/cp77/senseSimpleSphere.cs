using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseSimpleSphere : senseIShape
	{
		private Sphere _sphere;

		[Ordinal(1)] 
		[RED("sphere")] 
		public Sphere Sphere
		{
			get => GetProperty(ref _sphere);
			set => SetProperty(ref _sphere, value);
		}

		public senseSimpleSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
