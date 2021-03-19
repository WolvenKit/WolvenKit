using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IParticleDrawer : ISerializable
	{
		private CFloat _pivotOffset;

		[Ordinal(0)] 
		[RED("pivotOffset")] 
		public CFloat PivotOffset
		{
			get => GetProperty(ref _pivotOffset);
			set => SetProperty(ref _pivotOffset, value);
		}

		public IParticleDrawer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
