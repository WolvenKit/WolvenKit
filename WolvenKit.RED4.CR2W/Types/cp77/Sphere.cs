using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sphere : CVariable
	{
		private Vector4 _centerRadius2;

		[Ordinal(0)] 
		[RED("CenterRadius2")] 
		public Vector4 CenterRadius2
		{
			get => GetProperty(ref _centerRadius2);
			set => SetProperty(ref _centerRadius2, value);
		}

		public Sphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
